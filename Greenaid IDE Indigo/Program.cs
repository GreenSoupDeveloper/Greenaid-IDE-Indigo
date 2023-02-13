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
                if (File.Exists(@"greenaideindigo\showfirst.dll"))
                {
                    Application.Run(new options());
                    File.Delete(@"greenaideindigo\showfirst.dll");
                }
                if (Directory.Exists(@"greenaideindigo") && File.Exists(@"isprogins.dll"))
                {
                    try
                    {
                        Application.Run(new Form1());
                    }
                    catch (Exception ex)
                    {
                        if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "es")
                        {
                            MessageBox.Show("Sucedio un error mientras estabas usando Greenaid IDE Indigo\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Para arreglar el problema, prueba eliminando la carpeta 'greenaideindigo' en la carpeta del programa y despues abrir el programa", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "en")
                        {
                            MessageBox.Show("Something wrong happen when using Greenaid IDE Indigo\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("To solve the problem, you can try deleting the 'greenaideindigo' folder on the program folder and opening the program again", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }
                    
                }
                if (!Directory.Exists(@"greenaideindigo") || !File.Exists(@"isprogins.dll"))
                {

                    try
                    {
                        MessageBox.Show("The nessesary files for Greenaid IDE Indigo are'nt found so,\nthe files are going to be created right now\n\n\nLos archivos nesesarios de Greenaid IDE Indigo no han sido encontrados asi que,\nlos archivos van a ser creados ahora mismo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        Directory.CreateDirectory(@"greenaideindigo");
                        File.Create(@"isprogins.dll");
                        File.Create(@"greenaideindigo\theme.dll");
                        File.Create(@"greenaideindigo\isprogins.dll");
                        File.Create(@"greenaideindigo\textsize.dll");
                        File.Create(@"greenaideindigo\showfirst.dll");
                        File.Create(@"greenaideindigo\lastfileopened.dll");
                        File.Create(@"greenaideindigo\languaje.dll");
                        File.Create(@"greenaideindigo\compiledirmode.dll");
                        File.Create(@"greenaideindigo\compilecustomdir.dll");
                        File.Create(@"greenaideindigo\compiledappcustomname.dll");
                        File.Create(@"greenaideindigo\browserloc.dll");




                        MessageBox.Show("Created nessesary files for Greenaid IDE Indigo!\nnow open the program again\n\n\nArchivos nesesarios de Greenaid IDE Indigo creados!\nahora abre el programa otra vez", "Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {

                       

                            MessageBox.Show("Something wrong happen when creating the files of Greenaid IDE Indigo\n\nSucedio un error mientras se estaba creando los archivos de Greenaid IDE Indigo\n\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          

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
