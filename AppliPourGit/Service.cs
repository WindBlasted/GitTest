using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliPourGit
{
    class Service
    {
        private int id;
        private string libelle;

        public void newServ(int pid, string plibelle)
        {
            this.id = pid;
            this.libelle = plibelle;
        }

        public int getId()
        {
            return this.id;
        }

        public void setLibelle(string unLibelle)
        {
            libelle = unLibelle;
        }
        
    }
}
