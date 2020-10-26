namespace PART_6___PSR_PROJECT
{
    partial class frmRPS
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
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radSciccors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblPCChoice = new System.Windows.Forms.Label();
            this.imgPC = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPC)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Controls.Add(this.radSciccors);
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Location = new System.Drawing.Point(12, 66);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(91, 137);
            this.grpPlayerChoice.TabIndex = 0;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Players Choice";
            
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(6, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 2;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radSciccors
            // 
            this.radSciccors.AutoSize = true;
            this.radSciccors.Location = new System.Drawing.Point(6, 114);
            this.radSciccors.Name = "radSciccors";
            this.radSciccors.Size = new System.Drawing.Size(66, 17);
            this.radSciccors.TabIndex = 1;
            this.radSciccors.TabStop = true;
            this.radSciccors.Text = "Sciccors";
            this.radSciccors.UseVisualStyleBackColor = true;
            this.radSciccors.CheckedChanged += new System.EventHandler(this.radSciccors_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(6, 69);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 0;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(126, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Please Make A Selection";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(116, 50);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(47, 13);
            this.lblChoice.TabIndex = 2;
            this.lblChoice.Text = "CHOICE";
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::PART_6___PSR_PROJECT.Properties.Resources.question;
            this.imgPlayer.Location = new System.Drawing.Point(109, 75);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(144, 128);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 3;
            this.imgPlayer.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(109, 209);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(321, 66);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(259, 135);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(21, 13);
            this.lblVS.TabIndex = 5;
            this.lblVS.Text = "VS";
            // 
            // lblPCChoice
            // 
            this.lblPCChoice.AutoSize = true;
            this.lblPCChoice.Location = new System.Drawing.Point(292, 50);
            this.lblPCChoice.Name = "lblPCChoice";
            this.lblPCChoice.Size = new System.Drawing.Size(73, 13);
            this.lblPCChoice.TabIndex = 6;
            this.lblPCChoice.Text = "PC\'S CHOICE";
            // 
            // imgPC
            // 
            this.imgPC.Image = global::PART_6___PSR_PROJECT.Properties.Resources.question;
            this.imgPC.Location = new System.Drawing.Point(286, 75);
            this.imgPC.Name = "imgPC";
            this.imgPC.Size = new System.Drawing.Size(144, 128);
            this.imgPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPC.TabIndex = 7;
            this.imgPC.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(10, 209);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(93, 66);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 279);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.imgPC);
            this.Controls.Add(this.lblPCChoice);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.grpPlayerChoice);
            this.Name = "frmRPS";
            this.Text = "Rock Paper Scissors!!";
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radSciccors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblPCChoice;
        private System.Windows.Forms.PictureBox imgPC;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

