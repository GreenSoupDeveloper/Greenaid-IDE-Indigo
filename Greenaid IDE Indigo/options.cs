using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenaid_IDE_Indigo
{
    public partial class options : Form
    {
        public static int textsize;
        public FolderBrowserDialog ffol = new FolderBrowserDialog();
        public OpenFileDialog f = new OpenFileDialog();
        public options()
        {
            InitializeComponent();
            if (File.ReadAllText(@"greenaideindigo\theme.dll") == "dark")
            {
                this.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
                this.button1.FlatStyle = FlatStyle.Flat; this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45); this.button1.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.button2.FlatStyle = FlatStyle.Flat; this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45); this.button2.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.button3.FlatStyle = FlatStyle.Flat; this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(45, 45, 45); this.button3.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);



                this.label1.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.label2.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.label3.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.label4.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.label5.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.label7.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
             
                this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25);
                this.tabPage1.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
                this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25);
                this.tabPage2.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
                this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25);
                this.tabPage3.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            }

            if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "es")
            {
                label1.Text = "Opciones de Greenaid IDE Indigo";
                label2.Text = "Temas:";
                label3.Text = "Idiomas:";
                button2.Text = "Oscuro";
                button3.Text = "Claro";
                button1.Text = "Aceptar";
                label4.Text = "Como elegir el directorio para la aplicacion compilada:";
                label5.Text = "Nombre de aplicacion:";
                checkBox1.Text = "Elegir al clickear el boton de 'Compilar codigo de C#'";
                checkBox2.Text = "Elegir un directorio predefinido custom";
                label7.Text = "Directorio del Navegador Web";

            }
            if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "fr")
            {
                label1.Text = "Options de Greenaid IDE Indigo";
                label2.Text = "Thème :";
                label3.Text = "Langue :";
                button2.Text = "Sombre";
                button3.Text = "Clair";
                button1.Text = "Accépter";
                label4.Text = "Méthode de séléction du répertoire de compilation :";
                label5.Text = "Nom de l'application compilé : ";
                checkBox1.Text = "Selectionner le répertoire quand le bouton 'Compiler du code C#' est clické";
                checkBox2.Text = "Selectioner un répertoire prédéfini";
                label7.Text = "Emplacement du navigateur web :";

            }

            if (File.ReadAllText(@"greenaideindigo\compiledirmode.dll") == "")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                textBox1.Enabled = false;
            }
            if (File.ReadAllText(@"greenaideindigo\compiledirmode.dll") == "1")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                textBox1.Enabled = false;
            }
            if (File.ReadAllText(@"greenaideindigo\compiledirmode.dll") == "2")
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                textBox1.Enabled = true;
            }

            textBox1.Text = File.ReadAllText(@"greenaideindigo\compilecustomdir.dll");

            if (File.ReadAllText(@"greenaideindigo\compiledappcustomname.dll") == "")
            {
                File.WriteAllText(@"greenaideindigo\compiledappcustomname.dll", "program");
                
            }
            textBox2.Text = File.ReadAllText(@"greenaideindigo\compiledappcustomname.dll");
            textBox3.Text = File.ReadAllText(@"greenaideindigo\browserloc.dll");

        }

        private void options_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            File.WriteAllText(@"greenaideindigo\compiledappcustomname.dll", textBox2.Text);
            File.WriteAllText(@"greenaideindigo\browserloc.dll", textBox3.Text);

            if (checkBox1.Checked == true)
            {
                File.WriteAllText(@"greenaideindigo\compiledirmode.dll", "1");

            }
            if (checkBox2.Checked == true)
            {
                File.WriteAllText(@"greenaideindigo\compiledirmode.dll", "2");
                File.WriteAllText(@"greenaideindigo\compilecustomdir.dll", textBox1.Text);
            }


            if (comboBox1.SelectedItem == "Español")
            {
                File.WriteAllText(@"greenaideindigo\languaje.dll", "es");
            }
            if (comboBox1.SelectedItem == "English")
            {
                File.WriteAllText(@"greenaideindigo\languaje.dll", "en");
            }
            if (comboBox1.SelectedItem == "Français")
            {
                File.WriteAllText(@"greenaideindigo\languaje.dll", "fr");
            }
            if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "es")
            {
                MessageBox.Show("Para aplicar los cambios, debes reiniciar el programa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "en")
            {
                MessageBox.Show("To apply the changes, you need to restart the program.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            if (File.ReadAllText(@"greenaideindigo\languaje.dll") == "fr")
            {
                MessageBox.Show("Pour appliquer les changements, veuiler redémarrer le programme", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"greenaideindigo\theme.dll","light");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"greenaideindigo\theme.dll", "dark");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
          

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ffol.ShowDialog();
            textBox1.Text = ffol.SelectedPath;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = true;
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = true;
                checkBox1.Checked = false;

                textBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            f.ShowDialog();
            textBox3.Text = f.FileName;
        }
    }
}
