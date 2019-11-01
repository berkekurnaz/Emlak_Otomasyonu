namespace Emlak.WinFormApp.Scenes
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvRentHouses = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSaleHouses = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGoStatistics = new System.Windows.Forms.Button();
            this.btnGoArchive = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRentDeposit = new System.Windows.Forms.NumericUpDown();
            this.txtRentPrice = new System.Windows.Forms.NumericUpDown();
            this.txtRentEnabled = new System.Windows.Forms.CheckBox();
            this.txtRentCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.txtRentType = new System.Windows.Forms.ComboBox();
            this.txtRentFloorNumber = new System.Windows.Forms.NumericUpDown();
            this.txtRentRoomCount = new System.Windows.Forms.NumericUpDown();
            this.txtRentArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRentDistrict = new System.Windows.Forms.TextBox();
            this.btnAddRent = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearRent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSalePrice = new System.Windows.Forms.NumericUpDown();
            this.txtSaleEnabled = new System.Windows.Forms.CheckBox();
            this.txtSaleCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.txtSaleType = new System.Windows.Forms.ComboBox();
            this.txtSaleFloorNumber = new System.Windows.Forms.NumericUpDown();
            this.txtSaleRoomCount = new System.Windows.Forms.NumericUpDown();
            this.txtSaleArea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSaleDistrict = new System.Windows.Forms.TextBox();
            this.btnSaleAdd = new System.Windows.Forms.Button();
            this.btnSaleUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaleDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSaleClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSaleId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentHouses)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHouses)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentFloorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentRoomCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleFloorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRoomCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Location = new System.Drawing.Point(23, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 495);
            this.panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(769, 493);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRentHouses);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 457);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Kiralık Evler Listesi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvRentHouses
            // 
            this.dgvRentHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentHouses.Location = new System.Drawing.Point(3, 3);
            this.dgvRentHouses.Name = "dgvRentHouses";
            this.dgvRentHouses.RowTemplate.Height = 24;
            this.dgvRentHouses.Size = new System.Drawing.Size(755, 451);
            this.dgvRentHouses.TabIndex = 0;
            this.dgvRentHouses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentHouses_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvSaleHouses);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(761, 457);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Satılık Evler Listesi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSaleHouses
            // 
            this.dgvSaleHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleHouses.Location = new System.Drawing.Point(3, 3);
            this.dgvSaleHouses.Name = "dgvSaleHouses";
            this.dgvSaleHouses.RowTemplate.Height = 24;
            this.dgvSaleHouses.Size = new System.Drawing.Size(755, 451);
            this.dgvSaleHouses.TabIndex = 0;
            this.dgvSaleHouses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleHouses_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(23, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 99);
            this.panel2.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(268, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 23);
            this.lblUser.TabIndex = 22;
            this.lblUser.Text = "0000";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(510, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 23);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "00.00.0000";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(518, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 46);
            this.label24.TabIndex = 20;
            this.label24.Text = "Tarih\r\n----------";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(649, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 23);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(649, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 46);
            this.label21.TabIndex = 18;
            this.label21.Text = "Saat\r\n----------";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Sisteme Giriş Yapan Kullanıcı : ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGoStatistics);
            this.panel3.Controls.Add(this.btnGoArchive);
            this.panel3.Location = new System.Drawing.Point(848, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 99);
            this.panel3.TabIndex = 2;
            // 
            // btnGoStatistics
            // 
            this.btnGoStatistics.Location = new System.Drawing.Point(20, 53);
            this.btnGoStatistics.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnGoStatistics.Name = "btnGoStatistics";
            this.btnGoStatistics.Size = new System.Drawing.Size(341, 41);
            this.btnGoStatistics.TabIndex = 1;
            this.btnGoStatistics.Text = "İstatistikler Sayfası";
            this.btnGoStatistics.UseVisualStyleBackColor = true;
            this.btnGoStatistics.Click += new System.EventHandler(this.btnGoStatistics_Click);
            // 
            // btnGoArchive
            // 
            this.btnGoArchive.Location = new System.Drawing.Point(20, 5);
            this.btnGoArchive.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnGoArchive.Name = "btnGoArchive";
            this.btnGoArchive.Size = new System.Drawing.Size(341, 41);
            this.btnGoArchive.TabIndex = 0;
            this.btnGoArchive.Text = "Gelişmiş Arama Sayfası";
            this.btnGoArchive.UseVisualStyleBackColor = true;
            this.btnGoArchive.Click += new System.EventHandler(this.btnGoArchive_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Location = new System.Drawing.Point(848, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 495);
            this.panel4.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRentDeposit);
            this.tabPage1.Controls.Add(this.txtRentPrice);
            this.tabPage1.Controls.Add(this.txtRentEnabled);
            this.tabPage1.Controls.Add(this.txtRentCreatedDate);
            this.tabPage1.Controls.Add(this.txtRentType);
            this.tabPage1.Controls.Add(this.txtRentFloorNumber);
            this.tabPage1.Controls.Add(this.txtRentRoomCount);
            this.tabPage1.Controls.Add(this.txtRentArea);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtRentDistrict);
            this.tabPage1.Controls.Add(this.btnAddRent);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnUpdateRent);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnDeleteRent);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnClearRent);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtRentId);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kiralık Ev";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRentDeposit
            // 
            this.txtRentDeposit.Location = new System.Drawing.Point(145, 278);
            this.txtRentDeposit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtRentDeposit.Name = "txtRentDeposit";
            this.txtRentDeposit.Size = new System.Drawing.Size(220, 29);
            this.txtRentDeposit.TabIndex = 9;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(147, 248);
            this.txtRentPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(220, 29);
            this.txtRentPrice.TabIndex = 8;
            // 
            // txtRentEnabled
            // 
            this.txtRentEnabled.AutoSize = true;
            this.txtRentEnabled.Location = new System.Drawing.Point(147, 219);
            this.txtRentEnabled.Name = "txtRentEnabled";
            this.txtRentEnabled.Size = new System.Drawing.Size(89, 27);
            this.txtRentEnabled.TabIndex = 7;
            this.txtRentEnabled.Text = "Aktiflik";
            this.txtRentEnabled.UseVisualStyleBackColor = true;
            // 
            // txtRentCreatedDate
            // 
            this.txtRentCreatedDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRentCreatedDate.Location = new System.Drawing.Point(148, 157);
            this.txtRentCreatedDate.Name = "txtRentCreatedDate";
            this.txtRentCreatedDate.Size = new System.Drawing.Size(216, 27);
            this.txtRentCreatedDate.TabIndex = 5;
            // 
            // txtRentType
            // 
            this.txtRentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRentType.FormattingEnabled = true;
            this.txtRentType.Location = new System.Drawing.Point(147, 187);
            this.txtRentType.Name = "txtRentType";
            this.txtRentType.Size = new System.Drawing.Size(217, 31);
            this.txtRentType.TabIndex = 6;
            // 
            // txtRentFloorNumber
            // 
            this.txtRentFloorNumber.Location = new System.Drawing.Point(148, 68);
            this.txtRentFloorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtRentFloorNumber.Name = "txtRentFloorNumber";
            this.txtRentFloorNumber.Size = new System.Drawing.Size(220, 29);
            this.txtRentFloorNumber.TabIndex = 2;
            // 
            // txtRentRoomCount
            // 
            this.txtRentRoomCount.Location = new System.Drawing.Point(147, 38);
            this.txtRentRoomCount.Name = "txtRentRoomCount";
            this.txtRentRoomCount.Size = new System.Drawing.Size(220, 29);
            this.txtRentRoomCount.TabIndex = 1;
            // 
            // txtRentArea
            // 
            this.txtRentArea.Location = new System.Drawing.Point(147, 127);
            this.txtRentArea.Name = "txtRentArea";
            this.txtRentArea.Size = new System.Drawing.Size(217, 29);
            this.txtRentArea.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda Sayısı :";
            // 
            // txtRentDistrict
            // 
            this.txtRentDistrict.Location = new System.Drawing.Point(147, 97);
            this.txtRentDistrict.Name = "txtRentDistrict";
            this.txtRentDistrict.Size = new System.Drawing.Size(217, 29);
            this.txtRentDistrict.TabIndex = 3;
            // 
            // btnAddRent
            // 
            this.btnAddRent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddRent.Location = new System.Drawing.Point(29, 339);
            this.btnAddRent.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnAddRent.Name = "btnAddRent";
            this.btnAddRent.Size = new System.Drawing.Size(146, 49);
            this.btnAddRent.TabIndex = 10;
            this.btnAddRent.Text = "Yeni Ekle";
            this.btnAddRent.UseVisualStyleBackColor = false;
            this.btnAddRent.Click += new System.EventHandler(this.btnAddRent_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Depozito :";
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRent.Location = new System.Drawing.Point(208, 339);
            this.btnUpdateRent.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(146, 49);
            this.btnUpdateRent.TabIndex = 11;
            this.btnUpdateRent.Text = "Güncelle";
            this.btnUpdateRent.UseVisualStyleBackColor = true;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateRent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kira :";
            // 
            // btnDeleteRent
            // 
            this.btnDeleteRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRent.Location = new System.Drawing.Point(29, 396);
            this.btnDeleteRent.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(146, 49);
            this.btnDeleteRent.TabIndex = 12;
            this.btnDeleteRent.Text = "Sil";
            this.btnDeleteRent.UseVisualStyleBackColor = true;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Aktif Mi :";
            // 
            // btnClearRent
            // 
            this.btnClearRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRent.Location = new System.Drawing.Point(208, 396);
            this.btnClearRent.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnClearRent.Name = "btnClearRent";
            this.btnClearRent.Size = new System.Drawing.Size(146, 49);
            this.btnClearRent.TabIndex = 13;
            this.btnClearRent.Text = "Temizle";
            this.btnClearRent.UseVisualStyleBackColor = true;
            this.btnClearRent.Click += new System.EventHandler(this.btnClearRent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yapım Tarihi :";
            // 
            // txtRentId
            // 
            this.txtRentId.Enabled = false;
            this.txtRentId.Location = new System.Drawing.Point(148, 7);
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(217, 29);
            this.txtRentId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kat Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Semt :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSalePrice);
            this.tabPage2.Controls.Add(this.txtSaleEnabled);
            this.tabPage2.Controls.Add(this.txtSaleCreatedDate);
            this.tabPage2.Controls.Add(this.txtSaleType);
            this.tabPage2.Controls.Add(this.txtSaleFloorNumber);
            this.tabPage2.Controls.Add(this.txtSaleRoomCount);
            this.tabPage2.Controls.Add(this.txtSaleArea);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtSaleDistrict);
            this.tabPage2.Controls.Add(this.btnSaleAdd);
            this.tabPage2.Controls.Add(this.btnSaleUpdate);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnSaleDelete);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnSaleClear);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtSaleId);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Satılık Ev";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(149, 247);
            this.txtSalePrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(220, 29);
            this.txtSalePrice.TabIndex = 26;
            // 
            // txtSaleEnabled
            // 
            this.txtSaleEnabled.AutoSize = true;
            this.txtSaleEnabled.Location = new System.Drawing.Point(149, 218);
            this.txtSaleEnabled.Name = "txtSaleEnabled";
            this.txtSaleEnabled.Size = new System.Drawing.Size(89, 27);
            this.txtSaleEnabled.TabIndex = 25;
            this.txtSaleEnabled.Text = "Aktiflik";
            this.txtSaleEnabled.UseVisualStyleBackColor = true;
            // 
            // txtSaleCreatedDate
            // 
            this.txtSaleCreatedDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaleCreatedDate.Location = new System.Drawing.Point(150, 156);
            this.txtSaleCreatedDate.Name = "txtSaleCreatedDate";
            this.txtSaleCreatedDate.Size = new System.Drawing.Size(216, 27);
            this.txtSaleCreatedDate.TabIndex = 22;
            // 
            // txtSaleType
            // 
            this.txtSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSaleType.FormattingEnabled = true;
            this.txtSaleType.Location = new System.Drawing.Point(149, 186);
            this.txtSaleType.Name = "txtSaleType";
            this.txtSaleType.Size = new System.Drawing.Size(217, 31);
            this.txtSaleType.TabIndex = 23;
            // 
            // txtSaleFloorNumber
            // 
            this.txtSaleFloorNumber.Location = new System.Drawing.Point(150, 67);
            this.txtSaleFloorNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSaleFloorNumber.Name = "txtSaleFloorNumber";
            this.txtSaleFloorNumber.Size = new System.Drawing.Size(220, 29);
            this.txtSaleFloorNumber.TabIndex = 19;
            // 
            // txtSaleRoomCount
            // 
            this.txtSaleRoomCount.Location = new System.Drawing.Point(149, 37);
            this.txtSaleRoomCount.Name = "txtSaleRoomCount";
            this.txtSaleRoomCount.Size = new System.Drawing.Size(220, 29);
            this.txtSaleRoomCount.TabIndex = 18;
            // 
            // txtSaleArea
            // 
            this.txtSaleArea.Location = new System.Drawing.Point(149, 126);
            this.txtSaleArea.Name = "txtSaleArea";
            this.txtSaleArea.Size = new System.Drawing.Size(217, 29);
            this.txtSaleArea.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Oda Sayısı :";
            // 
            // txtSaleDistrict
            // 
            this.txtSaleDistrict.Location = new System.Drawing.Point(149, 96);
            this.txtSaleDistrict.Name = "txtSaleDistrict";
            this.txtSaleDistrict.Size = new System.Drawing.Size(217, 29);
            this.txtSaleDistrict.TabIndex = 20;
            // 
            // btnSaleAdd
            // 
            this.btnSaleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleAdd.Location = new System.Drawing.Point(31, 338);
            this.btnSaleAdd.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnSaleAdd.Name = "btnSaleAdd";
            this.btnSaleAdd.Size = new System.Drawing.Size(146, 49);
            this.btnSaleAdd.TabIndex = 31;
            this.btnSaleAdd.Text = "Yeni Ekle";
            this.btnSaleAdd.UseVisualStyleBackColor = true;
            this.btnSaleAdd.Click += new System.EventHandler(this.btnSaleAdd_Click);
            // 
            // btnSaleUpdate
            // 
            this.btnSaleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleUpdate.Location = new System.Drawing.Point(210, 338);
            this.btnSaleUpdate.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnSaleUpdate.Name = "btnSaleUpdate";
            this.btnSaleUpdate.Size = new System.Drawing.Size(146, 49);
            this.btnSaleUpdate.TabIndex = 32;
            this.btnSaleUpdate.Text = "Güncelle";
            this.btnSaleUpdate.UseVisualStyleBackColor = true;
            this.btnSaleUpdate.Click += new System.EventHandler(this.btnSaleUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 39;
            this.label13.Text = "Değer :";
            // 
            // btnSaleDelete
            // 
            this.btnSaleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleDelete.Location = new System.Drawing.Point(31, 395);
            this.btnSaleDelete.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnSaleDelete.Name = "btnSaleDelete";
            this.btnSaleDelete.Size = new System.Drawing.Size(146, 49);
            this.btnSaleDelete.TabIndex = 34;
            this.btnSaleDelete.Text = "Sil";
            this.btnSaleDelete.UseVisualStyleBackColor = true;
            this.btnSaleDelete.Click += new System.EventHandler(this.btnSaleDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 23);
            this.label14.TabIndex = 38;
            this.label14.Text = "Aktif Mi :";
            // 
            // btnSaleClear
            // 
            this.btnSaleClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleClear.Location = new System.Drawing.Point(210, 395);
            this.btnSaleClear.Margin = new System.Windows.Forms.Padding(20, 10, 20, 3);
            this.btnSaleClear.Name = "btnSaleClear";
            this.btnSaleClear.Size = new System.Drawing.Size(146, 49);
            this.btnSaleClear.TabIndex = 36;
            this.btnSaleClear.Text = "Temizle";
            this.btnSaleClear.UseVisualStyleBackColor = true;
            this.btnSaleClear.Click += new System.EventHandler(this.btnSaleClear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 23);
            this.label15.TabIndex = 37;
            this.label15.Text = "Tipi :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(109, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 23);
            this.label16.TabIndex = 24;
            this.label16.Text = "Id :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "Yapım Tarihi :";
            // 
            // txtSaleId
            // 
            this.txtSaleId.Enabled = false;
            this.txtSaleId.Location = new System.Drawing.Point(150, 6);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.Size = new System.Drawing.Size(217, 29);
            this.txtSaleId.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(89, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 23);
            this.label18.TabIndex = 33;
            this.label18.Text = "Alan :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 23);
            this.label19.TabIndex = 29;
            this.label19.Text = "Kat Numarası :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(83, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 23);
            this.label20.TabIndex = 30;
            this.label20.Text = "Semt :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Emlak Otomasyonu";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentHouses)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHouses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentFloorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentRoomCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleFloorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleRoomCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGoStatistics;
        private System.Windows.Forms.Button btnGoArchive;
        private System.Windows.Forms.Button btnClearRent;
        private System.Windows.Forms.Button btnDeleteRent;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.Button btnAddRent;
        private System.Windows.Forms.TextBox txtRentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtRentArea;
        private System.Windows.Forms.TextBox txtRentDistrict;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown txtRentFloorNumber;
        private System.Windows.Forms.NumericUpDown txtRentRoomCount;
        private System.Windows.Forms.ComboBox txtRentType;
        private System.Windows.Forms.CheckBox txtRentEnabled;
        private System.Windows.Forms.DateTimePicker txtRentCreatedDate;
        private System.Windows.Forms.NumericUpDown txtRentDeposit;
        private System.Windows.Forms.NumericUpDown txtRentPrice;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvRentHouses;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvSaleHouses;
        private System.Windows.Forms.NumericUpDown txtSalePrice;
        private System.Windows.Forms.CheckBox txtSaleEnabled;
        private System.Windows.Forms.DateTimePicker txtSaleCreatedDate;
        private System.Windows.Forms.ComboBox txtSaleType;
        private System.Windows.Forms.NumericUpDown txtSaleFloorNumber;
        private System.Windows.Forms.NumericUpDown txtSaleRoomCount;
        private System.Windows.Forms.TextBox txtSaleArea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSaleDistrict;
        private System.Windows.Forms.Button btnSaleAdd;
        private System.Windows.Forms.Button btnSaleUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaleDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSaleClear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Timer timer1;
    }
}