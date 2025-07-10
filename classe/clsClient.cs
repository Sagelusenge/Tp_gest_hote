using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChambreHotel.classe
{
    internal class clsClient
    {
        int id;
        string noms;
        int contact;
        int refcat;
        string adresse;

        public int Id { get => id; set => id = value; }
        public string Noms { get => noms; set => noms = value; }
        public int Contact { get => contact; set => contact = value; }
        public int Refcat { get => refcat; set => refcat = value; }
        public string Adresse { get => adresse; set => adresse = value; }
    }
}
