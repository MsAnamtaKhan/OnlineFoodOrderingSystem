namespace PROJECT_DBMS
{
    partial class Form2
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
            this.editButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.foodButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 123);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DeVinne Txt BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(138, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ONLINE FOOD ORDERING SYSYTEM";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.Maroon;
            this.editButton.Location = new System.Drawing.Point(383, 343);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(111, 61);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "EDIT-DETAILS";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.ForeColor = System.Drawing.Color.Maroon;
            this.orderButton.Location = new System.Drawing.Point(383, 279);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(124, 55);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "ORDERS-DETAILS";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // foodButton
            // 
            this.foodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.foodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodButton.ForeColor = System.Drawing.Color.Maroon;
            this.foodButton.Location = new System.Drawing.Point(383, 202);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(109, 57);
            this.foodButton.TabIndex = 0;
            this.foodButton.Text = "ORDER-FOOD";
            this.foodButton.UseVisualStyleBackColor = false;
            this.foodButton.Click += new System.EventHandler(this.foodButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 437);
            this.panel2.TabIndex = 45;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(51, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 46;
            this.textBox1.Visible = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Green;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(204, 452);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(595, 43);
            this.confirmButton.TabIndex = 43;
            this.confirmButton.Text = "ADD DETAILS";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DeVinne Txt BT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(206, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELCOME TO FOOD ORDERING SYSTEM AS CUSTOMER";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(231, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 47;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.foodButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.confirmButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backButton;
    }
}