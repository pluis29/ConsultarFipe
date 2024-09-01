namespace ConsultarFipe
{
    partial class FrmFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFavorites));
            this.lvwFavorites = new System.Windows.Forms.ListView();
            this.chBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFipeCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemoveFavorite = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lvwFavorites
            // 
            this.lvwFavorites.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFavorites.BackColor = System.Drawing.SystemColors.Menu;
            this.lvwFavorites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBrand,
            this.chYear,
            this.chPrice,
            this.chFipeCode,
            this.chReference});
            this.lvwFavorites.HideSelection = false;
            this.lvwFavorites.HoverSelection = true;
            this.lvwFavorites.Location = new System.Drawing.Point(12, 48);
            this.lvwFavorites.Name = "lvwFavorites";
            this.lvwFavorites.Size = new System.Drawing.Size(853, 493);
            this.lvwFavorites.TabIndex = 0;
            this.lvwFavorites.UseCompatibleStateImageBehavior = false;
            this.lvwFavorites.View = System.Windows.Forms.View.Details;
            // 
            // chBrand
            // 
            this.chBrand.Text = "Marca";
            this.chBrand.Width = 222;
            // 
            // chYear
            // 
            this.chYear.Text = "Ano";
            this.chYear.Width = 179;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Preço";
            this.chPrice.Width = 131;
            // 
            // chFipeCode
            // 
            this.chFipeCode.Text = "Código Fipe";
            this.chFipeCode.Width = 146;
            // 
            // chReference
            // 
            this.chReference.Text = "Referência";
            this.chReference.Width = 168;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(565, 548);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(300, 31);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveFavorite
            // 
            this.btnRemoveFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveFavorite.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveFavorite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFavorite.Location = new System.Drawing.Point(12, 548);
            this.btnRemoveFavorite.Name = "btnRemoveFavorite";
            this.btnRemoveFavorite.Size = new System.Drawing.Size(369, 32);
            this.btnRemoveFavorite.TabIndex = 14;
            this.btnRemoveFavorite.Text = "Remover Favorito";
            this.btnRemoveFavorite.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 25);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Favoritos";
            // 
            // pnlDivision
            // 
            this.pnlDivision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDivision.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDivision.Location = new System.Drawing.Point(12, 37);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(855, 2);
            this.pnlDivision.TabIndex = 16;
            // 
            // FrmFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 585);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRemoveFavorite);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvwFavorites);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFavorites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favoritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwFavorites;
        public System.Windows.Forms.ColumnHeader chBrand;
        public System.Windows.Forms.ColumnHeader chYear;
        public System.Windows.Forms.ColumnHeader chPrice;
        public System.Windows.Forms.ColumnHeader chFipeCode;
        public System.Windows.Forms.ColumnHeader chReference;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemoveFavorite;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDivision;
    }
}