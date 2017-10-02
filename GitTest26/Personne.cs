using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest26
{
    class Personne
    {
        private string _Nom;
        private string _Prenom;
        private int _Age;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }


        public Personne()
        {
            this.Nom = "toto";
            this.Prenom = "tutu";
            this.Age = 50;
        }



        public Personne(string nom,string prenom, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
