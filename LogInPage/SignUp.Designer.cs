namespace LogInPage
{
    partial class SignUp
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
            this.NewUser = new System.Windows.Forms.Label();
            this.NewPass = new System.Windows.Forms.Label();
            this.ConfPass = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPasswords = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswords = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewUser
            // 
            this.NewUser.AutoSize = true;
            this.NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.NewUser.Location = new System.Drawing.Point(99, 45);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(83, 20);
            this.NewUser.TabIndex = 0;
            this.NewUser.Text = "Username";
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.NewPass.Location = new System.Drawing.Point(99, 146);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(78, 20);
            this.NewPass.TabIndex = 1;
            this.NewPass.Text = "Password";
            // 
            // ConfPass
            // 
            this.ConfPass.AutoSize = true;
            this.ConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.ConfPass.Location = new System.Drawing.Point(99, 251);
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.Size = new System.Drawing.Size(137, 20);
            this.ConfPass.TabIndex = 2;
            this.ConfPass.Text = "Confirm Password";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(103, 68);
            this.txtNewUsername.Multiline = true;
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(355, 54);
            this.txtNewUsername.TabIndex = 3;
            // 
            // txtNewPasswords
            // 
            this.txtNewPasswords.Location = new System.Drawing.Point(103, 169);
            this.txtNewPasswords.Multiline = true;
            this.txtNewPasswords.Name = "txtNewPasswords";
            this.txtNewPasswords.Size = new System.Drawing.Size(355, 54);
            this.txtNewPasswords.TabIndex = 4;
            // 
            // txtConfirmPasswords
            // 
            this.txtConfirmPasswords.Location = new System.Drawing.Point(103, 274);
            this.txtConfirmPasswords.Multiline = true;
            this.txtConfirmPasswords.Name = "txtConfirmPasswords";
            this.txtConfirmPasswords.Size = new System.Drawing.Size(355, 54);
            this.txtConfirmPasswords.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(102, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "SIGN UP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(184, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Already have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(210, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Click here to log in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConfirmPasswords);
            this.Controls.Add(this.txtNewPasswords);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.ConfPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.NewUser);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewUser;
        private System.Windows.Forms.Label NewPass;
        private System.Windows.Forms.Label ConfPass;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtNewPasswords;
        private System.Windows.Forms.TextBox txtConfirmPasswords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}