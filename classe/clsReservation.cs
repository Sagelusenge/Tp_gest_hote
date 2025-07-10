using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChambreHotel.classe
{
    internal class clsReservation
    {
        int id;
        int refchambre;
        int refclient;
        DateTime date_entree;
        DateTime date_sortie;

        public int Id { get => id; set => id = value; }
        public int Refchambre { get => refchambre; set => refchambre = value; }
        public int Refclient { get => refclient; set => refclient = value; }
        public DateTime Date_entree { get => date_entree; set => date_entree = value; }
        public DateTime Date_sortie { get => date_sortie; set => date_sortie = value; }
    }
}
