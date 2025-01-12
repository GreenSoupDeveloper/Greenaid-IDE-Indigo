using System;
using System.IO;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

using Microsoft.CSharp;

using System.CodeDom.Compiler;

namespace Greenaid_IDE_Indigo
{
    static class Program
    {
      
        public static void CreateFiles()
        {
            try
            {

                StreamWriter sw = new StreamWriter("indigoSettings.cfg");
                sw.WriteLine("[INDIGO_SETTINGS]");
                sw.WriteLine("theme=light");
                sw.WriteLine("textSize=10");
                sw.WriteLine("lang=en");
                sw.WriteLine("[OTHER]");
                sw.WriteLine("csharpDirMode=0");
                sw.WriteLine("csharpCustomDir=none");
                sw.WriteLine("csharpCompiledName=program");
                sw.WriteLine("htmlBrowserDir=none");
                sw.WriteLine("lastFileOpened=none");
                sw.Close();
             
             





            }
            catch (Exception ex)
            {



                MessageBox.Show("Something wrong happen when creating the files of Greenaid IDE Indigo\n\nSucedio un error mientras se estaba creando los archivos de Greenaid IDE Indigo\n\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (!File.Exists("indigoSettings.cfg"))
                {
                    CreateFiles();
                }
                try
                {
                    Form1.indigoSettings = File.ReadAllLines("indigoSettings.cfg");
                    Application.Run(new Form1());
                }
                catch (Exception ex)
                {
                    if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "es")
                    {
                        MessageBox.Show("Sucedio un error mientras estabas usando Greenaid IDE Indigo.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "en")
                    {
                        MessageBox.Show("Something wrong happened when using Greenaid IDE Indigo.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
