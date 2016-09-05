namespace UIPriceCompare
{
    partial class LoginRegisterForm
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
            this.buttonAnonymous = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.radioButtonResgister = new System.Windows.Forms.RadioButton();
            this.radioButtonLogin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNotAnunymos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnonymous
            // 
            this.buttonAnonymous.Location = new System.Drawing.Point(12, 215);
            this.buttonAnonymous.Name = "buttonAnonymous";
            this.buttonAnonymous.Size = new System.Drawing.Size(106, 35);
            this.buttonAnonymous.TabIndex = 0;
            this.buttonAnonymous.Text = "Anonymous User";
            this.buttonAnonymous.UseVisualStyleBackColor = true;
            this.buttonAnonymous.Click += new System.EventHandler(this.buttonAnonymous_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(92, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(213, 93);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // radioButtonResgister
            // 
            this.radioButtonResgister.AutoSize = true;
            this.radioButtonResgister.Location = new System.Drawing.Point(17, 21);
            this.radioButtonResgister.Name = "radioButtonResgister";
            this.radioButtonResgister.Size = new System.Drawing.Size(64, 17);
            this.radioButtonResgister.TabIndex = 5;
            this.radioButtonResgister.TabStop = true;
            this.radioButtonResgister.Text = "Register";
            this.radioButtonResgister.UseVisualStyleBackColor = true;
            // 
            // radioButtonLogin
            // 
            this.radioButtonLogin.AutoSize = true;
            this.radioButtonLogin.Location = new System.Drawing.Point(94, 21);
            this.radioButtonLogin.Name = "radioButtonLogin";
            this.radioButtonLogin.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLogin.TabIndex = 6;
            this.radioButtonLogin.TabStop = true;
            this.radioButtonLogin.Text = "Login";
            this.radioButtonLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonResgister);
            this.groupBox1.Controls.Add(this.radioButtonLogin);
            this.groupBox1.Location = new System.Drawing.Point(105, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonNotAnunymos
            // 
            this.buttonNotAnunymos.Location = new System.Drawing.Point(92, 133);
            this.buttonNotAnunymos.Name = "buttonNotAnunymos";
            this.buttonNotAnunymos.Size = new System.Drawing.Size(221, 36);
            this.buttonNotAnunymos.TabIndex = 8;
            this.buttonNotAnunymos.Text = "Enter";
            this.buttonNotAnunymos.UseVisualStyleBackColor = true;
            this.buttonNotAnunymos.Click += new System.EventHandler(this.buttonNotAnunymos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter as:";
            // 
            // LoginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNotAnunymos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAnonymous);
            this.Name = "LoginRegisterForm";
            this.Text = "LoginRegiterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnonymous;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.RadioButton radioButtonResgister;
        private System.Windows.Forms.RadioButton radioButtonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNotAnunymos;
        private System.Windows.Forms.Label label3;
    }
}

