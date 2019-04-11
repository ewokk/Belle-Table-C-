using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe_valad
{
    class candidater
    {
        private int id;
        private int accepter;
        private int Id_Participant;
        private int Id_Session;

        public int Id { get; set; }
        public int Accepter { get; set; }
        public int id_Participant{ get; set; }
        public int id_Session { get; set; }

        public candidater(int id, int accepter,int Id_Participant,int Id_Session )
        {
            Id = id;
            Accepter = accepter;
            id_Participant = Id_Participant;
            id_Session = Id_Session;
        }
    }
}
