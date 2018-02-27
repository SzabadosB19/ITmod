using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITmod
{
    class Felhasznalo
    {
        String nev, felhasznalo_nev, email, cim, jelszo, telefonszam;

        public String Telefonszam
        {
            get { return telefonszam; }
            set { telefonszam = value; }
        }

        public String Jelszo
        {
            get { return jelszo; }
            set { jelszo = value; }
        }

        public String Cim
        {
            get { return cim; }
            set { cim = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Felhasznalo_nev
        {
            get { return felhasznalo_nev; }
            set { felhasznalo_nev = value; }
        }

        public String Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        

        public Felhasznalo (string nev, string felhasznalo_nev, string email, string cim, string telefonszam, string jelszo)
        {
            this.nev = nev;
            this.felhasznalo_nev = felhasznalo_nev;
            this.email = email;
            this.cim = cim;
            this.telefonszam = telefonszam;
            this.jelszo = jelszo;
        }
    }
}
