using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITmod
{
    public partial class Bejelentkezo_Form : Form
    {
        public Bejelentkezo_Form()
        {
            InitializeComponent();
            linkLabel1.LinkArea = new LinkArea(26, 14);
        }
               
                   
        private void Bejelentkezo_Form_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regisztracios_Form regisztracios_form = new Regisztracios_Form();
            if (regisztracios_form.ShowDialog()==DialogResult.OK)
            {
                
            }
                        
            linkLabel1.LinkVisited = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_email.Text.Contains("@"))
            {
                
            } else
            {
                MessageBox.Show("Nem megfelelő az e-mail cím");
            }
        }
    }
}
