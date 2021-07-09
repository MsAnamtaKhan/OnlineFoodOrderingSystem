namespace PROJECT_DBMS
{
    partial class DELIVER_CUSTOMER
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.id1Field = new System.Windows.Forms.TextBox();
            this.id2Field = new System.Windows.Forms.TextBox();
            this.idField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.id1Field);
            this.panel2.Controls.Add(this.id2Field);
            this.panel2.Controls.Add(this.idField);
            this.panel2.Controls.Add(this.deliverymenButton);
            this.panel2.Controls.Add(this.customerButton);
            this.panel2.Controls.Add(this.ordersButton);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 437);
            this.panel2.TabIndex = 44;
            // 
            // id1Field
            // 
            this.id1Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.id1Field.Location = new System.Drawing.Point(34, 357);
            this.id1Field.Name = "id1Field";
            this.id1Field.Size = new System.Drawing.Size(100, 20);
            this.id1Field.TabIndex = 5;
            this.id1Field.Visible = false;
            // 
            // id2Field
            // 
            this.id2Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.id2Field.Location = new System.Drawing.Point(34, 317);
            this.id2Field.Name = "id2Field";
            this.id2Field.Size = new System.Drawing.Size(100, 20);
            this.id2Field.TabIndex = 4;
            this.id2Field.Visible = false;
            // 
            // idField
            // 
            this.idField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.idField.Location = new System.Drawing.Point(34, 337);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 20);
            this.idField.TabIndex = 3;
            this.idField.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "CUSTOMER-DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 123);
            this.panel1.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(213, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 191);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ORDER-ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CUSTOMER-NAME";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "PAYMENT-TYPE";
            this.Column6.MinimumWidth = 10;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PRICE";
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "EMAIL";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CONTACT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // DELIVER_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DELIVER_CUSTOMER";
            this.Text = "DELIVER_CUSTOMER";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox id1Field;
        private System.Windows.Forms.TextBox id2Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}