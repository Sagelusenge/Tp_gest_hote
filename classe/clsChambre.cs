using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChambreHotel.classe
{
    internal class clsChambre
    {
      
        int id;
        int numero_chambre;
        int refclasse;

        public int Id { get => id; set => id = value; }
        public int Numero_chambre { get => numero_chambre; set => numero_chambre = value; }
        public int Refclasse { get => refclasse; set => refclasse = value; }
    }
}
