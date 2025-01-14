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

                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\indigoSettings.cfg");
                sw.WriteLine("[INDIGO_SETTINGS]");
                sw.WriteLine("theme=light");
                sw.WriteLine("textSize=10");
                sw.WriteLine("lang=en");
                sw.WriteLine("[OTHER]");
                sw.WriteLine("csharpDirMode=0");
                sw.WriteLine("csharpCustomDir=");
                sw.WriteLine("csharpCompiledName=program");
                sw.WriteLine("htmlBrowserDir=");
                sw.WriteLine("lastFileOpened=");
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
        static void Main(string[] args)
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\indigoSettings.cfg"))
                {
                    CreateFiles();
                }
                try
                {
                    string arg = "";
                    if (args.Length > 0)
                        arg = args[0];
                    Form1.indigoSettings = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\indigoSettings.cfg");
                    Application.Run(new Form1(arg));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sucedio un error mientras estabas usando Greenaid IDE Indigo.\n\nSomething wrong happened when using Greenaid IDE Indigo.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
