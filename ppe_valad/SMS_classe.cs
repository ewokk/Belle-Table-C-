using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ppe_valad
{
    class SMS_classe
    {
        public static void Send(String msg)
        {
            String numero = "0659417314";

            string sURL;
            sURL = "https://SMStoB.com/http.php?email=accueil@agecif.com&pass=ZJ3R2Z&numero=$$num$$&message=$$msg$$";
            sURL = sURL.Replace("$$num$$", numero);
            sURL = sURL.Replace("$$msg$$", msg);
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            WebResponse response = wrGETURL.GetResponse();
        }
    }
}
