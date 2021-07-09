namespace PROJECT_DBMS
{
    partial class DELIVERYMEN_LOGIN
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
            this.deliverymenButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id2Field = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acceptField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deliverymenButton
            // 
            this.deliverymenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deliverymenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverymenButton.ForeColor = System.Drawing.Color.Maroon;
            this.deliverymenButton.Location = new System.Drawing.Point(6, 250);
            this.deliverymenButton.Name = "deliverymenButton";
            this.deliverymenButton.Size = new System.Drawing.Size(180, 61);
            this.deliverymenButton.TabIndex = 2;
            this.deliverymenButton.Text = "DELIVERYMEN-DETAILS";
            this.deliverymenButton.UseVisualStyleBackColor = false;
            this.deliverymenButton.Click += new System.EventHandler(this.deliverymenButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.Color.Maroon;
            this.customerButton.Location = new System.Drawing.Point(17, 176);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(142, 53);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "CUSTOMER-DETAILS";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ordersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.ForeColor = System.Drawing.Color.Maroon;
            this.ordersButton.Location = new System.Drawing.Point(34, 103);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(109, 57);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.Text = "ORDERS";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(290, 438);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 30);
            this.backButton.TabIndex = 37;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.id2Field);
            this.panel2.Controls.Add(this.idField);
            this.panel2.Controls.Add(this.deliverymenButton);
            this.panel2.Controls.Add(this.customerButton);
            this.panel2.Controls.Add(this.ordersButton);
            this.panel2.Location = new System.Drawing.Point(52, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 437);
            this.panel2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            // 
            // id2Field
            // 
            this.id2Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.id2Field.Location = new System.Drawing.Point(43, 370);
            this.id2Field.Name = "id2Field";
            this.id2Field.Size = new System.Drawing.Size(100, 20);
            this.id2Field.TabIndex = 4;
            this.id2Field.Visible = false;
            // 
            // idField
            // 
            this.idField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.idField.Location = new System.Drawing.Point(43, 344);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 20);
            this.idField.TabIndex = 3;
            this.idField.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 39);
            this.label2.TabIndex = 35;
            this.label2.Text = "ORDERS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 123);
            this.panel1.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(274, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 225);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // acceptField
            // 
            this.acceptField.Location = new System.Drawing.Point(496, 137);
            this.acceptField.Name = "acceptField";
            this.acceptField.Size = new System.Drawing.Size(100, 20);
            this.acceptField.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "ENTER THE ID OF ORDER WHICH YOU WANT TO ACCEPT";
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Fuchsia;
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.Location = new System.Drawing.Point(613, 129);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 34);
            this.acceptButton.TabIndex = 45;
            this.acceptButton.Text = "ACCEPT :";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ORDER-ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ADDRESS";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ACCEPT";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DATE";
            this.Column3.Name = "Column3";
            // 
            // DELIVERYMEN_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(853, 535);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acceptField);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DELIVERYMEN_LOGIN";
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deliverymenButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox acceptField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox id2Field;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}