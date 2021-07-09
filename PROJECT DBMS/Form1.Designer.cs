namespace PROJECT_DBMS
{
    partial class Form1
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
            this.adminButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.deliverymenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DeVinne Txt BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ONLINE FOOD ORDERING SYSYTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.adminButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.adminButton.Location = new System.Drawing.Point(289, 157);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(189, 75);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "ADMIN";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.customerButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.customerButton.Location = new System.Drawing.Point(287, 241);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(189, 75);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "CUSTOMER";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // deliverymenButton
            // 
            this.deliverymenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deliverymenButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverymenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deliverymenButton.Location = new System.Drawing.Point(289, 322);
            this.deliverymenButton.Name = "deliverymenButton";
            this.deliverymenButton.Size = new System.Drawing.Size(189, 75);
            this.deliverymenButton.TabIndex = 3;
            this.deliverymenButton.Text = "DELIVERYMEN";
            this.deliverymenButton.UseVisualStyleBackColor = false;
            this.deliverymenButton.Click += new System.EventHandler(this.deliverymenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(762, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.EXITBUTTON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliverymenButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button deliverymenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
    }
}

