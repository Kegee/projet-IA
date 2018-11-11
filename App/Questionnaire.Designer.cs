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
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.ckbReponse1 = new System.Windows.Forms.CheckBox();
            this.ckbReponse2 = new System.Windows.Forms.CheckBox();
            this.ckbReponse3 = new System.Windows.Forms.CheckBox();
            this.ckbReponse4 = new System.Windows.Forms.CheckBox();
            this.btnReponse = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(13, 13);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(580, 46);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "";
            // 
            // ckbReponse1
            // 
            this.ckbReponse1.AutoSize = true;
            this.ckbReponse1.Location = new System.Drawing.Point(93, 128);
            this.ckbReponse1.Name = "ckbReponse1";
            this.ckbReponse1.Size = new System.Drawing.Size(80, 17);
            this.ckbReponse1.TabIndex = 1;
            this.ckbReponse1.Text = "checkBox1";
            this.ckbReponse1.UseVisualStyleBackColor = true;
            // 
            // ckbReponse2
            // 
            this.ckbReponse2.AutoSize = true;
            this.ckbReponse2.Location = new System.Drawing.Point(93, 174);
            this.ckbReponse2.Name = "ckbReponse2";
            this.ckbReponse2.Size = new System.Drawing.Size(80, 17);
            this.ckbReponse2.TabIndex = 2;
            this.ckbReponse2.Text = "checkBox2";
            this.ckbReponse2.UseVisualStyleBackColor = true;
            // 
            // ckbReponse3
            // 
            this.ckbReponse3.AutoSize = true;
            this.ckbReponse3.Location = new System.Drawing.Point(93, 219);
            this.ckbReponse3.Name = "ckbReponse3";
            this.ckbReponse3.Size = new System.Drawing.Size(80, 17);
            this.ckbReponse3.TabIndex = 3;
            this.ckbReponse3.Text = "checkBox3";
            this.ckbReponse3.UseVisualStyleBackColor = true;
            // 
            // ckbReponse4
            // 
            this.ckbReponse4.AutoSize = true;
            this.ckbReponse4.Location = new System.Drawing.Point(93, 263);
            this.ckbReponse4.Name = "ckbReponse4";
            this.ckbReponse4.Size = new System.Drawing.Size(80, 17);
            this.ckbReponse4.TabIndex = 4;
            this.ckbReponse4.Text = "checkBox4";
            this.ckbReponse4.UseVisualStyleBackColor = true;
            // 
            // btnReponse
            // 
            this.btnReponse.Location = new System.Drawing.Point(13, 331);
            this.btnReponse.Name = "btnReponse";
            this.btnReponse.Size = new System.Drawing.Size(257, 43);
            this.btnReponse.TabIndex = 5;
            this.btnReponse.Text = "Réponse ?";
            this.btnReponse.UseVisualStyleBackColor = true;
            this.btnReponse.Click += new System.EventHandler(this.btnReponse_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(357, 331);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(235, 43);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = "Question suivante";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(323, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 219);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnReponse);
            this.Controls.Add(this.ckbReponse4);
            this.Controls.Add(this.ckbReponse3);
            this.Controls.Add(this.ckbReponse2);
            this.Controls.Add(this.ckbReponse1);
            this.Controls.Add(this.txtQuestion);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.CheckBox ckbReponse1;
        private System.Windows.Forms.CheckBox ckbReponse2;
        private System.Windows.Forms.CheckBox ckbReponse3;
        private System.Windows.Forms.CheckBox ckbReponse4;
        private System.Windows.Forms.Button btnReponse;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}