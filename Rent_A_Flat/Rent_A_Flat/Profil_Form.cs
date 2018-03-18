using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Flat
{
    public partial class Profil_Form : Form
    {
        public Profil_Form()
        {
            InitializeComponent();
        }

        private void btn_modosit_Click(object sender, EventArgs e)
        {
            tb_nev.ReadOnly = false;
            tb_email.ReadOnly = false;
            tb_cim.ReadOnly = false;
            tb_jelszo.ReadOnly = false;
            tb_jelszo_ujra.ReadOnly = false;
            tb_telefon_1.ReadOnly = false;
            cb_telefon.Enabled = true;
            tb_telefon_3.ReadOnly = false;
        }
    }
}
