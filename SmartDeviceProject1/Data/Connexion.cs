using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace SmartDeviceProject1.Data
{
    class Connexion
    {
        public static string FileBase;
        public static SqlCeConnection conne = new SqlCeConnection();

        public static Connexion connexion = new Connexion();

        public static Connexion getInstance()
        {
            return connexion;

        }
        private Connexion()
        {
            //DataBasePath("InventwayBDD.sdf");
            //string cS = String.Format("DATA SOURCE = '{0}';", FileBase);

            //conne.ConnectionString = cS;
        }
        //recupérer la chaine de connexion
        public static void DataBasePath(string Database)
        {
            string ExePath = Assembly.GetExecutingAssembly().GetName().CodeBase;
            string startupPath = Path.GetDirectoryName(ExePath);
            FileBase = Path.Combine(startupPath, Database);
            if (!File.Exists(FileBase))
            {
                //MessageBox.Show("erreur de connexion");

                FileInfo fi = new FileInfo(Program.pathExe + "\\log.txt");
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(DateTime.Now + "/ la base de données est introuvable / Classe Connexion \r\n");
                    sw.Close();
                }
            }
        }


        // etablire et ouvrir la connexion 
        public SqlCeConnection OpenConnection()
        {
            DataBasePath("InventwayBDD.sdf");
            string cS = String.Format("DATA SOURCE = '{0}';", FileBase);
            var statut = conne.State;
            if (conne.State.ToString() == "Closed")
            {
                conne.ConnectionString = cS;

                try
                {
                    conne.Open();
                }
                catch (Exception ex)
                {
                    FileInfo fi = new FileInfo(Program.pathExe + "\\log.txt");
                    using (StreamWriter sw = fi.AppendText())
                    {
                        sw.WriteLine(DateTime.Now + "/ " + ex.Message + " / Classe Connexion \r\n");
                        sw.Close();
                    }

                }
            }



            return conne;
        }

        public SqlCeConnection closeConnection()
        {
            DataBasePath("BDDStock.sdf");
            string cS = String.Format("DATA SOURCE = '{0}';", FileBase);

            //conne.ConnectionString = cS;
            try
            {
                conne.Close();


            }
            catch (Exception ex)
            {
                //Console.Write("ereuuur" + ex.ToString());
                //MessageBox.Show("erreur durant la fermeture de la base de données");

                FileInfo fi = new FileInfo(Program.pathExe + "\\log.txt");
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(DateTime.Now + "/ " + ex.Message + " / Classe Connexion \r\n");
                    sw.Close();
                }
                Application.Exit();
            }
            return conne;
        }


    }
}
