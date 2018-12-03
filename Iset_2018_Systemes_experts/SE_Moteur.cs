using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iset_2018_Systemes_experts
{
    public class SE_Moteur
    {
        private SE_Faits _BD_Faits;
        private SE_Regles _BD_Regles;
        private I_SE_IHM _IHM;
        public SE_Moteur(I_SE_IHM IHM_)
        {
            _IHM = IHM_;
            _BD_Faits = new SE_Faits();
            _BD_Regles = new SE_Regles();
        }
        public void AjouterRegle(string sRegle)
        {
            string[] aTmp = sRegle.Split(new string[] { " : " },
                              StringSplitOptions.RemoveEmptyEntries);
            if (aTmp.Length == 2)
            {
                string[] aHypotThese = aTmp[1].Split(new string[]
                                        { "SI", " ALORS " },
                                         StringSplitOptions.RemoveEmptyEntries);
                if (aHypotThese.Length == 2)
                {
                    List<I_SE_Fait> lHypot = new List<I_SE_Fait>();
                    string[] aHypot = aHypotThese[0].Split(new string[] { " ET " },
                                            StringSplitOptions.RemoveEmptyEntries);
                    foreach (string sHypot in aHypot)
                        lHypot.Add(CalculFait.Determiner(sHypot));
                    I_SE_Fait these = CalculFait.Determiner(aHypotThese[1].Trim());
                    _BD_Regles.Ajouter(new SE_Regle(aTmp[0], lHypot, these));
                }
            }
        }
        private int Applicable(SE_Regle r)
        {
            int iNiveauMax = -1;
            foreach (I_SE_Fait f in r.Hypot)
            {
                I_SE_Fait fTrouve = _BD_Faits.Chercher(f.Desc());
                if (fTrouve == null)
                {
                    if (f.Question() != null)
                    {
                        fTrouve = CalculFait.Determiner(f, this);
                        _BD_Faits.Ajouter(fTrouve);
                        iNiveauMax = Math.Max(iNiveauMax, 0);
                    }
                    else return -1;
                }
                if (!fTrouve.Valeur().Equals(f.Valeur())) return -1;
                else iNiveauMax = Math.Max(iNiveauMax, fTrouve.Lvl());
            }
            return iNiveauMax;
        }
        private Tuple<SE_Regle, int> TrouverDispo(SE_Regles rDisp)
        {
            foreach (SE_Regle r in rDisp.Regles)
            {
                int iNiveau = Applicable(r);
                if (iNiveau != -1) return Tuple.Create(r, iNiveau);
            }
            return null;
        }
        internal int QuestionEntier(string sQuestion)
        { return _IHM.QuestionEntier(sQuestion); }
        internal bool QuestionBooleen(string sQuestion)
        { return _IHM.QuestionBool(sQuestion); }
        public int CombienRegles()
        { return _BD_Regles.Regles.Count; }
        public void Resoudre()
        {
            _IHM.AfficherRegles(_BD_Regles.Regles);
            bool ResteRegles = true;
            SE_Regles ReglesDispo = new SE_Regles
            {
                Regles = new List<SE_Regle>(_BD_Regles.Regles)
            };
            _BD_Faits.RaZ();
            while (ResteRegles)
            {
                Tuple<SE_Regle, int> RegleIns = TrouverDispo(ReglesDispo);
                if (RegleIns != null)
                {
                    I_SE_Fait FaitIns = RegleIns.Item1.These;
                    FaitIns.DefinirLvl(RegleIns.Item2 + 1);
                    _BD_Faits.Ajouter(FaitIns);
                    ReglesDispo.Supprimer(RegleIns.Item1);
                }
                else ResteRegles = false;
            }
            _IHM.AfficherFaits(_BD_Faits.Faits);
        }
    }

}
