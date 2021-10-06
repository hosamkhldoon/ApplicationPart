
namespace ContactForm
{
    partial class ShowContact
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NamefiltertextBox1 = new System.Windows.Forms.TextBox();
            this.NamecheckBox1 = new System.Windows.Forms.CheckBox();
            this.NameFiltercomboBox1 = new System.Windows.Forms.ComboBox();
            this.TypeFiltercomboBox1 = new System.Windows.Forms.ComboBox();
            this.TypecheckBox1 = new System.Windows.Forms.CheckBox();
            this.SerarchButton = new System.Windows.Forms.Button();
            this.GetAllbutton2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FiletoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExittoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 134);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NameFiltercomboBox1);
            this.tabPage1.Controls.Add(this.NamecheckBox1);
            this.tabPage1.Controls.Add(this.NamefiltertextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Name Filter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TypecheckBox1);
            this.tabPage2.Controls.Add(this.TypeFiltercomboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NamefiltertextBox1
            // 
            this.NamefiltertextBox1.Location = new System.Drawing.Point(23, 20);
            this.NamefiltertextBox1.Name = "NamefiltertextBox1";
            this.NamefiltertextBox1.Size = new System.Drawing.Size(100, 23);
            this.NamefiltertextBox1.TabIndex = 0;
            // 
            // NamecheckBox1
            // 
            this.NamecheckBox1.AutoSize = true;
            this.NamecheckBox1.Location = new System.Drawing.Point(23, 76);
            this.NamecheckBox1.Name = "NamecheckBox1";
            this.NamecheckBox1.Size = new System.Drawing.Size(90, 19);
            this.NamecheckBox1.TabIndex = 1;
            this.NamecheckBox1.Text = "Enable Filter";
            this.NamecheckBox1.UseVisualStyleBackColor = true;
            // 
            // NameFiltercomboBox1
            // 
            this.NameFiltercomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameFiltercomboBox1.FormattingEnabled = true;
            this.NameFiltercomboBox1.Items.AddRange(new object[] {
            "start with",
            "end with",
            "Contain",
            "Not start with",
            "Not End with",
            "Exists",
            "Not contain"});
            this.NameFiltercomboBox1.Location = new System.Drawing.Point(175, 20);
            this.NameFiltercomboBox1.Name = "NameFiltercomboBox1";
            this.NameFiltercomboBox1.Size = new System.Drawing.Size(121, 23);
            this.NameFiltercomboBox1.TabIndex = 2;
            // 
            // TypeFiltercomboBox1
            // 
            this.TypeFiltercomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeFiltercomboBox1.FormattingEnabled = true;
            this.TypeFiltercomboBox1.Items.AddRange(new object[] {
            "Transmission",
            "Reception"});
            this.TypeFiltercomboBox1.Location = new System.Drawing.Point(37, 23);
            this.TypeFiltercomboBox1.Name = "TypeFiltercomboBox1";
            this.TypeFiltercomboBox1.Size = new System.Drawing.Size(121, 23);
            this.TypeFiltercomboBox1.TabIndex = 0;
            // 
            // TypecheckBox1
            // 
            this.TypecheckBox1.AutoSize = true;
            this.TypecheckBox1.Location = new System.Drawing.Point(37, 73);
            this.TypecheckBox1.Name = "TypecheckBox1";
            this.TypecheckBox1.Size = new System.Drawing.Size(90, 19);
            this.TypecheckBox1.TabIndex = 1;
            this.TypecheckBox1.Text = "Enable Filter";
            this.TypecheckBox1.UseVisualStyleBackColor = true;
            // 
            // SerarchButton
            // 
            this.SerarchButton.Location = new System.Drawing.Point(532, 89);
            this.SerarchButton.Name = "SerarchButton";
            this.SerarchButton.Size = new System.Drawing.Size(75, 23);
            this.SerarchButton.TabIndex = 1;
            this.SerarchButton.Text = "Search";
            this.SerarchButton.UseVisualStyleBackColor = true;
            // 
            // GetAllbutton2
            // 
            this.GetAllbutton2.Location = new System.Drawing.Point(521, 134);
            this.GetAllbutton2.Name = "GetAllbutton2";
            this.GetAllbutton2.Size = new System.Drawing.Size(100, 23);
            this.GetAllbutton2.TabIndex = 2;
            this.GetAllbutton2.Text = "GetAllContact";
            this.GetAllbutton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SQL SERVER",
            "ELASTICSEARCH"});
            this.comboBox1.Location = new System.Drawing.Point(512, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiletoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "File";
           
            // 
            // FiletoolStripMenuItem1
            // 
            this.FiletoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpentoolStripMenuItem1,
            this.ExittoolStripMenuItem2});
            this.FiletoolStripMenuItem1.Name = "FiletoolStripMenuItem1";
            this.FiletoolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.FiletoolStripMenuItem1.Text = "File";
            // 
            // OpentoolStripMenuItem1
            // 
            this.OpentoolStripMenuItem1.Name = "OpentoolStripMenuItem1";
            this.OpentoolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.OpentoolStripMenuItem1.Text = "Open";
            // 
            // ExittoolStripMenuItem2
            // 
            this.ExittoolStripMenuItem2.Name = "ExittoolStripMenuItem2";
            this.ExittoolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.ExittoolStripMenuItem2.Text = "Exit";
            // 
            // ShowContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GetAllbutton2);
            this.Controls.Add(this.SerarchButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ShowContact";
            this.Text = "ShowContact";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox NameFiltercomboBox1;
        private System.Windows.Forms.CheckBox NamecheckBox1;
        private System.Windows.Forms.TextBox NamefiltertextBox1;
        private System.Windows.Forms.CheckBox TypecheckBox1;
        private System.Windows.Forms.ComboBox TypeFiltercomboBox1;
        private System.Windows.Forms.Button SerarchButton;
        private System.Windows.Forms.Button GetAllbutton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FiletoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExittoolStripMenuItem2;
    }
}