using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrainement_partiel_avril_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] TabNo = new int[100];
        public int nbEtudiant;
        public string[] TabNom = new string[100];
        public string[] TabPrenoms = new string[100];
        public string[] TabClasse = new string[100];
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            nbEtudiant = 0;
        }
        
        private void ButtonEnreg_Click(object sender, EventArgs e)
        {
            TabNo[nbEtudiant] = Int32.Parse(TextBoxNumEtu.Text);
            TabNom[nbEtudiant] = TextBoxNom.Text;
            TabPrenoms[nbEtudiant] = TextBoxPrenom.Text;
            if (RadioSIO1_1.Checked)
            {
                TabClasse[nbEtudiant] = "Sio1";
            }
            else
            {
                TabClasse[nbEtudiant] = "Sio2";
            }
            nbEtudiant += 1;

        }

        private void ButtonAfficher_Click(object sender, EventArgs e)
        {
            ListBoxClasse.Items.Clear();
            for (int i = 0; i < nbEtudiant; i++)
            {
                if (TabClasse[i] == "Sio1" && RadioSIO1_2.Checked)
                {
                    ListBoxClasse.Items.Add(TabNom[i] + " " + TabPrenoms[i] + " " + TabNo[i]);
                }
                if (TabClasse[i] == "Sio2" && RadioSIO2_2.Checked)
                {
                    ListBoxClasse.Items.Add(TabNom[i] +  " " + TabPrenoms[i] + " " + TabNo[i]);
                }
            }
        }
    }
} 