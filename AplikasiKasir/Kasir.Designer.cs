namespace AplikasiKasir
{
    partial class Kasir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pKanan = new System.Windows.Forms.Panel();
            this.nudDiskon = new System.Windows.Forms.NumericUpDown();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.tKode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lNamaKasir = new System.Windows.Forms.Label();
            this.pAtas = new System.Windows.Forms.Panel();
            this.pChildAtas = new System.Windows.Forms.Panel();
            this.lTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lInvoice = new System.Windows.Forms.Label();
            this.pBawah = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pKanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.pAtas.SuspendLayout();
            this.pChildAtas.SuspendLayout();
            this.pBawah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pKanan
            // 
            this.pKanan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pKanan.Controls.Add(this.nudDiskon);
            this.pKanan.Controls.Add(this.nudQty);
            this.pKanan.Controls.Add(this.button3);
            this.pKanan.Controls.Add(this.tKode);
            this.pKanan.Controls.Add(this.label3);
            this.pKanan.Controls.Add(this.label2);
            this.pKanan.Controls.Add(this.label1);
            this.pKanan.Controls.Add(this.lNamaKasir);
            this.pKanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pKanan.Location = new System.Drawing.Point(759, 0);
            this.pKanan.Name = "pKanan";
            this.pKanan.Size = new System.Drawing.Size(425, 491);
            this.pKanan.TabIndex = 0;
            // 
            // nudDiskon
            // 
            this.nudDiskon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiskon.Location = new System.Drawing.Point(45, 335);
            this.nudDiskon.Name = "nudDiskon";
            this.nudDiskon.Size = new System.Drawing.Size(343, 32);
            this.nudDiskon.TabIndex = 2;
            this.nudDiskon.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // nudQty
            // 
            this.nudQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(45, 245);
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(343, 32);
            this.nudQty.TabIndex = 1;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(95, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tambah ( Enter )";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // tKode
            // 
            this.tKode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKode.Location = new System.Drawing.Point(45, 155);
            this.tKode.Name = "tKode";
            this.tKode.Size = new System.Drawing.Size(343, 32);
            this.tKode.TabIndex = 0;
            this.tKode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 99;
            this.label3.Text = "Diskon ( % )";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 99;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 99;
            this.label1.Text = "Barcode / Kode";
            // 
            // lNamaKasir
            // 
            this.lNamaKasir.Dock = System.Windows.Forms.DockStyle.Top;
            this.lNamaKasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNamaKasir.Location = new System.Drawing.Point(0, 0);
            this.lNamaKasir.Name = "lNamaKasir";
            this.lNamaKasir.Padding = new System.Windows.Forms.Padding(35, 35, 0, 0);
            this.lNamaKasir.Size = new System.Drawing.Size(425, 70);
            this.lNamaKasir.TabIndex = 99;
            this.lNamaKasir.Text = "label1";
            // 
            // pAtas
            // 
            this.pAtas.BackColor = System.Drawing.Color.White;
            this.pAtas.Controls.Add(this.pChildAtas);
            this.pAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAtas.Location = new System.Drawing.Point(0, 0);
            this.pAtas.Name = "pAtas";
            this.pAtas.Padding = new System.Windows.Forms.Padding(30);
            this.pAtas.Size = new System.Drawing.Size(759, 200);
            this.pAtas.TabIndex = 1;
            // 
            // pChildAtas
            // 
            this.pChildAtas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pChildAtas.Controls.Add(this.lTotal);
            this.pChildAtas.Controls.Add(this.label4);
            this.pChildAtas.Controls.Add(this.lInvoice);
            this.pChildAtas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChildAtas.Location = new System.Drawing.Point(30, 30);
            this.pChildAtas.Name = "pChildAtas";
            this.pChildAtas.Size = new System.Drawing.Size(699, 140);
            this.pChildAtas.TabIndex = 5;
            // 
            // lTotal
            // 
            this.lTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(0, 70);
            this.lTotal.Name = "lTotal";
            this.lTotal.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lTotal.Size = new System.Drawing.Size(699, 70);
            this.lTotal.TabIndex = 99;
            this.lTotal.Text = "0";
            this.lTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 40);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(699, 30);
            this.label4.TabIndex = 99;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lInvoice
            // 
            this.lInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInvoice.Location = new System.Drawing.Point(0, 0);
            this.lInvoice.Margin = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lInvoice.Name = "lInvoice";
            this.lInvoice.Padding = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.lInvoice.Size = new System.Drawing.Size(699, 40);
            this.lInvoice.TabIndex = 99;
            this.lInvoice.Text = "Pembelian";
            // 
            // pBawah
            // 
            this.pBawah.BackColor = System.Drawing.Color.White;
            this.pBawah.Controls.Add(this.dataGridView1);
            this.pBawah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBawah.Location = new System.Drawing.Point(0, 200);
            this.pBawah.Name = "pBawah";
            this.pBawah.Padding = new System.Windows.Forms.Padding(30);
            this.pBawah.Size = new System.Drawing.Size(759, 291);
            this.pBawah.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 231);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Produk";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 170F;
            this.Column2.HeaderText = "Nama Produk";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Harga";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40F;
            this.Column4.HeaderText = "Qty";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "Diskon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1094, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Text = "Logout\n( F12 )";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pMenu.Controls.Add(this.button4);
            this.pMenu.Controls.Add(this.button5);
            this.pMenu.Controls.Add(this.button2);
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenu.Location = new System.Drawing.Point(0, 491);
            this.pMenu.Name = "pMenu";
            this.pMenu.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.pMenu.Size = new System.Drawing.Size(1184, 70);
            this.pMenu.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(220, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 50);
            this.button4.TabIndex = 7;
            this.button4.TabStop = false;
            this.button4.Text = "Pembayaran\r\n( F3 )";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(120, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 50);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Text = "Pencarian\r\n( F2 )";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(20, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 50);
            this.button5.TabIndex = 7;
            this.button5.TabStop = false;
            this.button5.Text = "Transaksi Baru\r\n( F1 )";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pBawah);
            this.Controls.Add(this.pAtas);
            this.Controls.Add(this.pKanan);
            this.Controls.Add(this.pMenu);
            this.Name = "Kasir";
            this.Text = "Kasir";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            this.pKanan.ResumeLayout(false);
            this.pKanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.pAtas.ResumeLayout(false);
            this.pChildAtas.ResumeLayout(false);
            this.pBawah.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pKanan;
        private System.Windows.Forms.Panel pAtas;
        private System.Windows.Forms.Label lNamaKasir;
        private System.Windows.Forms.Panel pBawah;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Panel pChildAtas;
        private System.Windows.Forms.Label lInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tKode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.NumericUpDown nudDiskon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button5;
    }
}