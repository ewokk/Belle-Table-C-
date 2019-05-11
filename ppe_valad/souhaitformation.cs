using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_valad
{
    class souhaitformation
    {
        private int id;
        private int id_formation;
        private int id_Participant;

        public int Id { get; set; }
        public int Id_formation { get; set; }
        public int Id_Participant { get; set; }

        public souhaitformation(int id, int id_formation, int id_Participant)
        {
            Id = id;
            Id_formation = id_formation;
            Id_Participant = Id_Participant;
        }
    }
}
