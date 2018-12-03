using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iset_2018_Systemes_experts
{
    public class SE_Regle
    {
        public List <I_SE_Fait> Hypot { get; set; }
        public I_SE_Fait These { get; set; }
        public string Descr { get; set; }
        public SE_Regle(string Descr_, List<I_SE_Fait> Hypot_, I_SE_Fait These_)
        {
            Descr = Descr_;
            Hypot = Hypot_;
            These = These_;
        }

        public override string ToString()
        {
            return Descr + " : SI(" + string.Join(" ET ", Hypot) + ") ALORS " + These;
        }
    }

    internal class SE_Regles
    {
        protected List<SE_Regle> _Regles;
        public List<SE_Regle> Regles
        {
            get { return _Regles; }
            set { _Regles = value; }
        }
        public SE_Regles()
        { _Regles = new List<SE_Regle>(); }
        public void RaZ()
        { _Regles.Clear(); }
        public void Ajouter(SE_Regle r)
        { _Regles.Add(r); }
        public void Supprimer(SE_Regle r)
        { _Regles.Remove(r); }
    }

}
