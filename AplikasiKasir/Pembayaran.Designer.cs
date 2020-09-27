namespace AplikasiKasir
{
    partial class Pembayaran
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
            this.lTolBel = new System.Windows.Forms.Label();
            this.lBay = new System.Windows.Forms.Label();
            this.lKem = new System.Windows.Forms.Label();
            this.bBayar = new System.Windows.Forms.Button();
            this.bKembali = new System.Windows.Forms.Button();
            this.lTotalHargaBelanja = new System.Windows.Forms.Label();
            this.lKembali = new System.Windows.Forms.Label();
            this.tBayar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lTolBel
            // 
            this.lTolBel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTolBel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTolBel.Location = new System.Drawing.Point(42, 30);
            this.lTolBel.Margin = new System.Windows.Forms.Padding(0);
            this.lTolBel.Name = "lTolBel";
            this.lTolBel.Size = new System.Drawing.Size(401, 24);
            this.lTolBel.TabIndex = 0;
            this.lTolBel.Text = "Total Belanjaan";
            // 
            // lBay
            // 
            this.lBay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBay.Location = new System.Drawing.Point(42, 114);
            this.lBay.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lBay.Name = "lBay";
            this.lBay.Size = new System.Drawing.Size(401, 24);
            this.lBay.TabIndex = 0;
            this.lBay.Text = "Bayar";
            // 
            // lKem
            // 
            this.lKem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lKem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKem.Location = new System.Drawing.Point(42, 194);
            this.lKem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lKem.Name = "lKem";
            this.lKem.Size = new System.Drawing.Size(401, 24);
            this.lKem.TabIndex = 0;
            this.lKem.Text = "Kembalian";
            // 
            // bBayar
            // 
            this.bBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBayar.Location = new System.Drawing.Point(293, 288);
            this.bBayar.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.bBayar.Name = "bBayar";
            this.bBayar.Size = new System.Drawing.Size(150, 50);
            this.bBayar.TabIndex = 1;
            this.bBayar.Text = "Bayar ( Enter )";
            this.bBayar.UseVisualStyleBackColor = true;
            this.bBayar.Click += new System.EventHandler(this.bBayar_Click);
            // 
            // bKembali
            // 
            this.bKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKembali.Location = new System.Drawing.Point(105, 288);
            this.bKembali.Margin = new System.Windows.Forms.Padding(40, 30, 3, 3);
            this.bKembali.Name = "bKembali";
            this.bKembali.Size = new System.Drawing.Size(150, 50);
            this.bKembali.TabIndex = 2;
            this.bKembali.Text = "Kembali ( Esc )";
            this.bKembali.UseVisualStyleBackColor = true;
            this.bKembali.Click += new System.EventHandler(this.bKembali_Click);
            // 
            // lTotalHargaBelanja
            // 
            this.lTotalHargaBelanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotalHargaBelanja.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lTotalHargaBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalHargaBelanja.Location = new System.Drawing.Point(42, 64);
            this.lTotalHargaBelanja.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lTotalHargaBelanja.Name = "lTotalHargaBelanja";
            this.lTotalHargaBelanja.Size = new System.Drawing.Size(401, 30);
            this.lTotalHargaBelanja.TabIndex = 2;
            this.lTotalHargaBelanja.Text = "label4";
            this.lTotalHargaBelanja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lKembali
            // 
            this.lKembali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lKembali.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKembali.Location = new System.Drawing.Point(42, 228);
            this.lKembali.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lKembali.Name = "lKembali";
            this.lKembali.Size = new System.Drawing.Size(401, 30);
            this.lKembali.TabIndex = 2;
            this.lKembali.Text = "0";
            this.lKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBayar
            // 
            this.tBayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBayar.Location = new System.Drawing.Point(42, 148);
            this.tBayar.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tBayar.Name = "tBayar";
            this.tBayar.Size = new System.Drawing.Size(401, 26);
            this.tBayar.TabIndex = 0;
            this.tBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBayar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tBayar_KeyUp);
            this.tBayar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.keyDown);
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lTolBel);
            this.Controls.Add(this.lTotalHargaBelanja);
            this.Controls.Add(this.bKembali);
            this.Controls.Add(this.lBay);
            this.Controls.Add(this.bBayar);
            this.Controls.Add(this.tBayar);
            this.Controls.Add(this.lKembali);
            this.Controls.Add(this.lKem);
            this.Name = "Pembayaran";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTolBel;
        private System.Windows.Forms.Label lBay;
        private System.Windows.Forms.Label lKem;
        private System.Windows.Forms.Button bBayar;
        private System.Windows.Forms.Button bKembali;
        private System.Windows.Forms.Label lTotalHargaBelanja;
        private System.Windows.Forms.Label lKembali;
        private System.Windows.Forms.TextBox tBayar;
    }
}