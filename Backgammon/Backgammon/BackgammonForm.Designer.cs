using System.Drawing;

namespace Backgammon
{
    partial class BackgammonForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Backgammon.Properties.Resources.Backgammon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 489);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backgammonTriangale1
            // 
            this.backgammonTriangale1.BackgroundImage = global::Backgammon.Properties.Resources.black;
            this.backgammonTriangale1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgammonTriangale1.Location = new System.Drawing.Point(531, 295);
            this.backgammonTriangale1.Name = "backgammonTriangale1";
            this.backgammonTriangale1.Size = new System.Drawing.Size(34, 195);
            this.backgammonTriangale1.TabIndex = 8;
            // 
            // backgammonTriangale2
            // 
            this.backgammonTriangale2.BackgroundImage = global::Backgammon.Properties.Resources.white;
            this.backgammonTriangale2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgammonTriangale2.Location = new System.Drawing.Point(491, 295);
            this.backgammonTriangale2.Name = "backgammonTriangale2";
            this.backgammonTriangale2.Size = new System.Drawing.Size(34, 195);
            this.backgammonTriangale2.TabIndex = 9;
            // 
            // backgammonTriangale3
            // 
            this.backgammonTriangale3.BackgroundImage = global::Backgammon.Properties.Resources.black;
            this.backgammonTriangale3.Location = new System.Drawing.Point(451, 295);
            this.backgammonTriangale3.Name = "backgammonTriangale3";
            this.backgammonTriangale3.Size = new System.Drawing.Size(34, 195);
            this.backgammonTriangale3.TabIndex = 10;
            // 
            // backgammonTriangale4
            // 
            this.backgammonTriangale4.BackgroundImage = global::Backgammon.Properties.Resources.black;
            this.backgammonTriangale4.Location = new System.Drawing.Point(411, 295);
            this.backgammonTriangale4.Name = "backgammonTriangale4";
            this.backgammonTriangale4.Size = new System.Drawing.Size(34, 195);
            this.backgammonTriangale4.TabIndex = 11;
            // 
            // backgammonTriangale5
            // 
            this.backgammonTriangale5.BackgroundImage = global::Backgammon.Properties.Resources.black;
            this.backgammonTriangale5.Location = new System.Drawing.Point(373, 295);
            this.backgammonTriangale5.Name = "backgammonTriangale5";
            this.backgammonTriangale5.Size = new System.Drawing.Size(34, 195);
            this.backgammonTriangale5.TabIndex = 12;
            // 
            // backgammonTriangale6
            // 
            this.backgammonTriangale6.BackgroundImage = global::Backgammon.Properties.Resources.black;
            this.backgammonTriangale6.Location = new System.Drawing.Point(333, 295);
            this.backgammonTriangale6.Name = "backgammonTriangale6";
            this.backgammonTriangale6.Size = new System.Drawing.Size(34, 195);
            this.backgammonTriangale6.TabIndex = 13;
            // 
            // BackgammonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 510);
            this.Controls.Add(this.backgammonTriangale6);
            this.Controls.Add(this.backgammonTriangale5);
            this.Controls.Add(this.backgammonTriangale4);
            this.Controls.Add(this.backgammonTriangale3);
            this.Controls.Add(this.backgammonTriangale2);
            this.Controls.Add(this.backgammonTriangale1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BackgammonForm";
            this.Text = "BackgammonForm";
            this.Load += new System.EventHandler(this.BackgammonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private BackgammonTriangale backgammonTriangale1;
        private BackgammonTriangale backgammonTriangale2;
        private BackgammonTriangale backgammonTriangale3;
        private BackgammonTriangale backgammonTriangale4;
        private BackgammonTriangale backgammonTriangale5;
        private BackgammonTriangale backgammonTriangale6;
    }
}