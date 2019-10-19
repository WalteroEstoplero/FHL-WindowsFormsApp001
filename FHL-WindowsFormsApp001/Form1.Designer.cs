namespace FHL_WindowsFormsApp001
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBox_Nachname = new System.Windows.Forms.TextBox();
            this.RBtn_rot = new System.Windows.Forms.RadioButton();
            this.RBtn_blau = new System.Windows.Forms.RadioButton();
            this.Btn_Ausgabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TBox_Nachname
            // 
            this.TBox_Nachname.Location = new System.Drawing.Point(125, 53);
            this.TBox_Nachname.Name = "TBox_Nachname";
            this.TBox_Nachname.Size = new System.Drawing.Size(100, 20);
            this.TBox_Nachname.TabIndex = 1;
            this.TBox_Nachname.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // RBtn_rot
            // 
            this.RBtn_rot.AutoSize = true;
            this.RBtn_rot.Location = new System.Drawing.Point(51, 115);
            this.RBtn_rot.Name = "RBtn_rot";
            this.RBtn_rot.Size = new System.Drawing.Size(37, 17);
            this.RBtn_rot.TabIndex = 2;
            this.RBtn_rot.TabStop = true;
            this.RBtn_rot.Text = "rot";
            this.RBtn_rot.UseVisualStyleBackColor = true;
            this.RBtn_rot.CheckedChanged += new System.EventHandler(this.RBtn_rot_CheckedChanged);
            // 
            // RBtn_blau
            // 
            this.RBtn_blau.AutoSize = true;
            this.RBtn_blau.Location = new System.Drawing.Point(51, 170);
            this.RBtn_blau.Name = "RBtn_blau";
            this.RBtn_blau.Size = new System.Drawing.Size(45, 17);
            this.RBtn_blau.TabIndex = 3;
            this.RBtn_blau.TabStop = true;
            this.RBtn_blau.Text = "blau";
            this.RBtn_blau.UseVisualStyleBackColor = true;
            this.RBtn_blau.CheckedChanged += new System.EventHandler(this.RBtn_blau_CheckedChanged);
            // 
            // Btn_Ausgabe
            // 
            this.Btn_Ausgabe.Location = new System.Drawing.Point(51, 218);
            this.Btn_Ausgabe.Name = "Btn_Ausgabe";
            this.Btn_Ausgabe.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ausgabe.TabIndex = 4;
            this.Btn_Ausgabe.Text = "Ausgabe";
            this.Btn_Ausgabe.UseVisualStyleBackColor = true;
            this.Btn_Ausgabe.Click += new System.EventHandler(this.Btn_Ausgabe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Ausgabe);
            this.Controls.Add(this.RBtn_blau);
            this.Controls.Add(this.RBtn_rot);
            this.Controls.Add(this.TBox_Nachname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBox_Nachname;
        private System.Windows.Forms.RadioButton RBtn_rot;
        private System.Windows.Forms.RadioButton RBtn_blau;
        private System.Windows.Forms.Button Btn_Ausgabe;
    }
}

