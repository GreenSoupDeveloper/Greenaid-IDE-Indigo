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
    public partial class Form1 : Form
    {
        public static string savedir;
        public static bool savebool;

        
        public FolderBrowserDialog ffol = new FolderBrowserDialog();
      
        public static string savefolder;
        public static string openedfiletext;
        public static string[] indigoSettings;

        public Form1()
        {
            InitializeComponent();
            


            if (indigoSettings[1] == "theme=dark")
            {
                this.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);

                this.mainTextBox.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.mainTextBox.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);



                this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45); this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            }
            if (indigoSettings[3] == "lang=fr")
            {
                openFileToolStripMenuItem.Text = "Ouvrir";
                saveFileToolStripMenuItem.Text = "Sauvegarder";
                createFileToolStripMenuItem.Text = "Nouveau fichier";
                openLastFileOpenedToolStripMenuItem.Text = "Ouvrir le dernier fichier ouvert";
                fileToolStripMenuItem.Text = "Fichier";
                optionsToolStripMenuItem.Text = "Options";
                helpToolStripMenuItem.Text = "Aide";
                optionsToolStripMenuItem1.Text = "Options";
                aboutGreenaidIDEIndigoToolStripMenuItem.Text = "A propos de Greenaid IDE...";
                compileCToolStripMenuItem.Text = "Compiler le code C#...";
                compileToolStripMenuItem.Text = "Compiler";
                openHTMLFileInBrowserToolStripMenuItem.Text = "Ouvrir le fichier HTML dans un navigateur web";

            }
            if (indigoSettings[3] == "lang=es")
            {
                openFileToolStripMenuItem.Text = "Abrir Archivo";
                saveFileToolStripMenuItem.Text = "Guardar Archivo";
                createFileToolStripMenuItem.Text = "Nuevo Archivo";
                openLastFileOpenedToolStripMenuItem.Text = "Abrir el ultimo archivo que se ha abierto";
                fileToolStripMenuItem.Text = "Archivo";
                optionsToolStripMenuItem.Text = "Herramientas";
                helpToolStripMenuItem.Text = "Ayuda";
                optionsToolStripMenuItem1.Text = "Opciones";
                aboutGreenaidIDEIndigoToolStripMenuItem.Text = "Acerca de Greenaid IDE Indigo...";
                compileCToolStripMenuItem.Text = "Compilar codigo de C#";
                compileToolStripMenuItem.Text = "Compilar";
                openHTMLFileInBrowserToolStripMenuItem.Text = "Abrir archivo HTML en el Navegador Web";

            }


        }
        public void compile(string file)
        {
            try
            {
                string exename = "";
                if (indigoSettings[5] == "1")
                {
                    exename = indigoSettings[6] + @"\" + indigoSettings[7].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)[1] + ".exe";
                }
                else
                {
                    exename = savefolder + indigoSettings[7].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)[1] + ".exe";
                }


                CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
                CompilerParameters compars = new CompilerParameters();

                compars.GenerateExecutable = true;
                compars.OutputAssembly = exename;
                compars.GenerateInMemory = false;
                compars.TreatWarningsAsErrors = false;

                CompilerResults res = provider.CompileAssemblyFromFile(compars, file);

                if (res.Errors.Count > 0)
                {
                    foreach (CompilerError ce in res.Errors)
                    {
                        if (indigoSettings[3] == "lang=es")
                        {
                            MessageBox.Show("Error de compilación: " + ce.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (indigoSettings[3] == "lang=en")
                        {
                            MessageBox.Show("Compiling Error: " + ce.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                        if (indigoSettings[3] == "lang=es")
                        {
                            MessageBox.Show("Compilado, ahore el ejecutable estara en el directorio seleccionado", "Compilado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Process.Start("explorer.exe", File.ReadAllText(@"greenaideindigo\compilecustomdir.dll"));
                        }
                        if (indigoSettings[3] == "lang=en")
                        {
                            MessageBox.Show("Compiled, now the executable will be in the selected location", "Compiled!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Process.Start("explorer.exe", savefolder);
                        }


                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "Any File| *.*|Text File| *.txt|HTML WebSite| *.html|C# File| *.cs|Python File| *.py|MD File| *.md|Batch File| *.bat|C File| *.c|C++ File| *.cpp|CSS File| *.css|F# File| *.fs|JAVA File| *.jav;*.jar;*.java|JavaScript File| *.js|PHP File| *.php|JSON File| *.json|INI File| *.ini|LUA File| *.lua|Rust File| *.rs|Assembly File| *.asm|Makefile File| *.mk|XML File| *.xml|Visual Basic File| *.vb;*.brs;*.vbs;*.bas;*.vba|DLL File| *.dll";
                f.ShowDialog();
                if (f.FileName != "")
                {
                    savedir = f.FileName;
                    mainTextBox.Text = File.ReadAllText(f.FileName);
                    indigoSettings[9] = "lastFileOpened=" + savedir;
                    File.WriteAllLines("indigoSettings.cfg" , indigoSettings);

                    openedfiletext = File.ReadAllText(f.FileName);

                    if (indigoSettings[3] == "lang=es")
                    {
                        this.Text = "Greenaid IDE Indigo 25 - " + Path.GetFileName(savedir) + " - Archivo abierto";
                    }
                    if (indigoSettings[3] == "lang=en")
                    {
                        this.Text = "Greenaid IDE Indigo 25 - " + Path.GetFileName(savedir) + " - File Opened";
                    }
                }


            }
            catch (Exception ex)
            {

                if (indigoSettings[3] == "lang=es")
                {
                    MessageBox.Show("Algo salio mal abriendo el archivo\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (indigoSettings[3] == "lang=en")
                {
                    MessageBox.Show("Something wrong happened when opening the file\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fsave = new SaveFileDialog();
                fsave.Filter = "Text File| *.txt|HTML WebSite| *.html|C# File| *.cs|Python File| *.py|MD File| *.md|Batch File| *.bat|C File| *.c|C++ File| *.cpp|CSS File| *.css|F# File| *.fs|JAVA File| *.jav;*.jar;*.java|JavaScript File| *.js|PHP File| *.php|JSON File| *.json|INI File| *.ini|LUA File| *.lua|Rust File| *.rs|Assembly File| *.asm|Makefile File| *.mk|XML File| *.xml|Visual Basic File| *.vb;*.brs;*.vbs;*.bas;*.vba|DLL File| *.dll";


                if (File.Exists(savedir))
                {

                    File.WriteAllText(savedir, mainTextBox.Text);

                    if (indigoSettings[3] == "lang=es")
                    {
                        this.Text = "Greenaid IDE Indigo 25 - " + Path.GetFileName(savedir) + " - Archivo guardado";
                    }
                    if (indigoSettings[3] == "lang=en")
                    {
                        this.Text = "Greenaid IDE Indigo 25 - " + Path.GetFileName(savedir) + " - File Saved";
                    }
                // openedfiletext = File.ReadAllText(fsave.FileName);

                }
                if (!File.Exists(savedir))
                {
                    fsave.ShowDialog();
                    savedir = fsave.FileName;
                    File.WriteAllText(savedir, mainTextBox.Text);
                    if (indigoSettings[3] == "lang=es")
                    {
                        this.Text = "Greenaid IDE Indigo 25 - " + Path.GetFileName(savedir) + " - Archivo guardado";
                    }
                    if (indigoSettings[3] == "lang=en")
                    {
                        this.Text = "Greenaid IDE Indigo 25 - " + Path.GetFileName(savedir) + " - File Saved";
                    }
                    //openedfiletext = File.ReadAllText(f.FileName);

                }
            }
            catch (Exception ex)
            {


                if (indigoSettings[3] == "lang=es")
                {
                    MessageBox.Show("Algo salio mal guardando el archivo\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (indigoSettings[3] == "lang=en")
                {
                    MessageBox.Show("Something wrong happen when saving the file\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = "";
            savedir = "";
            if (indigoSettings[3] == "lang=es")
            {
                this.Text = "Greenaid IDE Indigo 23 - Archivo creado";
            }
            if (indigoSettings[3] == "lang=en")
            {
                this.Text = "Greenaid IDE Indigo 23 - File Created";
            }
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new options().Show();
        }

        private void openLastFileOpenedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string thinger = indigoSettings[9].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)[1];

                if (thinger == "none")
                {
                    if (indigoSettings[3] == "lang=es")
                    {
                        MessageBox.Show("Ningun archivo ha sido abierto recientemente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (indigoSettings[3] == "lang=en")
                    {
                        MessageBox.Show("No file has been opened recently", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    savedir = thinger;
                    mainTextBox.Text = File.ReadAllText(thinger);
                    openedfiletext = File.ReadAllText(thinger);
                    if (indigoSettings[3] == "lang=es")
                    {
                        this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo abierto";
                    }
                    if (indigoSettings[3] == "lang=en")
                    {
                        this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File Opened";
                    }
                }



            }
            catch (Exception ex)
            {





            }
        }

        private void aboutGreenaidIDEIndigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().Show();
        }

        private void compileCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                if (Directory.Exists(savefolder))
                {
                    if (!String.IsNullOrEmpty(savedir))
                    {
                        if (Path.GetExtension(savedir) == "cs")
                        {
                            compile(savedir);
                            if (indigoSettings[3] == "lang=es")
                            {
                                this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo compilado";
                            }
                            if (indigoSettings[3] == "lang=en")
                            {
                                this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File Compiled";
                            }
                        }
                        else
                        {
                            this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File not Compiled";
                            if (indigoSettings[3] == "lang=es")
                            {
                                this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo no compilado";
                                MessageBox.Show("Este no es un archivo de C#!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (indigoSettings[3] == "lang=en")
                            {
                                this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File not Compiled";
                                MessageBox.Show("This is not a C# file!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    if (String.IsNullOrEmpty(savedir))
                    {

                        if (indigoSettings[3] == "lang=es")
                        {
                            this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo no compilado";
                            MessageBox.Show("No se puede compilar este archivo porque no existe, guarda el archivo en formato '.cs' para poder compilarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (indigoSettings[3] == "lang=en")
                        {
                            this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File not Compiled";
                            MessageBox.Show("Can't compile because this file doesnt exists, save the file in '.cs' format to be able to compile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                if (!Directory.Exists(savefolder))
                {
                    if (!String.IsNullOrEmpty(savedir))
                    {
                        if (savedir.EndsWith(".cs"))
                        {
                            if (indigoSettings[5] == "csharpDirMode=1")
                            {


                                compile(savedir);
                                if (indigoSettings[3] == "lang=es")
                                {
                                    this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo compilado";
                                }
                                if (indigoSettings[3] == "lang=en")
                                {
                                    this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File Compiled";
                                }
                            }
                            if (indigoSettings[5] == "csharpDirMode=0")
                            {

                                ffol.ShowDialog();
                                savefolder = ffol.SelectedPath + @"\";
                                compile(savedir);
                                if (indigoSettings[3] == "lang=es")
                                {
                                    this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo compilado";
                                }
                                if (indigoSettings[3] == "lang=en")
                                {
                                    this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File Compiled";
                                }

                            }

                        }
                        else
                        {
                            if (indigoSettings[3] == "lang=es")
                            {
                                this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo no compilado";
                                MessageBox.Show("Este no es un archivo de C#!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (indigoSettings[3] == "lang=en")
                            {
                                this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File not Compiled";
                                MessageBox.Show("This is not a C# file!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                        }
                    }
                    if (String.IsNullOrEmpty(savedir))
                    {

                        if (indigoSettings[3] == "lang=es")
                        {
                            this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo no compilado";
                            MessageBox.Show("No se puede compilar este archivo porque no existe, guarda el archivo en formato '.cs' para poder compilarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (indigoSettings[3] == "lang=en")
                        {
                            this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File not Compiled";
                            MessageBox.Show("Can't compile because this file doesnt exists, save the file in '.cs' format to be able to compile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }








            }
            catch (Exception ex)
            {


            }

        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mainTextBox.Text != openedfiletext)
            {
                if (indigoSettings[3] == "lang=es")
                {
                    this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - Archivo no guardado";
                }
                if (indigoSettings[3] == "lang=en")
                {
                    this.Text = "Greenaid IDE Indigo 23 - " + Path.GetFileName(savedir) + " - File not Saved";
                }


            }
        }

        private void openHTMLFileInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(savedir))
                {

                    if (savedir.EndsWith(".html"))
                    {
                        Process.Start(indigoSettings[8].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)[1], savedir);
                    }
                    if (!savedir.EndsWith(".html"))
                    {

                        if (indigoSettings[3] == "lang=es")
                        {
                            MessageBox.Show("Este no es un archivo HTML!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (indigoSettings[3] == "lang=en")
                        {
                            MessageBox.Show("This is not a HTML file!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                if (String.IsNullOrEmpty(savedir))
                {
                    if (indigoSettings[3] == "lang=es")
                    {
                        MessageBox.Show("Este no es un archivo HTML!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (indigoSettings[3] == "lang=en")
                    {
                        MessageBox.Show("This is not a HTML file!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    /*
      if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "es")
               {

               }
if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "en")
{

}
    */

}
