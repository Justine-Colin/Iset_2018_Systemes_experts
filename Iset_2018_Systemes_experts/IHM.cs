using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iset_2018_Systemes_experts
{
    public interface I_SE_IHM
    {
        int QuestionEntier(string sQuestion);
        bool QuestionBool(string sQuestion);
        void AfficherFaits(List<I_SE_Fait> lFaits);
        void AfficherRegles(List<SE_Regle> lRegles);
    }
}
