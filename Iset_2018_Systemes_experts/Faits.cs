using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iset_2018_Systemes_experts
{
    public interface I_SE_Fait
    {
        string Desc();
        object Valeur();
        int Lvl();
        string Question();
        void DefinirLvl(int n);
    }
    internal class SE_Faits_Bool : I_SE_Fait
    {
        public void DefinirLvl(int n)
        {
            _Lvl = n;
        }

        protected string _Desc;
        public string Desc()
        {
            return _Desc;
        }
        protected int _Lvl;
        public int Lvl()
        {
            return _Lvl;
        }
        protected string _Question;
        public string Question()
        {
            return _Question;
        }
        protected bool _Valeur;
        public object Valeur()
        {
            return _Valeur;
        }
        public SE_Faits_Bool(string Descr_, bool Valeur_, string Question_ = null, int Lvl_ = 0)
        {
            _Desc = Descr_;
            _Valeur = Valeur_;
            _Question = Question_;
            _Lvl = Lvl_;
        }

        public override string ToString()
        {
            string res = "";
            if (!_Valeur) res = "NON ";
            res += _Desc + " (" + _Lvl + ")";
            return res;
        }
    }
    internal class SE_Faits_Int : I_SE_Fait
    {
        public void DefinirLvl(int n)
        {
            _Lvl = n;
        }

        protected string _Desc;
        public string Desc()
        {
            return _Desc;
        }
        protected int _Lvl;
        public int Lvl()
        {
            return _Lvl;
        }
        protected string _Question;
        public string Question()
        {
            return _Question;
        }
        protected int _Valeur;
        public object Valeur()
        {
            return _Valeur;
        }
        public SE_Faits_Int(string Descr_, int Valeur_, string Question_ = null, int Lvl_ = 0)
        {
            _Desc = Descr_;
            _Valeur = Valeur_;
            _Question = Question_;
            _Lvl = Lvl_;
        }

        public override string ToString()
        {
            return _Desc + " = " + _Valeur + "(" + _Lvl + ")";
        }
    }
    internal class SE_Faits
    {
        protected List<I_SE_Fait> _Faits;
        public List<I_SE_Fait> Faits { get { return _Faits; } }
        public SE_Faits() { _Faits = new List<I_SE_Fait>(); }
        public void RaZ() { _Faits.Clear(); }
        public void Ajouter(I_SE_Fait f) { _Faits.Add(f); }
        public I_SE_Fait Chercher(string Descr_)
        { return _Faits.FirstOrDefault(x => x.Desc().Equals(Descr_)); }
        public object Valeur(string Descr_)
        {
            I_SE_Fait f = _Faits.FirstOrDefault(x => x.Desc().Equals(Descr_));
            if (f != null) return f.Valeur();
            else return null;
        }
    }
    internal static class CalculFait
    {
        internal static I_SE_Fait Determiner(string sFait)
        {
            sFait = sFait.Trim();
            string sQuestion = null;
            if(sFait.Contains("=")) //Entier
            {
                string[] sTmp = sFait.Split(new string[] { "=", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
                if (sTmp.Length >= 2)
                {
                    if (sTmp.Length == 3)
                        sQuestion = sTmp[2].Trim();
                    return new SE_Faits_Int(sTmp[0].Trim(), int.Parse(sTmp[1].Trim()), sQuestion);
                }
                else
                    return null;
            }
            else //Booleen
            {
                bool bTmp = true;
                if(sFait.StartsWith("!"))
                {
                    bTmp = false;
                    sFait = sFait.Substring(1);
                }
                string[] sTmp = sFait.Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
                if (sTmp.Length == 2)
                    sQuestion = sTmp[1].Trim();
                return new SE_Faits_Bool(sTmp[0].Trim(), bTmp, sQuestion);
            }
        }
        internal static I_SE_Fait Determiner(I_SE_Fait fFait, SE_Moteur mMoteur)
        {
            if (fFait.GetType().Equals(typeof(SE_Faits_Int)))
                return new SE_Faits_Int(fFait.Desc(), mMoteur.QuestionEntier(fFait.Question()));
            else
                return new SE_Faits_Bool(fFait.Desc(), mMoteur.QuestionBooleen(fFait.Question()));
        }
    }
}
