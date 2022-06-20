
namespace VisualBlackJack
{
    partial class BlackJack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            this.DrawCard = new System.Windows.Forms.Button();
            this.DealerDraw = new System.Windows.Forms.Button();
            this.PlayerCard3 = new System.Windows.Forms.PictureBox();
            this.PlayerCard4 = new System.Windows.Forms.PictureBox();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.PlayerCard5 = new System.Windows.Forms.PictureBox();
            this.DealerCard2 = new System.Windows.Forms.PictureBox();
            this.DealerCard3 = new System.Windows.Forms.PictureBox();
            this.DealerCard4 = new System.Windows.Forms.PictureBox();
            this.DealerCard1 = new System.Windows.Forms.PictureBox();
            this.DealerCard5 = new System.Windows.Forms.PictureBox();
            this.TheDeck = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.gameScore = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCard
            // 
            this.DrawCard.BackColor = System.Drawing.Color.ForestGreen;
            this.DrawCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrawCard.Location = new System.Drawing.Point(12, 327);
            this.DrawCard.Name = "DrawCard";
            this.DrawCard.Size = new System.Drawing.Size(111, 23);
            this.DrawCard.TabIndex = 19;
            this.DrawCard.Text = "Player Draw";
            this.DrawCard.UseVisualStyleBackColor = false;
            this.DrawCard.Click += new System.EventHandler(this.Draw_Click);
            // 
            // DealerDraw
            // 
            this.DealerDraw.BackColor = System.Drawing.Color.ForestGreen;
            this.DealerDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DealerDraw.Location = new System.Drawing.Point(384, 327);
            this.DealerDraw.Name = "DealerDraw";
            this.DealerDraw.Size = new System.Drawing.Size(111, 23);
            this.DealerDraw.TabIndex = 1;
            this.DealerDraw.Text = "Dealer Draw";
            this.DealerDraw.UseVisualStyleBackColor = false;
            this.DealerDraw.Click += new System.EventHandler(this.EndTurn_Click);
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.Location = new System.Drawing.Point(232, 272);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(45, 60);
            this.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard3.TabIndex = 18;
            this.PlayerCard3.TabStop = false;
            this.PlayerCard3.Visible = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.Location = new System.Drawing.Point(334, 257);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(45, 60);
            this.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard4.TabIndex = 17;
            this.PlayerCard4.TabStop = false;
            this.PlayerCard4.Visible = false;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.Location = new System.Drawing.Point(129, 257);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(45, 60);
            this.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard2.TabIndex = 16;
            this.PlayerCard2.TabStop = false;
            this.PlayerCard2.Visible = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.Location = new System.Drawing.Point(425, 218);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(45, 60);
            this.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard5.TabIndex = 15;
            this.PlayerCard5.TabStop = false;
            this.PlayerCard5.Visible = false;
            // 
            // DealerCard2
            // 
            this.DealerCard2.Image = ((System.Drawing.Image)(resources.GetObject("DealerCard2.Image")));
            this.DealerCard2.Location = new System.Drawing.Point(181, 12);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(45, 60);
            this.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard2.TabIndex = 7;
            this.DealerCard2.TabStop = false;
            // 
            // DealerCard3
            // 
            this.DealerCard3.Image = ((System.Drawing.Image)(resources.GetObject("DealerCard3.Image")));
            this.DealerCard3.Location = new System.Drawing.Point(232, 12);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(45, 60);
            this.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard3.TabIndex = 8;
            this.DealerCard3.TabStop = false;
            // 
            // DealerCard4
            // 
            this.DealerCard4.Image = ((System.Drawing.Image)(resources.GetObject("DealerCard4.Image")));
            this.DealerCard4.Location = new System.Drawing.Point(283, 12);
            this.DealerCard4.Name = "DealerCard4";
            this.DealerCard4.Size = new System.Drawing.Size(45, 60);
            this.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard4.TabIndex = 9;
            this.DealerCard4.TabStop = false;
            // 
            // DealerCard1
            // 
            this.DealerCard1.Image = ((System.Drawing.Image)(resources.GetObject("DealerCard1.Image")));
            this.DealerCard1.Location = new System.Drawing.Point(129, 12);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(45, 60);
            this.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard1.TabIndex = 10;
            this.DealerCard1.TabStop = false;
            this.DealerCard1.Click += new System.EventHandler(this.DealerCard1_Click);
            // 
            // DealerCard5
            // 
            this.DealerCard5.Image = ((System.Drawing.Image)(resources.GetObject("DealerCard5.Image")));
            this.DealerCard5.Location = new System.Drawing.Point(334, 12);
            this.DealerCard5.Name = "DealerCard5";
            this.DealerCard5.Size = new System.Drawing.Size(45, 60);
            this.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard5.TabIndex = 11;
            this.DealerCard5.TabStop = false;
            // 
            // TheDeck
            // 
            this.TheDeck.ErrorImage = null;
            this.TheDeck.Image = ((System.Drawing.Image)(resources.GetObject("TheDeck.Image")));
            this.TheDeck.Location = new System.Drawing.Point(450, 12);
            this.TheDeck.Name = "TheDeck";
            this.TheDeck.Size = new System.Drawing.Size(45, 60);
            this.TheDeck.TabIndex = 14;
            this.TheDeck.TabStop = false;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.Location = new System.Drawing.Point(34, 218);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(45, 60);
            this.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard1.TabIndex = 13;
            this.PlayerCard1.TabStop = false;
            this.PlayerCard1.Visible = false;
            this.PlayerCard1.Click += new System.EventHandler(this.PlayerCard1_Click);
            // 
            // gameScore
            // 
            this.gameScore.AutoSize = true;
            this.gameScore.BackColor = System.Drawing.SystemColors.Control;
            this.gameScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameScore.Location = new System.Drawing.Point(12, 38);
            this.gameScore.MaximumSize = new System.Drawing.Size(111, 0);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(38, 15);
            this.gameScore.TabIndex = 20;
            this.gameScore.Text = "label1";
            this.gameScore.Visible = false;
            this.gameScore.Click += new System.EventHandler(this.Label1_Click);
            // 
            // EndGame
            // 
            this.EndGame.BackColor = System.Drawing.Color.ForestGreen;
            this.EndGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EndGame.Location = new System.Drawing.Point(12, 12);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(111, 23);
            this.EndGame.TabIndex = 21;
            this.EndGame.Text = "Calculate winner";
            this.EndGame.UseVisualStyleBackColor = false;
            this.EndGame.Visible = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(507, 362);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.gameScore);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.TheDeck);
            this.Controls.Add(this.DealerCard5);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.DealerCard4);
            this.Controls.Add(this.DealerCard3);
            this.Controls.Add(this.DealerCard2);
            this.Controls.Add(this.PlayerCard5);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.DealerDraw);
            this.Controls.Add(this.DrawCard);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawCard;
        private System.Windows.Forms.Button DealerDraw;
        private System.Windows.Forms.PictureBox PlayerCard3;
        private System.Windows.Forms.PictureBox PlayerCard4;
        private System.Windows.Forms.PictureBox PlayerCard2;
        private System.Windows.Forms.PictureBox PlayerCard5;
        private System.Windows.Forms.PictureBox DealerCard2;
        private System.Windows.Forms.PictureBox DealerCard3;
        private System.Windows.Forms.PictureBox DealerCard4;
        private System.Windows.Forms.PictureBox DealerCard1;
        private System.Windows.Forms.PictureBox DealerCard5;
        private System.Windows.Forms.PictureBox TheDeck;
        private System.Windows.Forms.PictureBox PlayerCard1;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Button EndGame;
    }
}

