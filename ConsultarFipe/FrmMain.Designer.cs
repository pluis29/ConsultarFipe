namespace ConsultarFipe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.picLogoFipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFipe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(107, 278);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(70, 212);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(353, 22);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "Consulta de preço médio de veículos";
            // 
            // btnFavorites
            // 
            this.btnFavorites.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFavorites.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorites.Location = new System.Drawing.Point(259, 278);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(103, 31);
            this.btnFavorites.TabIndex = 2;
            this.btnFavorites.Text = "Favoritos";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // picLogoFipe
            // 
            this.picLogoFipe.ErrorImage = null;
            this.picLogoFipe.Image = global::ConsultarFipe.Properties.Resources.fipe_logo;
            this.picLogoFipe.Location = new System.Drawing.Point(169, 60);
            this.picLogoFipe.Name = "picLogoFipe";
            this.picLogoFipe.Size = new System.Drawing.Size(140, 118);
            this.picLogoFipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoFipe.TabIndex = 4;
            this.picLogoFipe.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 370);
            this.Controls.Add(this.picLogoFipe);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tabela FIPE";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoFipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.PictureBox picLogoFipe;
    }
}

