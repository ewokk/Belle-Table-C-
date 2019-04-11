using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace ppe_valad
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            acceuil_login MonFormLogin = new acceuil_login();
            MonFormLogin.ShowDialog();

            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
                MonFormLogin.Close();
                int type = acceuil_login.type;

                switch (type)
                {
                    case 1:
                        Application.Run(new panneau_admin());
                        break;
                    case 2:
                        Application.Run(new panneau_gestionnaire());
                        break;
                    default:
                        Application.Run(new panneau_user());
                        break;
                }
              
            }
            else
                MonFormLogin.Close();
            MessageBox.Show("Au revoir");
        }

    }
}
