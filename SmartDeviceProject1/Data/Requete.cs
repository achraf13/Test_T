using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.IO;

namespace SmartDeviceProject1.Data
{
    class Requete
    {

        public static string FileBase;
        private System.Data.SqlServerCe.SqlCeConnection connexion;


        internal static int ExecuteUpdate(string requête)
        {
            // on gère les éventuelles exceptions
            try
            {

                // ouverture connexion
                SqlCeConnection conne = Connexion.getInstance().OpenConnection();
                // exécute sqlCommand avec requête de mise à jour

                SqlCeCommand sqlCommand = new SqlCeCommand(requête, conne);

                int nbLignes = sqlCommand.ExecuteNonQuery();

                return nbLignes;

            }
            catch (Exception)
            {
                return -1;
            }
        } //ExecuteUppdate


        internal static int ExecuteSet(string requête, string table)
        {

            // ouverture connexion
            SqlCeConnection connection = Connexion.getInstance().OpenConnection();

            SqlCeCommand identChange = connection.CreateCommand();
            identChange.CommandText = "SET IDENTITY_INSERT " + table + " ON";
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandText = requête;
            SqlCeCommand ident = connection.CreateCommand();
            ident.CommandText = "SET IDENTITY_INSERT " + table + " OFF";

            try
            {
                // connection.Open();
                identChange.ExecuteNonQuery();
                int repense = cmd.ExecuteNonQuery();
                ident.ExecuteNonQuery();
                return repense;
            }

            catch (SqlCeException ex)
            {
                //log ex
                return -1;
            }
            finally
            {
                connection.Close();
            }

        } //ExecuteUppdate




        //_______________________________________________________________________________________________________________


        // executer la requete select sans ouvrir la connexion 
        internal static DataSet ExecuteSelectN(string requête, SqlCeConnection connexion)
        {
            connexion = Connexion.getInstance().OpenConnection();
            //using (connexion = Connexion.getInstance().OpenConnection())
            //{
            try
            {



                SqlCeCommand cmd = connexion.CreateCommand();
                cmd.CommandText = requête;
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;

            }
            catch (Exception ex)
            {
                FileInfo fi = new FileInfo(Program.pathExe + "\\log.txt");
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(DateTime.Now + "/ " + ex.Message + " / " + requête + " / Classe Requete M.ExecuteSelectN \r\n");
                    sw.Close();
                }
                //MessageBox.Show(a.ToString());

                return null;

            }
            finally
            {
                //  Connexion.getInstance().closeConnection();
            }
            //}
        }
        //--------------------------------------------------------

        internal static int ExecuteUpdateN(string requête, SqlCeConnection connexion)
        {
            // on gère les éventuelles exceptions
            //connexion = Connexion.getInstance().OpenConnection();
            try
            {
                //using (conne = Connexion.getInstance().OpenConnection())
                //{
                // exécute sqlCommand avec requête de mise à jour

                SqlCeCommand sqlCommand = new SqlCeCommand(requête, connexion);

                int nbLignes = sqlCommand.ExecuteNonQuery();



                return nbLignes;
                //}

            }
            catch (Exception e)
            {
                FileInfo fi = new FileInfo(Program.pathExe + "\\log.txt");
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(DateTime.Now + "/ " + e.Message + " / " + requête + " / Classe Requete M.ExecuteUpdateN \r\n ");
                    sw.Close();
                }
                return -1;
            }
            finally
            {
                //  Connexion.getInstance().closeConnection();
            }

        }

        //-----------------------------------------------------------------------
        internal static int ExecuteUpda(string requête, SqlCeConnection conne)
        {

            SqlCeCommand command = conne.CreateCommand();

            SqlCeTransaction transaction;
            transaction = conne.BeginTransaction();
            command.Transaction = transaction;
            try
            {
                command.CommandText = requête;
                command.ExecuteNonQuery();

                transaction.Commit();
                return 1;
            }
            catch (Exception ex)
            {

                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                    return -1;
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                    //log EX2.Message
                    return -1;
                }
            }
        }







    }
}
