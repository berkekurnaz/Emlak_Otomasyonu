using Emlak.DataAccess.Abstract;
using Emlak.DataAccess.Concrete.TextDb;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.WinFormApp.Scenes
{
    public partial class FrmStatistics : MetroForm
    {

        IRentHouseDal rentHouseOperations;
        ISaleHouseDal saleHouseOperations;

        public FrmStatistics()
        {
            InitializeComponent();
            string document_path = Application.StartupPath + "/renthouse.txt";
            string document_path2 = Application.StartupPath + "/salehouse.txt";
            rentHouseOperations = new TDRentHouseDal(document_path);
            saleHouseOperations = new TDSaleHouseDal(document_path2);
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            CreateChartForTypes();
            CreateChartForHouseCount();

            WriteRentHousesStatistics();
            WriteSaleHousesStatistics();
        }

        void WriteRentHousesStatistics()
        {
            lblRentTotalHouseCount.Text = rentHouseOperations.GetAll().Count.ToString();
            lblRentAverageAge.Text = rentHouseOperations.GetAll().Average(x => x.Age).ToString();
            lblRentAverageRoomCount.Text = rentHouseOperations.GetAll().Average(x => x.RoomCount).ToString();
            lblRentAveragePrice.Text = rentHouseOperations.GetAll().Average(x => x.RentPrice).ToString();
            lblRentAverageDeposit.Text = rentHouseOperations.GetAll().Average(x => x.RentDeposit).ToString();
        }

        void WriteSaleHousesStatistics()
        {
            lblSaleTotalHouseCount.Text = saleHouseOperations.GetAll().Count.ToString();
            lblSaleAverageAge.Text = saleHouseOperations.GetAll().Average(x => x.Age).ToString();
            lblSaleAverageRoomCount.Text = saleHouseOperations.GetAll().Average(x => x.RoomCount).ToString();
            lblSaleAveragePrice.Text = saleHouseOperations.GetAll().Average(x => x.SalePrice).ToString();
        }

        void CreateChartForHouseCount()
        {
            int sayi1, sayi2, sayi3;

            sayi1 = rentHouseOperations.GetAll().Count() + saleHouseOperations.GetAll().Count();
            sayi2 = rentHouseOperations.GetAll().Count();
            sayi3 = saleHouseOperations.GetAll().Count();

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            chart2.Series["Evler"].Points.Add(sayi1);
            chart2.Series["Evler"].Points.Add(sayi2);
            chart2.Series["Evler"].Points.Add(sayi3);

            chart2.Series["Evler"].Points[0].AxisLabel = "Toplam Ev";
            chart2.Series["Evler"].Points[1].AxisLabel = "Kiralık Ev";
            chart2.Series["Evler"].Points[2].AxisLabel = "Satılık Ev";

            chart2.Series["Evler"].Points[0].Color = Color.Aqua;
            chart2.Series["Evler"].Points[1].Color = Color.Chocolate;
            chart2.Series["Evler"].Points[2].Color = Color.Orange;

            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
            chart2.BackColor = Color.YellowGreen;
        }

        void CreateChartForTypes()
        {
            int sayi1, sayi2, sayi3, sayi4;

            sayi1 = rentHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.Apartment).Count() + saleHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.Apartment).Count();
            sayi2 = rentHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.GardenHouse).Count() + saleHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.GardenHouse).Count();
            sayi3 = rentHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.Dublex).Count() + saleHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.Dublex).Count();
            sayi4 = rentHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.Seperate).Count() + saleHouseOperations.GetAll().Where(x => x.Type == Models.House.Types.Seperate).Count();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.Series["Evler"].Points.Add(sayi1);
            chart1.Series["Evler"].Points.Add(sayi2);
            chart1.Series["Evler"].Points.Add(sayi3);
            chart1.Series["Evler"].Points.Add(sayi4);

            chart1.Series["Evler"].Points[0].AxisLabel = "Apartman";
            chart1.Series["Evler"].Points[1].AxisLabel = "Bahçeli";
            chart1.Series["Evler"].Points[2].AxisLabel = "Dubleks";
            chart1.Series["Evler"].Points[3].AxisLabel = "Müstakil";

            chart1.Series["Evler"].Points[0].Color = Color.Aqua;
            chart1.Series["Evler"].Points[1].Color = Color.Chocolate;
            chart1.Series["Evler"].Points[2].Color = Color.Orange;
            chart1.Series["Evler"].Points[3].Color = Color.RoyalBlue;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
            chart1.BackColor = Color.YellowGreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
