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
    public partial class Feltoltes_Form : Form
    {
        public Feltoltes_Form()
        {
            InitializeComponent();
        }

       

        private void rb_haz_CheckedChanged_1(object sender, EventArgs e)
        {
            label_emelet.Visible = !label_emelet.Visible;
            label_epuletszint.Visible = !label_epuletszint.Visible;
            tb_emelet.Visible = !tb_emelet.Visible;
            tb_epuletszint.Visible = !tb_epuletszint.Visible;

            label_kert.Visible = !label_kert.Visible;
            label_emeletszama.Visible = !label_emeletszama.Visible;
            tb_kert.Visible = !tb_kert.Visible;
            tb_emeletekszama.Visible = !tb_emeletekszama.Visible;
        }

        private void btn_mentes_Click(object sender, EventArgs e)
        {
            if (tb_cim.Text!="")
            {
                using (Rent_A_FlatEntities context = new Rent_A_FlatEntities())
                {
                    Ingatlan ingatlan = new Ingatlan(tb_cim.Text, Convert.ToInt32(tb_terulet.Text), Convert.ToInt32(tb_szobak.Text),
                        Convert.ToInt32(tb_felszoba.Text), tb_komfort.Text, tb_futes.Text, Convert.ToInt32(tb_furdo.Text),
                        dtp_epiteseve.Value, tb_parkolas.Text, rtb_leiras.Text);
                    
                    context.Ingatlans.Add(ingatlan);

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ec)
                    {
                        Console.WriteLine(ec.Message);
                    }

                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
