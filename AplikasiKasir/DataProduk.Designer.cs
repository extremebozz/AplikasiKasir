namespace AplikasiKasir
{
    partial class DataProduk
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
            this.pKiri = new System.Windows.Forms.Panel();
            this.bHapus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tHargaProduk = new System.Windows.Forms.TextBox();
            this.tNamaProduk = new System.Windows.Forms.TextBox();
            this.tKodeProduk = new System.Windows.Forms.TextBox();
            this.pDatagridview = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pKiri.SuspendLayout();
            this.pDatagridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(800, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Produk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pKiri
            // 
            this.pKiri.Controls.Add(this.bHapus);
            this.pKiri.Controls.Add(this.button1);
            this.pKiri.Controls.Add(this.label4);
            this.pKiri.Controls.Add(this.label3);
            this.pKiri.Controls.Add(this.label2);
            this.pKiri.Controls.Add(this.tHargaProduk);
            this.pKiri.Controls.Add(this.tNamaProduk);
            this.pKiri.Controls.Add(this.tKodeProduk);
            this.pKiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.pKiri.Location = new System.Drawing.Point(0, 50);
            this.pKiri.Name = "pKiri";
            this.pKiri.Size = new System.Drawing.Size(300, 400);
            this.pKiri.TabIndex = 1;
            // 
            // bHapus
            // 
            this.bHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHapus.Location = new System.Drawing.Point(22, 300);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(120, 50);
            this.bHapus.TabIndex = 7;
            this.bHapus.Text = "Hapus ( Delete )";
            this.bHapus.UseVisualStyleBackColor = true;
            this.bHapus.Click += new System.EventHandler(this.bHapus_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Simpan ( Enter )";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga Produk";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Produk";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kode Produk";
            // 
            // tHargaProduk
            // 
            this.tHargaProduk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tHargaProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHargaProduk.Location = new System.Drawing.Point(34, 232);
            this.tHargaProduk.Name = "tHargaProduk";
            this.tHargaProduk.Size = new System.Drawing.Size(227, 23);
            this.tHargaProduk.TabIndex = 2;
            // 
            // tNamaProduk
            // 
            this.tNamaProduk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tNamaProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNamaProduk.Location = new System.Drawing.Point(34, 153);
            this.tNamaProduk.Name = "tNamaProduk";
            this.tNamaProduk.Size = new System.Drawing.Size(227, 23);
            this.tNamaProduk.TabIndex = 1;
            // 
            // tKodeProduk
            // 
            this.tKodeProduk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tKodeProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKodeProduk.Location = new System.Drawing.Point(34, 78);
            this.tKodeProduk.Name = "tKodeProduk";
            this.tKodeProduk.Size = new System.Drawing.Size(227, 23);
            this.tKodeProduk.TabIndex = 0;
            // 
            // pDatagridview
            // 
            this.pDatagridview.Controls.Add(this.dataGridView1);
            this.pDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatagridview.Location = new System.Drawing.Point(300, 50);
            this.pDatagridview.Name = "pDatagridview";
            this.pDatagridview.Padding = new System.Windows.Forms.Padding(15);
            this.pDatagridview.Size = new System.Drawing.Size(500, 400);
            this.pDatagridview.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DataProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pDatagridview);
            this.Controls.Add(this.pKiri);
            this.Controls.Add(this.label1);
            this.Name = "DataProduk";
            this.Text = "DataProduk";
            this.pKiri.ResumeLayout(false);
            this.pKiri.PerformLayout();
            this.pDatagridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pKiri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tHargaProduk;
        private System.Windows.Forms.TextBox tNamaProduk;
        private System.Windows.Forms.TextBox tKodeProduk;
        private System.Windows.Forms.Panel pDatagridview;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}