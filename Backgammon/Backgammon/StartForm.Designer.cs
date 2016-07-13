namespace Backgammon
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelYourName = new System.Windows.Forms.Label();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.textBoxFriendName = new System.Windows.Forms.TextBox();
            this.radioButtonAgainstFriend = new System.Windows.Forms.RadioButton();
            this.radioButtonAgainstComputer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2Computers = new System.Windows.Forms.RadioButton();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backgammon";
            // 
            // labelYourName
            // 
            this.labelYourName.AutoSize = true;
            this.labelYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelYourName.Location = new System.Drawing.Point(4, 66);
            this.labelYourName.Name = "labelYourName";
            this.labelYourName.Size = new System.Drawing.Size(80, 15);
            this.labelYourName.TabIndex = 1;
            this.labelYourName.Text = "Your name:";
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendName.Location = new System.Drawing.Point(4, 92);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(92, 15);
            this.labelFriendName.TabIndex = 2;
            this.labelFriendName.Text = "Friend name:";
            this.labelFriendName.Visible = false;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(102, 65);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(249, 20);
            this.textBoxPlayerName.TabIndex = 3;
            // 
            // textBoxFriendName
            // 
            this.textBoxFriendName.Location = new System.Drawing.Point(102, 91);
            this.textBoxFriendName.Name = "textBoxFriendName";
            this.textBoxFriendName.Size = new System.Drawing.Size(249, 20);
            this.textBoxFriendName.TabIndex = 4;
            this.textBoxFriendName.Visible = false;
            // 
            // radioButtonAgainstFriend
            // 
            this.radioButtonAgainstFriend.AutoSize = true;
            this.radioButtonAgainstFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAgainstFriend.Location = new System.Drawing.Point(266, 32);
            this.radioButtonAgainstFriend.Name = "radioButtonAgainstFriend";
            this.radioButtonAgainstFriend.Size = new System.Drawing.Size(60, 17);
            this.radioButtonAgainstFriend.TabIndex = 5;
            this.radioButtonAgainstFriend.TabStop = true;
            this.radioButtonAgainstFriend.Text = "Friend";
            this.radioButtonAgainstFriend.UseVisualStyleBackColor = true;
            this.radioButtonAgainstFriend.CheckedChanged += new System.EventHandler(this.radioButtonAgainstFriend_CheckedChanged);
            // 
            // radioButtonAgainstComputer
            // 
            this.radioButtonAgainstComputer.AutoSize = true;
            this.radioButtonAgainstComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAgainstComputer.Location = new System.Drawing.Point(11, 32);
            this.radioButtonAgainstComputer.Name = "radioButtonAgainstComputer";
            this.radioButtonAgainstComputer.Size = new System.Drawing.Size(78, 17);
            this.radioButtonAgainstComputer.TabIndex = 6;
            this.radioButtonAgainstComputer.TabStop = true;
            this.radioButtonAgainstComputer.Text = "Computer";
            this.radioButtonAgainstComputer.UseVisualStyleBackColor = true;
            this.radioButtonAgainstComputer.CheckedChanged += new System.EventHandler(this.radioButtonAgainstComputer_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2Computers);
            this.groupBox1.Controls.Add(this.radioButtonAgainstFriend);
            this.groupBox1.Controls.Add(this.radioButtonAgainstComputer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game mode";
            // 
            // radioButton2Computers
            // 
            this.radioButton2Computers.AutoSize = true;
            this.radioButton2Computers.Location = new System.Drawing.Point(119, 32);
            this.radioButton2Computers.Name = "radioButton2Computers";
            this.radioButton2Computers.Size = new System.Drawing.Size(95, 17);
            this.radioButton2Computers.TabIndex = 7;
            this.radioButton2Computers.TabStop = true;
            this.radioButton2Computers.Text = "2 Computers";
            this.radioButton2Computers.UseVisualStyleBackColor = true;
            this.radioButton2Computers.CheckedChanged += new System.EventHandler(this.radioButton2Computers_CheckedChanged);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPlay.Location = new System.Drawing.Point(131, 233);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(103, 45);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 290);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFriendName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.labelYourName);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYourName;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.TextBox textBoxFriendName;
        private System.Windows.Forms.RadioButton radioButtonAgainstFriend;
        private System.Windows.Forms.RadioButton radioButtonAgainstComputer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.RadioButton radioButton2Computers;
    }
}

