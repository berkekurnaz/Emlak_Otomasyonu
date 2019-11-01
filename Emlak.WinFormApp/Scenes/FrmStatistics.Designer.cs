namespace Emlak.WinFormApp.Scenes
{
    partial class FrmStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRentAverageDeposit = new System.Windows.Forms.Label();
            this.lblRentAveragePrice = new System.Windows.Forms.Label();
            this.lblRentAverageAge = new System.Windows.Forms.Label();
            this.lblRentAverageRoomCount = new System.Windows.Forms.Label();
            this.lblRentTotalHouseCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSaleAveragePrice = new System.Windows.Forms.Label();
            this.lblSaleAverageAge = new System.Windows.Forms.Label();
            this.lblSaleAverageRoomCount = new System.Windows.Forms.Label();
            this.lblSaleTotalHouseCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(658, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 285);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Evler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(556, 277);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Location = new System.Drawing.Point(658, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 285);
            this.panel2.TabIndex = 1;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Evler";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(556, 277);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(28, 572);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 100);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(6, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(272, 58);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Menüye Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(28, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(593, 196);
            this.panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblRentAverageDeposit);
            this.groupBox2.Controls.Add(this.lblRentAveragePrice);
            this.groupBox2.Controls.Add(this.lblRentAverageAge);
            this.groupBox2.Controls.Add(this.lblRentAverageRoomCount);
            this.groupBox2.Controls.Add(this.lblRentTotalHouseCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 188);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralık Emlak İstatistikleri";
            // 
            // lblRentAverageDeposit
            // 
            this.lblRentAverageDeposit.AutoSize = true;
            this.lblRentAverageDeposit.Location = new System.Drawing.Point(478, 94);
            this.lblRentAverageDeposit.Name = "lblRentAverageDeposit";
            this.lblRentAverageDeposit.Size = new System.Drawing.Size(28, 23);
            this.lblRentAverageDeposit.TabIndex = 9;
            this.lblRentAverageDeposit.Text = "xx";
            // 
            // lblRentAveragePrice
            // 
            this.lblRentAveragePrice.AutoSize = true;
            this.lblRentAveragePrice.Location = new System.Drawing.Point(478, 52);
            this.lblRentAveragePrice.Name = "lblRentAveragePrice";
            this.lblRentAveragePrice.Size = new System.Drawing.Size(28, 23);
            this.lblRentAveragePrice.TabIndex = 8;
            this.lblRentAveragePrice.Text = "xx";
            // 
            // lblRentAverageAge
            // 
            this.lblRentAverageAge.AutoSize = true;
            this.lblRentAverageAge.Location = new System.Drawing.Point(200, 138);
            this.lblRentAverageAge.Name = "lblRentAverageAge";
            this.lblRentAverageAge.Size = new System.Drawing.Size(28, 23);
            this.lblRentAverageAge.TabIndex = 7;
            this.lblRentAverageAge.Text = "xx";
            // 
            // lblRentAverageRoomCount
            // 
            this.lblRentAverageRoomCount.AutoSize = true;
            this.lblRentAverageRoomCount.Location = new System.Drawing.Point(200, 94);
            this.lblRentAverageRoomCount.Name = "lblRentAverageRoomCount";
            this.lblRentAverageRoomCount.Size = new System.Drawing.Size(28, 23);
            this.lblRentAverageRoomCount.TabIndex = 6;
            this.lblRentAverageRoomCount.Text = "xx";
            // 
            // lblRentTotalHouseCount
            // 
            this.lblRentTotalHouseCount.AutoSize = true;
            this.lblRentTotalHouseCount.Location = new System.Drawing.Point(200, 52);
            this.lblRentTotalHouseCount.Name = "lblRentTotalHouseCount";
            this.lblRentTotalHouseCount.Size = new System.Drawing.Size(28, 23);
            this.lblRentTotalHouseCount.TabIndex = 5;
            this.lblRentTotalHouseCount.Text = "xx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ortalama Depozito : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ortalama Kira : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ortalama Yaş : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ortalama Oda Sayısı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kiralık Ev : ";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(28, 334);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(593, 196);
            this.panel5.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lblSaleAveragePrice);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblSaleAverageAge);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblSaleAverageRoomCount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblSaleTotalHouseCount);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 188);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satılık Emlak İstatistikleri";
            // 
            // lblSaleAveragePrice
            // 
            this.lblSaleAveragePrice.AutoSize = true;
            this.lblSaleAveragePrice.Location = new System.Drawing.Point(478, 53);
            this.lblSaleAveragePrice.Name = "lblSaleAveragePrice";
            this.lblSaleAveragePrice.Size = new System.Drawing.Size(28, 23);
            this.lblSaleAveragePrice.TabIndex = 18;
            this.lblSaleAveragePrice.Text = "xx";
            // 
            // lblSaleAverageAge
            // 
            this.lblSaleAverageAge.AutoSize = true;
            this.lblSaleAverageAge.Location = new System.Drawing.Point(200, 139);
            this.lblSaleAverageAge.Name = "lblSaleAverageAge";
            this.lblSaleAverageAge.Size = new System.Drawing.Size(28, 23);
            this.lblSaleAverageAge.TabIndex = 17;
            this.lblSaleAverageAge.Text = "xx";
            // 
            // lblSaleAverageRoomCount
            // 
            this.lblSaleAverageRoomCount.AutoSize = true;
            this.lblSaleAverageRoomCount.Location = new System.Drawing.Point(200, 95);
            this.lblSaleAverageRoomCount.Name = "lblSaleAverageRoomCount";
            this.lblSaleAverageRoomCount.Size = new System.Drawing.Size(28, 23);
            this.lblSaleAverageRoomCount.TabIndex = 16;
            this.lblSaleAverageRoomCount.Text = "xx";
            // 
            // lblSaleTotalHouseCount
            // 
            this.lblSaleTotalHouseCount.AutoSize = true;
            this.lblSaleTotalHouseCount.Location = new System.Drawing.Point(200, 53);
            this.lblSaleTotalHouseCount.Name = "lblSaleTotalHouseCount";
            this.lblSaleTotalHouseCount.Size = new System.Drawing.Size(28, 23);
            this.lblSaleTotalHouseCount.TabIndex = 15;
            this.lblSaleTotalHouseCount.Text = "xx";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Ortalama Değer : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ortalama Yaş : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ortalama Oda Sayısı : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 23);
            this.label15.TabIndex = 10;
            this.label15.Text = "Toplam Satılık Ev : ";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStatistics";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRentAverageDeposit;
        private System.Windows.Forms.Label lblRentAveragePrice;
        private System.Windows.Forms.Label lblRentAverageAge;
        private System.Windows.Forms.Label lblRentAverageRoomCount;
        private System.Windows.Forms.Label lblRentTotalHouseCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSaleAveragePrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSaleAverageAge;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSaleAverageRoomCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSaleTotalHouseCount;
    }
}