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
                var a= raf.Felhasznaloes.FirstOrDefault(x => x.Email == tb_email.Text);
               
                //nev= a.Nev;
                

                if (a.Email==tb_email.Text && a.Jelszo==tb_jelszo.Text)
                {
                    //this.Hide();
                    var main_form = new Main_Form();
                    main_form.BejelentkezettFelhasznalo = (a as Felhasznalo);
                    main_form.Closed += (s, args) => this.Close();
                    
                    main_form.Show();
                }
                //Main_Form main_form = new Main_Form();
                
                
            } catch (Exception ec)
            {
                Console.WriteLine(ec);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_email.Text = "asd@asd.com";
            tb_jelszo.Text = "Asd123!.";
        }


    }
}
