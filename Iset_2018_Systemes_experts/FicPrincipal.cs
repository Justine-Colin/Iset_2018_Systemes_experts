using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Iset_2018_Systemes_experts
{
    public partial class Ecran_Principal : Form, I_SE_IHM
    {
        private SE_Moteur mMoteur;
        public Ecran_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Charger_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Fichiers texte|*.txt|Tous fichiers|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string sLigne;
                while((sLigne = sr.ReadLine()) != null)
                    mMoteur.AjouterRegle(sLigne);
                sr.Close();
            }
        }

        private void Btn_Resoudre_Click(object sender, EventArgs e)
        {
            if(mMoteur.CombienRegles() == 0)
            {
                MessageBox.Show("Veuillez charger une base de règles");
                Btn_Charger_Click(null, null);
            }
            mMoteur.Resoudre();
        }        

        private void Ecran_Principal_Load(object sender, EventArgs e)
        {
            mMoteur = new SE_Moteur(this);
        }

        public int QuestionEntier(string sQuestion)
        {
            FicQuestion f = new FicQuestion(sQuestion);
            if (f.ShowDialog() == DialogResult.OK)
                try
                    { return int.Parse(f.Reponse); }
                catch
                    { return 0; }
            else
                return 0;
        }

        public bool QuestionBool(string sQuestion)
        {
            FicQuestion f = new FicQuestion(sQuestion);
            if (f.ShowDialog() == DialogResult.OK)
                return f.Reponse.ToUpper().Equals("O");
            else
                return false;
        }

        public void AfficherFaits(List<I_SE_Fait> lFaits)
        {
            string sTmp = "Solution trouvée : " + Environment.NewLine;
            sTmp += string.Join(Environment.NewLine, lFaits.Where(x => x.Lvl() >0).OrderByDescending(x => x.Lvl()));
            Tb_Fait.Text = sTmp;
        }

        public void AfficherRegles(List<SE_Regle> lRegles)
        {
            Tb_Regle.Text = string.Join(Environment.NewLine, lRegles);
        }
    }
}
