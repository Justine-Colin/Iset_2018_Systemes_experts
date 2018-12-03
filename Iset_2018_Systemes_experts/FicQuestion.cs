using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iset_2018_Systemes_experts
{
    public partial class FicQuestion : Form
    {
        public FicQuestion(string sQuestion)
        {
            InitializeComponent();
            LblQuestion.Text = sQuestion;
        }

        public string Reponse
        { get { return Tb_Reponse.Text; } }
    }
}
