namespace PROJECT_DBMS
{
    partial class CUSTOMER
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 123);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DeVinne Txt BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(134, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ONLINE FOOD ORDERING SYSYTEM";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(721, 396);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(73, 402);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(41, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(300, 47);
            this.loginButton.TabIndex = 16;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(226, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(225, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "USERNAME :";
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(351, 271);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(273, 26);
            this.passwordField.TabIndex = 13;
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(351, 216);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(273, 26);
            this.usernameField.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(361, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "CUSTOMER";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(522, 345);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(295, 47);
            this.signupButton.TabIndex = 19;
            this.signupButton.Text = "SIGNUP";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 20;
            // 
            // CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "CUSTOMER";
            this.Text = "CUSTOMER";
            this.Load += new System.EventHandler(this.CUSTOMER_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label label5;
    }
}