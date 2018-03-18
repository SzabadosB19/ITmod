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
    public partial class Main_Form : Form
    {
        public string Nev;
        private Felhasznalo bejelentkezettFelhasznalo;

        public Felhasznalo BejelentkezettFelhasznalo
        {
            get { return bejelentkezettFelhasznalo; }
            set { bejelentkezettFelhasznalo = value; }
        }
        public Main_Form()
        {
            InitializeComponent();

            
        }

        private void btn_Keres_Click(object sender, EventArgs e)
        {

        }

        private void btn_Feltolt_Click(object sender, EventArgs e)
        {
            Feltoltes_Form feltoltes_form = new Feltoltes_Form();
            if (feltoltes_form.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void sajátProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profil_Form profil_form = new Profil_Form();

            if (profil_form.ShowDialog()==DialogResult.OK)
            {
                
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            label1.Text = bejelentkezettFelhasznalo.ToString();
        }
    }
}
