﻿namespace App
{
    partial class Dijkstra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCorrection = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFerme = new System.Windows.Forms.ListBox();
            this.lbOuvert = new System.Windows.Forms.ListBox();
            this.txtBFerme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBOuvert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValideEtape = new System.Windows.Forms.Button();
            this.btnValideExercice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(151, 86);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(100, 121);
            this.listBoxgraphe.TabIndex = 19;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(459, 70);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(315, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 121);
            this.listBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Noeud final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Noeud initial";
            // 
            // btnCorrection
            // 
            this.btnCorrection.Location = new System.Drawing.Point(459, 15);
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.Size = new System.Drawing.Size(75, 23);
            this.btnCorrection.TabIndex = 13;
            this.btnCorrection.Text = "Correction";
            this.btnCorrection.UseVisualStyleBackColor = true;
            this.btnCorrection.Click += new System.EventHandler(this.btnCorrection_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 20;
            this.button1.Text = "Créer nouvelle matrice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Arcs de la matrice d\'adjacence";
            // 
            // lbFerme
            // 
            this.lbFerme.FormattingEnabled = true;
            this.lbFerme.Location = new System.Drawing.Point(151, 245);
            this.lbFerme.Name = "lbFerme";
            this.lbFerme.Size = new System.Drawing.Size(100, 95);
            this.lbFerme.TabIndex = 22;
            // 
            // lbOuvert
            // 
            this.lbOuvert.FormattingEnabled = true;
            this.lbOuvert.Location = new System.Drawing.Point(291, 245);
            this.lbOuvert.Name = "lbOuvert";
            this.lbOuvert.Size = new System.Drawing.Size(100, 95);
            this.lbOuvert.TabIndex = 23;
            // 
            // txtBFerme
            // 
            this.txtBFerme.Location = new System.Drawing.Point(151, 364);
            this.txtBFerme.Name = "txtBFerme";
            this.txtBFerme.Size = new System.Drawing.Size(100, 20);
            this.txtBFerme.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fermés";
            // 
            // txtBOuvert
            // 
            this.txtBOuvert.Location = new System.Drawing.Point(291, 363);
            this.txtBOuvert.Name = "txtBOuvert";
            this.txtBOuvert.Size = new System.Drawing.Size(100, 20);
            this.txtBOuvert.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ouverts";
            // 
            // btnValideEtape
            // 
            this.btnValideEtape.Location = new System.Drawing.Point(416, 360);
            this.btnValideEtape.Name = "btnValideEtape";
            this.btnValideEtape.Size = new System.Drawing.Size(75, 23);
            this.btnValideEtape.TabIndex = 28;
            this.btnValideEtape.Text = "Valider l\'étape";
            this.btnValideEtape.UseVisualStyleBackColor = true;
            this.btnValideEtape.Click += new System.EventHandler(this.btnValideEtape_Click);
            // 
            // btnValideExercice
            // 
            this.btnValideExercice.Location = new System.Drawing.Point(151, 424);
            this.btnValideExercice.Name = "btnValideExercice";
            this.btnValideExercice.Size = new System.Drawing.Size(240, 39);
            this.btnValideExercice.TabIndex = 29;
            this.btnValideExercice.Text = "Valider l\'exercice";
            this.btnValideExercice.UseVisualStyleBackColor = true;
            this.btnValideExercice.Click += new System.EventHandler(this.btnValideExercice_Click);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 475);
            this.Controls.Add(this.btnValideExercice);
            this.Controls.Add(this.btnValideEtape);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBOuvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBFerme);
            this.Controls.Add(this.lbOuvert);
            this.Controls.Add(this.lbFerme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxgraphe);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCorrection);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Dijkstra";
            this.Text = "Dijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCorrection;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFerme;
        private System.Windows.Forms.ListBox lbOuvert;
        private System.Windows.Forms.TextBox txtBFerme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBOuvert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValideEtape;
        private System.Windows.Forms.Button btnValideExercice;
    }
}