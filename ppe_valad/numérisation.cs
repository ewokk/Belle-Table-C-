using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe_valad
{
    public partial class numérisation : Form
    {
       public  string dossier = "C:\\Users\\theow\\source\\repos\\ppe_valad\\pdf\\";
      
        public numérisation()
        {
            InitializeComponent();
            DirectoryInfo dir = new DirectoryInfo(dossier);
            FileInfo[] fichiers = dir.GetFiles();
            foreach (FileInfo fichier in fichiers)
            {
                listBox1.Items.Add(fichier.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Configure open file dialog box
            OpenFileDialog copi = new OpenFileDialog();
            //Titre qui se trouveras en dans la barre de titre de la fenêtre de dialogue 
            copi.Title = "Fenetre de recherche de fichier";
            //L'extension par defaut des type de fichier recherchés
            copi.DefaultExt = ".pdf";
            // Filtre d'extension 
            copi.Filter = "Fichier émargement (*.pdf)|*.pdf";
            // Ça ouvre la fenêtre de dialogue en renvoyant un booleen
            copi.ShowDialog();
            // Ouverture du fichier
            string filename = copi.FileName;
                //Affichage du fichier
            string rep = filename;

            if (rep != "" )
            {
                File.Copy(rep, dossier + Path.GetFileName(rep),true);// ture pour enregistrer si il exite deja par dessus
                MessageBox.Show("Fichier enregistrer ");
                listBox1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(dossier);
                FileInfo[] fichiers = dir.GetFiles();
                foreach (FileInfo fichier in fichiers)
                {
                    listBox1.Items.Add(fichier.Name);
                }
            }
        }
    }
}
