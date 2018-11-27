namespace App
{
    partial class Questionnaire
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
            this.ckbReponse1 = new System.Windows.Forms.CheckBox();
            this.ckbReponse2 = new System.Windows.Forms.CheckBox();
            this.ckbReponse3 = new System.Windows.Forms.CheckBox();
            this.ckbReponse4 = new System.Windows.Forms.CheckBox();
            this.btnReponse = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.numQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbReponse1
            // 
            this.ckbReponse1.AutoSize = true;
            this.ckbReponse1.BackColor = System.Drawing.SystemColors.Control;
            this.ckbReponse1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbReponse1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckbReponse1.Location = new System.Drawing.Point(34, 157);
            this.ckbReponse1.Name = "ckbReponse1";
            this.ckbReponse1.Size = new System.Drawing.Size(110, 23);
            this.ckbReponse1.TabIndex = 1;
            this.ckbReponse1.Text = "checkBox1";
            this.ckbReponse1.UseMnemonic = false;
            this.ckbReponse1.UseVisualStyleBackColor = false;
            this.ckbReponse1.CheckedChanged += new System.EventHandler(this.ckbReponse1_CheckedChanged);
            // 
            // ckbReponse2
            // 
            this.ckbReponse2.AutoSize = true;
            this.ckbReponse2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.ckbReponse2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckbReponse2.Location = new System.Drawing.Point(34, 247);
            this.ckbReponse2.Name = "ckbReponse2";
            this.ckbReponse2.Size = new System.Drawing.Size(110, 23);
            this.ckbReponse2.TabIndex = 2;
            this.ckbReponse2.Text = "checkBox2";
            this.ckbReponse2.UseVisualStyleBackColor = true;
            // 
            // ckbReponse3
            // 
            this.ckbReponse3.AutoSize = true;
            this.ckbReponse3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.ckbReponse3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckbReponse3.Location = new System.Drawing.Point(34, 341);
            this.ckbReponse3.Name = "ckbReponse3";
            this.ckbReponse3.Size = new System.Drawing.Size(110, 23);
            this.ckbReponse3.TabIndex = 3;
            this.ckbReponse3.Text = "checkBox3";
            this.ckbReponse3.UseVisualStyleBackColor = true;
            this.ckbReponse3.CheckedChanged += new System.EventHandler(this.ckbReponse3_CheckedChanged);
            // 
            // ckbReponse4
            // 
            this.ckbReponse4.AutoSize = true;
            this.ckbReponse4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ckbReponse4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F);
            this.ckbReponse4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckbReponse4.Location = new System.Drawing.Point(33, 439);
            this.ckbReponse4.Name = "ckbReponse4";
            this.ckbReponse4.Size = new System.Drawing.Size(110, 23);
            this.ckbReponse4.TabIndex = 4;
            this.ckbReponse4.Text = "checkBox4";
            this.ckbReponse4.UseVisualStyleBackColor = true;
            // 
            // btnReponse
            // 
            this.btnReponse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReponse.Location = new System.Drawing.Point(55, 519);
            this.btnReponse.Name = "btnReponse";
            this.btnReponse.Size = new System.Drawing.Size(257, 43);
            this.btnReponse.TabIndex = 5;
            this.btnReponse.Text = "Réponse ?";
            this.btnReponse.UseVisualStyleBackColor = true;
            this.btnReponse.Click += new System.EventHandler(this.btnReponse_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(623, 519);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(235, 43);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = "Question suivante";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(540, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuestion.Location = new System.Drawing.Point(12, 32);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(128, 24);
            this.txtQuestion.TabIndex = 8;
            this.txtQuestion.Text = "Question : ?";
            this.txtQuestion.Click += new System.EventHandler(this.txtQuestiona_Click);
            // 
            // numQ
            // 
            this.numQ.AutoSize = true;
            this.numQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numQ.Location = new System.Drawing.Point(1090, 9);
            this.numQ.Name = "numQ";
            this.numQ.Size = new System.Drawing.Size(88, 18);
            this.numQ.TabIndex = 9;
            this.numQ.Text = "Question : ?";
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1190, 622);
            this.Controls.Add(this.numQ);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnReponse);
            this.Controls.Add(this.ckbReponse4);
            this.Controls.Add(this.ckbReponse3);
            this.Controls.Add(this.ckbReponse2);
            this.Controls.Add(this.ckbReponse1);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbReponse1;
        private System.Windows.Forms.CheckBox ckbReponse2;
        private System.Windows.Forms.CheckBox ckbReponse3;
        private System.Windows.Forms.CheckBox ckbReponse4;
        private System.Windows.Forms.Button btnReponse;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Label numQ;
    }
}