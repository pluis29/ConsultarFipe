namespace ConsultarFipe
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpVehiclesType = new System.Windows.Forms.GroupBox();
            this.rdoTruck = new System.Windows.Forms.RadioButton();
            this.rdoMotorcycle = new System.Windows.Forms.RadioButton();
            this.rdoCar = new System.Windows.Forms.RadioButton();
            this.lblVehiclesType = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grpDisclaimer = new System.Windows.Forms.GroupBox();
            this.lblTextDisclaimer = new System.Windows.Forms.Label();
            this.lblLinkApi = new System.Windows.Forms.LinkLabel();
            this.tlpVehiclesInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTlpPriceInfo = new System.Windows.Forms.Label();
            this.lblTlpPrice = new System.Windows.Forms.Label();
            this.lblTlpYearInfo = new System.Windows.Forms.Label();
            this.lblTlpYear = new System.Windows.Forms.Label();
            this.lblTlpBrandInfo = new System.Windows.Forms.Label();
            this.lblTlpBrand = new System.Windows.Forms.Label();
            this.lblTlpFipeCodeInfo = new System.Windows.Forms.Label();
            this.lblTlpFipeCode = new System.Windows.Forms.Label();
            this.lblTlpReferenceInfo = new System.Windows.Forms.Label();
            this.lblTlpReference = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.grpVehiclesType.SuspendLayout();
            this.grpDisclaimer.SuspendLayout();
            this.tlpVehiclesInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Encontre seu veículo";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(12, 45);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(466, 16);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "Utilize a caixa da seleção para encontrar informações sobre o veículo";
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDivision.Location = new System.Drawing.Point(12, 70);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(492, 2);
            this.pnlDivision.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(292, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 31);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpVehiclesType
            // 
            this.grpVehiclesType.Controls.Add(this.rdoTruck);
            this.grpVehiclesType.Controls.Add(this.rdoMotorcycle);
            this.grpVehiclesType.Controls.Add(this.rdoCar);
            this.grpVehiclesType.Controls.Add(this.lblVehiclesType);
            this.grpVehiclesType.Location = new System.Drawing.Point(117, 96);
            this.grpVehiclesType.Name = "grpVehiclesType";
            this.grpVehiclesType.Size = new System.Drawing.Size(271, 44);
            this.grpVehiclesType.TabIndex = 1;
            this.grpVehiclesType.TabStop = false;
            // 
            // rdoTruck
            // 
            this.rdoTruck.AutoSize = true;
            this.rdoTruck.Location = new System.Drawing.Point(194, 16);
            this.rdoTruck.Name = "rdoTruck";
            this.rdoTruck.Size = new System.Drawing.Size(72, 17);
            this.rdoTruck.TabIndex = 4;
            this.rdoTruck.TabStop = true;
            this.rdoTruck.Text = "Caminhão";
            this.rdoTruck.UseVisualStyleBackColor = true;
            // 
            // rdoMotorcycle
            // 
            this.rdoMotorcycle.AutoSize = true;
            this.rdoMotorcycle.Location = new System.Drawing.Point(137, 16);
            this.rdoMotorcycle.Name = "rdoMotorcycle";
            this.rdoMotorcycle.Size = new System.Drawing.Size(49, 17);
            this.rdoMotorcycle.TabIndex = 3;
            this.rdoMotorcycle.TabStop = true;
            this.rdoMotorcycle.Text = "Moto";
            this.rdoMotorcycle.UseVisualStyleBackColor = true;
            // 
            // rdoCar
            // 
            this.rdoCar.AutoSize = true;
            this.rdoCar.Location = new System.Drawing.Point(80, 16);
            this.rdoCar.Name = "rdoCar";
            this.rdoCar.Size = new System.Drawing.Size(50, 17);
            this.rdoCar.TabIndex = 2;
            this.rdoCar.TabStop = true;
            this.rdoCar.Text = "Carro";
            this.rdoCar.UseVisualStyleBackColor = true;
            // 
            // lblVehiclesType
            // 
            this.lblVehiclesType.AutoSize = true;
            this.lblVehiclesType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiclesType.Location = new System.Drawing.Point(6, 17);
            this.lblVehiclesType.Name = "lblVehiclesType";
            this.lblVehiclesType.Size = new System.Drawing.Size(71, 14);
            this.lblVehiclesType.TabIndex = 1;
            this.lblVehiclesType.Text = "Veículos: ";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(120, 159);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 14);
            this.lblBrand.TabIndex = 10;
            this.lblBrand.Text = "Marca: ";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.ItemHeight = 13;
            this.cmbBrand.Location = new System.Drawing.Point(175, 156);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(213, 21);
            this.cmbBrand.TabIndex = 5;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.ItemHeight = 13;
            this.cmbModel.Location = new System.Drawing.Point(175, 193);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(213, 21);
            this.cmbModel.TabIndex = 6;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(114, 196);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(63, 14);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Modelo: ";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 13;
            this.cmbYear.Location = new System.Drawing.Point(175, 229);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(213, 21);
            this.cmbYear.TabIndex = 7;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(137, 232);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 14);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Ano: ";
            // 
            // grpDisclaimer
            // 
            this.grpDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDisclaimer.Controls.Add(this.lblTextDisclaimer);
            this.grpDisclaimer.Controls.Add(this.lblLinkApi);
            this.grpDisclaimer.Location = new System.Drawing.Point(3, 411);
            this.grpDisclaimer.Name = "grpDisclaimer";
            this.grpDisclaimer.Size = new System.Drawing.Size(208, 100);
            this.grpDisclaimer.TabIndex = 10;
            this.grpDisclaimer.TabStop = false;
            // 
            // lblTextDisclaimer
            // 
            this.lblTextDisclaimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextDisclaimer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextDisclaimer.Location = new System.Drawing.Point(3, 16);
            this.lblTextDisclaimer.Name = "lblTextDisclaimer";
            this.lblTextDisclaimer.Size = new System.Drawing.Size(200, 66);
            this.lblTextDisclaimer.TabIndex = 18;
            this.lblTextDisclaimer.Text = "Este é um projeto sem fins comerciais, e por isso, de acordo com a API pública co" +
    "nsumida, há um limite de 500 consultas por dia.";
            // 
            // lblLinkApi
            // 
            this.lblLinkApi.AutoSize = true;
            this.lblLinkApi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkApi.Location = new System.Drawing.Point(45, 80);
            this.lblLinkApi.Name = "lblLinkApi";
            this.lblLinkApi.Size = new System.Drawing.Size(103, 15);
            this.lblLinkApi.TabIndex = 10;
            this.lblLinkApi.TabStop = true;
            this.lblLinkApi.Text = "API/deividfortuna";
            this.lblLinkApi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkApi_LinkClicked);
            // 
            // tlpVehiclesInfo
            // 
            this.tlpVehiclesInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tlpVehiclesInfo.ColumnCount = 2;
            this.tlpVehiclesInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVehiclesInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVehiclesInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpPriceInfo, 1, 4);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpPrice, 0, 4);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpYearInfo, 1, 3);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpYear, 0, 3);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpBrandInfo, 1, 2);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpBrand, 0, 2);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpFipeCodeInfo, 1, 1);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpFipeCode, 0, 1);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpReferenceInfo, 1, 0);
            this.tlpVehiclesInfo.Controls.Add(this.lblTlpReference, 0, 0);
            this.tlpVehiclesInfo.Location = new System.Drawing.Point(12, 267);
            this.tlpVehiclesInfo.Name = "tlpVehiclesInfo";
            this.tlpVehiclesInfo.RowCount = 5;
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVehiclesInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVehiclesInfo.Size = new System.Drawing.Size(492, 138);
            this.tlpVehiclesInfo.TabIndex = 17;
            // 
            // lblTlpPriceInfo
            // 
            this.lblTlpPriceInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTlpPriceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpPriceInfo.Location = new System.Drawing.Point(150, 108);
            this.lblTlpPriceInfo.Name = "lblTlpPriceInfo";
            this.lblTlpPriceInfo.Size = new System.Drawing.Size(339, 30);
            this.lblTlpPriceInfo.TabIndex = 9;
            this.lblTlpPriceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTlpPrice
            // 
            this.lblTlpPrice.AutoSize = true;
            this.lblTlpPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlpPrice.Location = new System.Drawing.Point(3, 108);
            this.lblTlpPrice.Name = "lblTlpPrice";
            this.lblTlpPrice.Size = new System.Drawing.Size(141, 30);
            this.lblTlpPrice.TabIndex = 8;
            this.lblTlpPrice.Text = "Preço Médio:";
            this.lblTlpPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTlpYearInfo
            // 
            this.lblTlpYearInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTlpYearInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpYearInfo.Location = new System.Drawing.Point(150, 81);
            this.lblTlpYearInfo.Name = "lblTlpYearInfo";
            this.lblTlpYearInfo.Size = new System.Drawing.Size(339, 27);
            this.lblTlpYearInfo.TabIndex = 7;
            this.lblTlpYearInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTlpYear
            // 
            this.lblTlpYear.AutoSize = true;
            this.lblTlpYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlpYear.Location = new System.Drawing.Point(3, 81);
            this.lblTlpYear.Name = "lblTlpYear";
            this.lblTlpYear.Size = new System.Drawing.Size(141, 27);
            this.lblTlpYear.TabIndex = 6;
            this.lblTlpYear.Text = "Ano Modelo:";
            this.lblTlpYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTlpBrandInfo
            // 
            this.lblTlpBrandInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTlpBrandInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpBrandInfo.Location = new System.Drawing.Point(150, 54);
            this.lblTlpBrandInfo.Name = "lblTlpBrandInfo";
            this.lblTlpBrandInfo.Size = new System.Drawing.Size(339, 27);
            this.lblTlpBrandInfo.TabIndex = 5;
            this.lblTlpBrandInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTlpBrand
            // 
            this.lblTlpBrand.AutoSize = true;
            this.lblTlpBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpBrand.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlpBrand.Location = new System.Drawing.Point(3, 54);
            this.lblTlpBrand.Name = "lblTlpBrand";
            this.lblTlpBrand.Size = new System.Drawing.Size(141, 27);
            this.lblTlpBrand.TabIndex = 4;
            this.lblTlpBrand.Text = "Marca:";
            this.lblTlpBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTlpFipeCodeInfo
            // 
            this.lblTlpFipeCodeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTlpFipeCodeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpFipeCodeInfo.Location = new System.Drawing.Point(150, 27);
            this.lblTlpFipeCodeInfo.Name = "lblTlpFipeCodeInfo";
            this.lblTlpFipeCodeInfo.Size = new System.Drawing.Size(339, 27);
            this.lblTlpFipeCodeInfo.TabIndex = 3;
            this.lblTlpFipeCodeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTlpFipeCode
            // 
            this.lblTlpFipeCode.AutoSize = true;
            this.lblTlpFipeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpFipeCode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlpFipeCode.Location = new System.Drawing.Point(3, 27);
            this.lblTlpFipeCode.Name = "lblTlpFipeCode";
            this.lblTlpFipeCode.Size = new System.Drawing.Size(141, 27);
            this.lblTlpFipeCode.TabIndex = 2;
            this.lblTlpFipeCode.Text = "Código Fipe:";
            this.lblTlpFipeCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTlpReferenceInfo
            // 
            this.lblTlpReferenceInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTlpReferenceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpReferenceInfo.Location = new System.Drawing.Point(150, 0);
            this.lblTlpReferenceInfo.Name = "lblTlpReferenceInfo";
            this.lblTlpReferenceInfo.Size = new System.Drawing.Size(339, 27);
            this.lblTlpReferenceInfo.TabIndex = 1;
            this.lblTlpReferenceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTlpReference
            // 
            this.lblTlpReference.AutoSize = true;
            this.lblTlpReference.BackColor = System.Drawing.SystemColors.Control;
            this.lblTlpReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTlpReference.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlpReference.Location = new System.Drawing.Point(3, 0);
            this.lblTlpReference.Name = "lblTlpReference";
            this.lblTlpReference.Size = new System.Drawing.Size(141, 27);
            this.lblTlpReference.TabIndex = 0;
            this.lblTlpReference.Text = "Mês de referência:";
            this.lblTlpReference.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(395, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(425, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Favoritar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFavorites.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFavorites.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorites.Location = new System.Drawing.Point(401, 470);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(103, 31);
            this.btnFavorites.TabIndex = 18;
            this.btnFavorites.Text = "Favoritos";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 513);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlpVehiclesInfo);
            this.Controls.Add(this.grpDisclaimer);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.grpVehiclesType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlDivision);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procura de veículos";
            this.grpVehiclesType.ResumeLayout(false);
            this.grpVehiclesType.PerformLayout();
            this.grpDisclaimer.ResumeLayout(false);
            this.grpDisclaimer.PerformLayout();
            this.tlpVehiclesInfo.ResumeLayout(false);
            this.tlpVehiclesInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpVehiclesType;
        private System.Windows.Forms.Label lblVehiclesType;
        private System.Windows.Forms.RadioButton rdoTruck;
        private System.Windows.Forms.RadioButton rdoMotorcycle;
        private System.Windows.Forms.RadioButton rdoCar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox grpDisclaimer;
        private System.Windows.Forms.LinkLabel lblLinkApi;
        private System.Windows.Forms.Label lblTextDisclaimer;
        private System.Windows.Forms.TableLayoutPanel tlpVehiclesInfo;
        private System.Windows.Forms.Label lblTlpReference;
        private System.Windows.Forms.Label lblTlpPriceInfo;
        private System.Windows.Forms.Label lblTlpPrice;
        private System.Windows.Forms.Label lblTlpYearInfo;
        private System.Windows.Forms.Label lblTlpYear;
        private System.Windows.Forms.Label lblTlpBrandInfo;
        private System.Windows.Forms.Label lblTlpBrand;
        private System.Windows.Forms.Label lblTlpFipeCodeInfo;
        private System.Windows.Forms.Label lblTlpFipeCode;
        private System.Windows.Forms.Label lblTlpReferenceInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFavorites;
    }
}