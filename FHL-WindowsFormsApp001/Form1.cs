using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FHL_WindowsFormsApp001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TBox_Nachname.Text == "Meier")
            {
                MessageBox.Show("Im Textfeld steht der Name Meier");
                label1.Text = "Meier";
                
            }
        }

        string ausgabe;
        private void RBtn_rot_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_rot.Checked == true)
            {
                //TBox_Nachname.Text = "rot";
                ausgabe = "rot";
            }
        }

        private void RBtn_blau_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_blau.Checked == true)
            {
                // TBox_Nachname.Text = "blau";
                ausgabe = "blau";
            }
        }

        private void Btn_Ausgabe_Click(object sender, EventArgs e)
        {
            TBox_Nachname.Text = ausgabe;
        }
    }
}
