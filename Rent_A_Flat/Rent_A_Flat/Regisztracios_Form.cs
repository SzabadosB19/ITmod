using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Rent_A_Flat
{
   
    public partial class Regisztracios_Form : Form
    {

        

        
        
        Felhasznalo felhasznalo;

        public Felhasznalo Felhasznalo
        {
            get { return felhasznalo; }
            set { felhasznalo = value; }
        }

        public Regisztracios_Form()
        {
            InitializeComponent();
        }

        private void btn_Regisztrálás_Click(object sender, EventArgs e)
        {
            String hibauzenet = "";
            Match email_regex = Regex.Match(tb_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match jelszo_regex = Regex.Match(tb_jelszo.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
            Match nev_regex = Regex.Match(tb_nev.Text, @"/([\p{L}'-]+) ([\p{L}'-]+)/$");
            
            if (!email_regex.Success)
            {
                hibauzenet += "Hibás e-mail cím.\n";
                label4.ForeColor = Color.Red;
                
            } 
            if (!jelszo_regex.Success)
            {
                hibauzenet += "Nem megfelelő a jelszó.\n";
                label2.ForeColor = Color.Red;
            }

            if (tb_jelszo.Text!=tb_jelszo_ujra.Text)
            {
                hibauzenet += "A két jelszó nem egyezik meg.\n";
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }

            if (!nev_regex.Success)
            {
                hibauzenet += "Nem megfelelő felhasználónév.";
                label1.ForeColor = Color.Red;
            }
            
            {
                if (email_regex.Success && jelszo_regex.Success && tb_jelszo.Text==tb_jelszo_ujra.Text && tb_cim.Text!="" &&
                    tb_nev.Text!="")
                {
                    using (Rent_A_FlatEntities context = new Rent_A_FlatEntities())
                    {

                        {
                            Felhasznalo felhasznalo = new Felhasznalo(tb_nev.Text, tb_email.Text, tb_cim.Text,
                                tb_jelszo.Text, tb_telefon_1.Text + cb_telefon.Text + tb_telefon_3.Text);
                            context.Felhasznaloes.Add(felhasznalo);

                            try
                            {
                                context.SaveChanges();
                            }
                            catch (Exception ec)
                            {
                                Console.WriteLine(ec.Message);
                            }

                            DialogResult = DialogResult.OK;

                        };
                    }  
                } else
                {
                    MessageBox.Show(hibauzenet);
                    
                }



            }
        }

        private void Regisztracios_Form_Load(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.ShowAlways = true;
            ToolTip1.SetToolTip(btn_Regisztrálás, "Kattints a regisztrációhoz");

            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.ShowAlways = true;
            ToolTip2.SetToolTip(tb_email, "Az e-mail címnek tartalmaznia kell a következő karaktereket: '@ .'");

            ToolTip ToolTip3 = new ToolTip();
            ToolTip3.ShowAlways = true;
            ToolTip3.SetToolTip(tb_jelszo, "A jelszónak minimum 6 karakter hosszú kell lenni.");

            ToolTip ToolTip4 = new ToolTip();
            ToolTip4.ShowAlways = true;
            ToolTip4.SetToolTip(tb_cim, "Irányítószám, Település, Utca Házszám");

            ToolTip ToolTip5 = new ToolTip();
            ToolTip5.ShowAlways = true;
            ToolTip5.SetToolTip(tb_telefon_3, "7 számjegyet kell beírni.");
        }

        private void btn_createdefault_Click(object sender, EventArgs e)
        {
            tb_nev.Text = "Asd Asd";
            tb_email.Text = "asd@asd.com";
            tb_jelszo.Text = "Asd123!.";
            tb_jelszo_ujra.Text = "Asd123!.";
            tb_cim.Text = "1111, Budapest, Ács utca 1";
            cb_telefon.Text = "30";
            tb_telefon_3.Text = "1234567";
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            tb_nev.Text = "";
            tb_email.Text = "";
            tb_jelszo.Text = "";
            tb_jelszo_ujra.Text = "";
            tb_cim.Text = "";
            cb_telefon.Text = "";
            tb_telefon_3.Text = "";
        }
    }
}
