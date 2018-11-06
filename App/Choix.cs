using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Choix : Form
    {
        public Choix()
        {
            InitializeComponent();
        }

        private void btnQuestionnaire_Click(object sender, EventArgs e)
        {
            Questionnaire suiteQuestion = new Questionnaire();
            suiteQuestion.Show();
        }
    }
}
