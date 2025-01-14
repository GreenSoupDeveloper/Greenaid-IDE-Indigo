
namespace Greenaid_IDE_Indigo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLastFileOpenedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGreenaidIDEIndigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHTMLFileInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.compileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.createFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.openLastFileOpenedToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.createFileToolStripMenuItem.Text = "New File";
            this.createFileToolStripMenuItem.Click += new System.EventHandler(this.createFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // openLastFileOpenedToolStripMenuItem
            // 
            this.openLastFileOpenedToolStripMenuItem.Name = "openLastFileOpenedToolStripMenuItem";
            this.openLastFileOpenedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.openLastFileOpenedToolStripMenuItem.Text = "Open file recently opened";
            this.openLastFileOpenedToolStripMenuItem.Click += new System.EventHandler(this.openLastFileOpenedToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.optionsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGreenaidIDEIndigoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutGreenaidIDEIndigoToolStripMenuItem
            // 
            this.aboutGreenaidIDEIndigoToolStripMenuItem.Name = "aboutGreenaidIDEIndigoToolStripMenuItem";
            this.aboutGreenaidIDEIndigoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aboutGreenaidIDEIndigoToolStripMenuItem.Text = "About Greenaid IDE Indigo...";
            this.aboutGreenaidIDEIndigoToolStripMenuItem.Click += new System.EventHandler(this.aboutGreenaidIDEIndigoToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileCToolStripMenuItem,
            this.openHTMLFileInBrowserToolStripMenuItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.compileToolStripMenuItem.Text = "Compile";
            // 
            // compileCToolStripMenuItem
            // 
            this.compileCToolStripMenuItem.Name = "compileCToolStripMenuItem";
            this.compileCToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.compileCToolStripMenuItem.Text = "Compile Code";
            this.compileCToolStripMenuItem.Click += new System.EventHandler(this.compileCToolStripMenuItem_Click);
            // 
            // openHTMLFileInBrowserToolStripMenuItem
            // 
            this.openHTMLFileInBrowserToolStripMenuItem.Name = "openHTMLFileInBrowserToolStripMenuItem";
            this.openHTMLFileInBrowserToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.openHTMLFileInBrowserToolStripMenuItem.Text = "Open File in Web browser";
            this.openHTMLFileInBrowserToolStripMenuItem.Click += new System.EventHandler(this.openHTMLFileInBrowserToolStripMenuItem_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.mainTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.mainTextBox.BackBrush = null;
            this.mainTextBox.CharHeight = 14;
            this.mainTextBox.CharWidth = 8;
            this.mainTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mainTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.mainTextBox.IsReplaceMode = false;
            this.mainTextBox.Location = new System.Drawing.Point(0, 27);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.mainTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.mainTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("mainTextBox.ServiceColors")));
            this.mainTextBox.Size = new System.Drawing.Size(784, 424);
            this.mainTextBox.TabIndex = 1;
            this.mainTextBox.Zoom = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Greenaid IDE Indigo 25";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLastFileOpenedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGreenaidIDEIndigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openHTMLFileInBrowserToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox mainTextBox;
    }
}

