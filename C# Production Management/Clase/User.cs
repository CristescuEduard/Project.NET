using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productie
{
    public partial class User : ICloneable, IComparable
    {
        private string nume;
        private string prenume;
        private string mail;
        private string pass;
        private string confPass;
        private string nrTel;
        private string uName;
        private int id;
        public static int contor = 0;

        public User()
        {
            nume = "N/A";
            prenume = "N/a";
            mail = "example@gmail.com";
            pass = "none";
            confPass = "None";
            nrTel = "+40....";
            uName = "None";
            id = contor++;
        }

        public User(string n, string pN, string eM, string nT, string ps, string cfps, string uN)
        {
            nume = n;
            prenume = pN;
            mail = eM;
            pass = ps;
            confPass = cfps;
            nrTel = nT;
            uName = uN;
            id = contor++;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value != null)
                    prenume = value;
            }
        }

        public string Mail
        {
            get { return mail; }
            set
            {
                if (value != null)
                    mail = value;
            }
        }

        public string NrTel
        {
            get { return nrTel; }
            set
            {
                if (value != null)
                    nrTel = value;
            }
        }

        public string UName
        {
            get { return uName; }
            set
            {
                if (value != null)
                    uName = value;
            }
        }

        public string Pass
        {
            get { return pass; }
            set
            {
                if (value != null)
                    pass = value;
            }
        }

        public string ConfPass
        {
            get { return confPass; }
            set
            {
                if (value != null)
                    confPass = value;
            }
        }

        public User getUser()
        {
            return new User(nume, prenume, mail, pass, confPass, nrTel, uName);
        }
        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Object obj)
        {
            User u = (User)obj;
            return String.Compare(this.uName, u.uName);
        }

        public override string ToString()
        {
            return "First Name: " + nume + "\nLast Name:" + prenume + "\n" + "Email: " + this.mail + "\n" + "Numar telefon: "
                + nrTel + "\n" + "Username: " + uName + "\n";
        }
    }
}
