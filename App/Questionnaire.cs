﻿using System;
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
    public partial class Questionnaire : Form
    {
        static List<int> idQ = new List < int > {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};

        static int noteTot = 0;
        static int note = 0;
        static string bonneRep;
        public Questionnaire()
        {
            InitializeComponent();
            choixQuestion();
        }
        private bool bonneReponse()
        {
            if ((bonneRep == "A") && (ckbReponse1.Checked) && (!ckbReponse2.Checked) && (!ckbReponse3.Checked) && (!ckbReponse4.Checked)) return true;
            if ((bonneRep == "B") && (!ckbReponse1.Checked) && (ckbReponse2.Checked) && (!ckbReponse3.Checked) && (!ckbReponse4.Checked)) return true;
            if ((bonneRep == "C") && (!ckbReponse1.Checked) && (!ckbReponse2.Checked) && (ckbReponse3.Checked) && (!ckbReponse4.Checked)) return true;
            if ((bonneRep == "D") && (!ckbReponse1.Checked) && (!ckbReponse2.Checked) && (!ckbReponse3.Checked) && (ckbReponse4.Checked)) return true;
            return false;
        }
        private void choixQuestion()
        {
            Random aleatoire = new Random();
            int entier = aleatoire.Next(idQ.Count);
            Question prochaineQuestion = new Question(idQ[entier]);
            
            txtQuestion.Text= prochaineQuestion.QuestionText;
            numQ.Text = "Question numéro " +(21-idQ.Count) + " sur 20";
            ckbReponse1.Text = prochaineQuestion.Answers[0];
            ckbReponse2.Text = prochaineQuestion.Answers[1];
            ckbReponse3.Text = prochaineQuestion.Answers[2];
            ckbReponse4.Text = prochaineQuestion.Answers[3];

            if (prochaineQuestion.Answers[2] == "")
            {
                ckbReponse3.Visible = false;
            }
            if (prochaineQuestion.Answers[2] != "")
            {
                ckbReponse3.Visible = true;
            }

            if (prochaineQuestion.Answers[3] == "")
            {
                ckbReponse4.Visible = false;
            }
            if (prochaineQuestion.Answers[3] != "")
            {
                ckbReponse4.Visible = true;
            }
            
            if (prochaineQuestion.Image1 !="")
            {
                Image image = Image.FromFile(prochaineQuestion.Image1);
                pictureBox1.Image = image;
            }
            else
            {
                pictureBox1.Image = null;
            }
            idQ.Remove(idQ[entier]);
            bonneRep = prochaineQuestion.GoodAnswer;
        }
        private void unchecking()
        {
            ckbReponse1.Checked = false;
            ckbReponse2.Checked = false;
            ckbReponse3.Checked = false;
            ckbReponse4.Checked = false;

            ckbReponse1.ForeColor = Color.Black;
            ckbReponse2.ForeColor = Color.Black;
            ckbReponse3.ForeColor = Color.Black;
            ckbReponse4.ForeColor = Color.Black;
        }
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            noteTot++;
            if (noteTot==19) btnSuivant.Text = "Fin du test";
            if (bonneReponse()) note++;
            if (noteTot == 20)
            {
                
                this.Close();
                Resultats res = new Resultats(note);
                note = 0;
                noteTot = 0;
                idQ = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
                res.Show();
            }
            else
            {
                choixQuestion();
                unchecking();
            }
        }

        private void btnReponse_Click(object sender, EventArgs e)
        {
            if (bonneRep == "A")
            {
                ckbReponse1.ForeColor = Color.Green;
                ckbReponse2.ForeColor = Color.Red;
                ckbReponse3.ForeColor = Color.Red;
                ckbReponse4.ForeColor = Color.Red;
            }
            if (bonneRep == "B")
            {
                ckbReponse1.ForeColor = Color.Red;
                ckbReponse2.ForeColor = Color.Green;
                ckbReponse3.ForeColor = Color.Red;
                ckbReponse4.ForeColor = Color.Red;
            }
            if (bonneRep == "C")
            {
                ckbReponse1.ForeColor = Color.Red;
                ckbReponse2.ForeColor = Color.Red;
                ckbReponse3.ForeColor = Color.Green;
                ckbReponse4.ForeColor = Color.Red;
            }
            if (bonneRep == "D")
            {
                ckbReponse1.ForeColor = Color.Red;
                ckbReponse2.ForeColor = Color.Red;
                ckbReponse3.ForeColor = Color.Red;
                ckbReponse4.ForeColor = Color.Green;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuestiona_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ckbReponse1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbReponse1.Checked==true)
            {
                ckbReponse2.Checked = false;
                ckbReponse3.Checked = false;
                ckbReponse4.Checked = false;
            }
        }

        private void ckbReponse3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbReponse3.Checked == true)
            {
                ckbReponse1.Checked = false;
                ckbReponse2.Checked = false;
                ckbReponse4.Checked = false;
            }
        }



        private void label2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbReponse2_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbReponse2.Checked == true)
            {
                ckbReponse1.Checked = false;
                ckbReponse3.Checked = false;
                ckbReponse4.Checked = false;
            }
        }

        private void ckbReponse4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbReponse4.Checked == true)
            {
                ckbReponse1.Checked = false;
                ckbReponse2.Checked = false;
                ckbReponse3.Checked = false;
            }
        }
    }
}
