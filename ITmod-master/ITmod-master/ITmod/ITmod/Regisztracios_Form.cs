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

        Felhasznalo felhasznalo;
        internal Felhasznalo Felhasznalo
        {
            get { return felhasznalo; }
            set { felhasznalo = value; }
        }

        public Regisztracios_Form()
        {
            InitializeComponent();
            tb_jelszo.PasswordChar = '*';
            tb_jelszo_ujra.PasswordChar = '*';
        }

        private void btn_Regisztrálás_Click(object sender, EventArgs e)
        {
            if (tb_jelszo.Text == tb_jelszo_ujra.Text && tb_email.Text.Contains("@") && 
                tb_email.Text.Contains(".") && tb_jelszo.Text.Length > 4 && tb_jelszo_ujra.Text.Length > 4 &&
                tb_cim.Text!="" && tb_email.Text!="" && tb_telefon_3.Text!="" && cb_telefon.Text!="" && tb_nev.Text!="" &&
                tb_felhasznalo_nev.Text!="")
            {
                felhasznalo = new Felhasznalo(tb_nev.Text, tb_felhasznalo_nev.Text, tb_email.Text, tb_cim.Text,
                    tb_telefon_1.Text + cb_telefon.Text + tb_telefon_3.Text, tb_jelszo.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                tb_jelszo.Clear();
                tb_jelszo_ujra.Clear();
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;

                string hiba = "";
                if (tb_jelszo.Text != tb_jelszo_ujra.Text)
                {
                    label2.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    hiba += "A két jelszó nem egyezik meg.\n";
                    //tb_jelszo.Clear();
                    //tb_jelszo_ujra.Clear();


                }


                if (tb_jelszo.Text.Length < 5 || tb_jelszo_ujra.Text.Length < 5)
                {
                    label2.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    hiba += "A jelszó nem elég hosszú.\n";
                    //tb_jelszo.Clear();
                    //tb_jelszo_ujra.Clear();
                }

                if (tb_cim.Text == "")
                {
                    label5.ForeColor = Color.Red;
                    hiba += "Hiányzó adat: Cím\n";
                    tb_cim.Clear();
                }

                if (tb_felhasznalo_nev.Text == "")
                {
                    label4.ForeColor = Color.Red;
                    hiba += "Hiányzó adat: Felhasználó név\n";
                    tb_felhasznalo_nev.Clear();
                }

                if (tb_nev.Text == "")
                {
                    label7.ForeColor = Color.Red;
                    hiba += "Hiányzó adat: Név\n";
                    tb_nev.Clear();
                }

                if (tb_telefon_1.Text == "" || cb_telefon.Text == "" || tb_telefon_3.Text == "")
                {
                    label6.ForeColor = Color.Red;
                    hiba += "Hiányzó adat: Telefonszám\n";
                    tb_telefon_3.Clear();
                }

                /*label1.ForeColor = Color.Red;
                MessageBox.Show("Az e-mail cím érvénytelen");
                tb_email.Clear();*/
                if (hiba.Equals("")) { }
                else
                {
                    MessageBox.Show(hiba, "Hibaüzenet");
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
            ToolTip2.SetToolTip(tb_email, "Az e-mail címnek tartalmaznia kell a következő karaktereket: '@ .");

            ToolTip ToolTip3 = new ToolTip();
            ToolTip3.ShowAlways = true;
            ToolTip3.SetToolTip(tb_jelszo, "A jelszónak minimum 6 karakter hosszú kell lenni.");

            ToolTip ToolTip4 = new ToolTip();
            ToolTip4.ShowAlways = true;
            ToolTip4.SetToolTip(tb_cim, "Irányítószám, Település, Utca Házszám");
        }

        private void tb_telefon_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
