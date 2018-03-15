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
    public partial class Bejelentkezes_Form : Form
    {
        public Bejelentkezes_Form()
        {
            InitializeComponent();
            linkLabel1.LinkArea = new LinkArea(26, 13);
            
        }

        private void Bejelentkezes_Form_Load(object sender, EventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: innen is nézhető legyen a main form
        }

        Rent_A_FlatEntities raf = new Rent_A_FlatEntities();
        private void btn_Bejelentkezes_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var felhasznalo in raf.Felhasznaloes)
                {
                    if (felhasznalo.Email == tb_email.Text && felhasznalo.Jelszo == tb_jelszo.Text)
                    {
                        Main_Form main_form = new Main_Form();
                        if (main_form.ShowDialog() == DialogResult.OK)
                        {

                        }
                    }
                }
            } catch (Exception ec)
            {
                Console.WriteLine(ec);
            }

        }


    }
}
