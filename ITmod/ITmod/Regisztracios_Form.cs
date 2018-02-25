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
    public partial class Regisztracios_Form : Form
    {
        public Regisztracios_Form()
        {
            InitializeComponent();
        }

        private void btn_Regisztrálás_Click(object sender, EventArgs e)
        {
            if (tb_jelszo.Text==tb_jelszo_ujra.Text && tb_email.Text.Contains("@"))
            {
                
            }
            else
            {
                if (tb_jelszo.Text!=tb_jelszo_ujra.Text)
                {
                    MessageBox.Show("A két jelszó nem egyezik meg.");
                }

                if (tb_jelszo.Text.Length>0 && tb_jelszo_ujra.Text.Length>0)
                {
                    MessageBox.Show("Nem írt be jelszót!");
                }

                if (!tb_email.Text.Contains("@") || !tb_email.Text.Contains(".") && tb_email.Text.Length>1)
                {
                    MessageBox.Show("Az e-mail cím érvénytelen");
                }
                    
            }
        }
    }
}
