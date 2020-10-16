using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using SmartDeviceProject1.Business;
using SmartDeviceProject1.Screen;

namespace SmartDeviceProject1
{
    static class Program
    {
        public static String pathExe = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            ProductBusiness obj = new ProductBusiness();
            //obj.AjouterProduit();
            Application.Run(new Accueil());
        }
    }
}