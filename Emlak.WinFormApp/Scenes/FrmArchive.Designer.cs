namespace Emlak.WinFormApp.Scenes
{
    partial class FrmArchive
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgeMax = new System.Windows.Forms.NumericUpDown();
            this.txtAgeMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomMin = new System.Windows.Forms.NumericUpDown();
            this.txtRoomMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPriceMin = new System.Windows.Forms.NumericUpDown();
            this.txtPriceMax = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRentPriceMin = new System.Windows.Forms.NumericUpDown();
            this.txtRentPriceMax = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRentHouses = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSaleHouses = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtEnabled = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeMin)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomMax)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceMax)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentPriceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentPriceMax)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentHouses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHouses)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(28, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 99);
            this.panel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtAgeMax);
            this.groupBox6.Controls.Add(this.txtAgeMin);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(169, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(165, 91);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAgeMax
            // 
            this.txtAgeMax.Location = new System.Drawing.Point(94, 50);
            this.txtAgeMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtAgeMax.Name = "txtAgeMax";
            this.txtAgeMax.Size = new System.Drawing.Size(59, 24);
            this.txtAgeMax.TabIndex = 1;
            this.txtAgeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgeMax.ValueChanged += new System.EventHandler(this.txtAgeMax_ValueChanged);
            // 
            // txtAgeMin
            // 
            this.txtAgeMin.Location = new System.Drawing.Point(12, 50);
            this.txtAgeMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtAgeMin.Name = "txtAgeMin";
            this.txtAgeMin.Size = new System.Drawing.Size(59, 24);
            this.txtAgeMin.TabIndex = 0;
            this.txtAgeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAgeMin.ValueChanged += new System.EventHandler(this.txtAgeMin_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtArea);
            this.groupBox5.Controls.Add(this.txtDistrict);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(340, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 91);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bölge";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(6, 61);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(153, 24);
            this.txtArea.TabIndex = 1;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(6, 24);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(153, 24);
            this.txtDistrict.TabIndex = 0;
            this.txtDistrict.TextChanged += new System.EventHandler(this.txtDistrict_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtRoomMin);
            this.groupBox4.Controls.Add(this.txtRoomMax);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(511, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 91);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Oda Sayısı";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(93, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRoomMin
            // 
            this.txtRoomMin.Location = new System.Drawing.Point(11, 50);
            this.txtRoomMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtRoomMin.Name = "txtRoomMin";
            this.txtRoomMin.Size = new System.Drawing.Size(59, 24);
            this.txtRoomMin.TabIndex = 4;
            this.txtRoomMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoomMin.ValueChanged += new System.EventHandler(this.txtRoomMin_ValueChanged);
            // 
            // txtRoomMax
            // 
            this.txtRoomMax.Location = new System.Drawing.Point(93, 50);
            this.txtRoomMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtRoomMax.Name = "txtRoomMax";
            this.txtRoomMax.Size = new System.Drawing.Size(59, 24);
            this.txtRoomMax.TabIndex = 5;
            this.txtRoomMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoomMax.ValueChanged += new System.EventHandler(this.txtRoomMax_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(682, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ev Tipi";
            // 
            // txtType
            // 
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FormattingEnabled = true;
            this.txtType.Location = new System.Drawing.Point(6, 45);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(153, 27);
            this.txtType.TabIndex = 0;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPriceMin);
            this.groupBox2.Controls.Add(this.txtPriceMax);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1024, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 91);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emlak Değeri";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(100, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Max";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Min";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPriceMin
            // 
            this.txtPriceMin.Location = new System.Drawing.Point(18, 50);
            this.txtPriceMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPriceMin.Name = "txtPriceMin";
            this.txtPriceMin.Size = new System.Drawing.Size(59, 24);
            this.txtPriceMin.TabIndex = 13;
            this.txtPriceMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceMin.ValueChanged += new System.EventHandler(this.txtPriceMin_ValueChanged);
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Location = new System.Drawing.Point(100, 50);
            this.txtPriceMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.Size = new System.Drawing.Size(59, 24);
            this.txtPriceMax.TabIndex = 14;
            this.txtPriceMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceMax.ValueChanged += new System.EventHandler(this.txtPriceMax_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRentPriceMin);
            this.groupBox1.Controls.Add(this.txtRentPriceMax);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(853, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kira Ücreti";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(100, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Min";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRentPriceMin
            // 
            this.txtRentPriceMin.Location = new System.Drawing.Point(18, 50);
            this.txtRentPriceMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtRentPriceMin.Name = "txtRentPriceMin";
            this.txtRentPriceMin.Size = new System.Drawing.Size(59, 24);
            this.txtRentPriceMin.TabIndex = 9;
            this.txtRentPriceMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRentPriceMin.ValueChanged += new System.EventHandler(this.txtRentPriceMin_ValueChanged);
            // 
            // txtRentPriceMax
            // 
            this.txtRentPriceMax.Location = new System.Drawing.Point(100, 50);
            this.txtRentPriceMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtRentPriceMax.Name = "txtRentPriceMax";
            this.txtRentPriceMax.Size = new System.Drawing.Size(59, 24);
            this.txtRentPriceMax.TabIndex = 10;
            this.txtRentPriceMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRentPriceMax.ValueChanged += new System.EventHandler(this.txtRentPriceMax_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(28, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 427);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1192, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRentHouses);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1184, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kiralık Evler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRentHouses
            // 
            this.dgvRentHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentHouses.Location = new System.Drawing.Point(3, 3);
            this.dgvRentHouses.Name = "dgvRentHouses";
            this.dgvRentHouses.RowTemplate.Height = 24;
            this.dgvRentHouses.Size = new System.Drawing.Size(1178, 383);
            this.dgvRentHouses.TabIndex = 0;
            this.dgvRentHouses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentHouses_CellClick);
            this.dgvRentHouses.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentHouses_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSaleHouses);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1184, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Satılık Evler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSaleHouses
            // 
            this.dgvSaleHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleHouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleHouses.Location = new System.Drawing.Point(3, 3);
            this.dgvSaleHouses.Name = "dgvSaleHouses";
            this.dgvSaleHouses.RowTemplate.Height = 24;
            this.dgvSaleHouses.Size = new System.Drawing.Size(1178, 383);
            this.dgvSaleHouses.TabIndex = 0;
            this.dgvSaleHouses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleHouses_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(28, 633);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(246, 55);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Geriye Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtEnabled);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(33, 78);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(159, 91);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Aktif Mi ?";
            // 
            // txtEnabled
            // 
            this.txtEnabled.Location = new System.Drawing.Point(6, 41);
            this.txtEnabled.Name = "txtEnabled";
            this.txtEnabled.Size = new System.Drawing.Size(147, 21);
            this.txtEnabled.TabIndex = 0;
            this.txtEnabled.Text = "Aktif";
            this.txtEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtEnabled.UseVisualStyleBackColor = true;
            this.txtEnabled.CheckedChanged += new System.EventHandler(this.txtEnabled_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(976, 633);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(246, 55);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Aramayı Sıfırla";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArchive";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.Text = "Emlak Otomasyonu";
            this.Activated += new System.EventHandler(this.FrmArchive_Activated);
            this.Load += new System.EventHandler(this.FrmArchive_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeMin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomMax)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceMax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRentPriceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentPriceMax)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentHouses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleHouses)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvRentHouses;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSaleHouses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox txtEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtAgeMax;
        private System.Windows.Forms.NumericUpDown txtAgeMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtRoomMin;
        private System.Windows.Forms.NumericUpDown txtRoomMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtPriceMin;
        private System.Windows.Forms.NumericUpDown txtPriceMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtRentPriceMin;
        private System.Windows.Forms.NumericUpDown txtRentPriceMax;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Button btnReset;
    }
}