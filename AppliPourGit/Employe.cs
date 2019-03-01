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

        public void contructEmploye(string pnom, string pprenom)
        {
            this.prenom = pprenom;
            this.nom = pnom;
        }
    }
}
