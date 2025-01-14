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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (Form1.indigoSettings[1] == "theme=dark")
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
            comboBox1.SelectedIndex = 0;
            if (Form1.indigoSettings[3] == "lang=es")
            {
                comboBox1.SelectedIndex = 2;
                label1.Text = "Opciones de Greenaid IDE Indigo";
                label2.Text = "Temas:";
                label3.Text = "Idiomas:";
                button2.Text = "Oscuro";
                button3.Text = "Claro";
                button1.Text = "Aceptar";
                label4.Text = "Como elegir el directorio para la aplicacion compilada:";
                label5.Text = "Nombre de aplicacion:";
                checkBox1.Text = "Elegir al clickear el boton 'Compilar Codigo'";
                checkBox2.Text = "Elegir un directorio predefinido custom";
                label7.Text = "Directorio del Navegador Web";

            }
            if (Form1.indigoSettings[3] == "lang=fr")
            {
                comboBox1.SelectedIndex = 1;
                label1.Text = "Options de Greenaid IDE Indigo";
                label2.Text = "Thèmes :";
                label3.Text = "Langues :";
                button2.Text = "Sombre";
                button3.Text = "Clair";
                button1.Text = "Accepter";
                label4.Text = "Comment choisir le répertoire pour l'application compilée :";
                label5.Text = "Nom de l'application :";
                checkBox1.Text = "Choisir en cliquant sur le bouton 'Compiler le vofr'";
                checkBox2.Text = "Choisir un répertoire prédéfini personnalisé";
                label7.Text = "Répertoire du navigateur Web";


            }


            if (Form1.indigoSettings[5] == "csharpDirMode=0")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                textBox1.Enabled = false;
            }
            if (Form1.indigoSettings[5] == "csharpDirMode=1")
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                textBox1.Enabled = true;
            }
            

            textBox1.Text = Form1.indigoSettings[6].Split(new[] { "=" }, StringSplitOptions.None)[1];


            textBox2.Text = Form1.indigoSettings[7].Split(new[] { "=" }, StringSplitOptions.None)[1];
            textBox3.Text = Form1.indigoSettings[8].Split(new[] { "=" }, StringSplitOptions.None)[1];

        }

        private void options_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1.indigoSettings[7] = "csharpCompiledName=" + textBox2.Text;
            Form1.indigoSettings[8] = "htmlBrowserDir=" + textBox3.Text;

            if (checkBox1.Checked == true)
            {
                Form1.indigoSettings[5] = "csharpDirMode=0";

            }
            if (checkBox2.Checked == true)
            {
                Form1.indigoSettings[5] = "csharpDirMode=1";
                Form1.indigoSettings[6] = "csharpCustomDir=" + textBox1.Text;
            }


            if (comboBox1.SelectedItem == "Español")
            {
                Form1.indigoSettings[3] = "lang=es";
            }
            if (comboBox1.SelectedItem == "English")
            {
                Form1.indigoSettings[3] = "lang=en";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Form1.indigoSettings[3] = "lang=fr";
            }
            if (Form1.indigoSettings[3] == "lang=es")
            {
                MessageBox.Show("Para aplicar los cambios, debes reiniciar el programa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else if (Form1.indigoSettings[3] == "lang=en")
            {
                MessageBox.Show("To apply the changes, you need to restart the program.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else if (Form1.indigoSettings[3] == "lang=fr")
            {
                MessageBox.Show("Pour appliquer les modifications, vous devez redémarrer le programme.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("To apply the changes, you need to restart the program.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\indigoSettings.cfg", Form1.indigoSettings);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.indigoSettings[1] = "theme=light";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.indigoSettings[1] = "theme=dark";
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
