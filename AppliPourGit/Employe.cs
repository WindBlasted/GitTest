using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliPourGit
{
    class Employe
    {
        private string nom;
        private string prenom;
        private int id;
        private string libelle;

        public void contructEmploye(string pnom, string pprenom, int pid, string plibelle)
        {
            this.prenom = pprenom;
            this.nom = pnom;
            this.id = pid;
            this.libelle = plibelle;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public int getId()
        {
            return this.id;
        }

        public string getLibelle()
        {
            return this.libelle;
        }
    }
}
