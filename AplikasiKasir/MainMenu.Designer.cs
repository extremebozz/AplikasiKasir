namespace AplikasiKasir
{
    partial class MainMenu
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
            this.pChild = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pChild
            // 
            this.pChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChild.Location = new System.Drawing.Point(0, 0);
            this.pChild.Name = "pChild";
            this.pChild.Size = new System.Drawing.Size(800, 450);
            this.pChild.TabIndex = 99;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pChild);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pChild;
    }
}

