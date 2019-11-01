using Emlak.DataAccess.Abstract;
using Emlak.DataAccess.Concrete.TextDb;
using Emlak.DataAccess.Helpers;
using Emlak.Models;
using Emlak.WinFormApp.Helpers;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.WinFormApp.Scenes
{
    public partial class FrmMain : MetroForm
    {

        IRentHouseDal rentHouseOperations;
        ISaleHouseDal saleHouseOperations;

        public FrmMain()
        {
            InitializeComponent();
            string document_path = Application.StartupPath + "/renthouse.txt";
            string document_path2 = Application.StartupPath + "/salehouse.txt";
            rentHouseOperations = new TDRentHouseDal(document_path);
            saleHouseOperations = new TDSaleHouseDal(document_path2);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvRentHouses.Columns.Add(btn);
            btn.HeaderText = "Resimler";
            btn.Text = "Resimler";
            btn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dgvSaleHouses.Columns.Add(btn1);
            btn1.HeaderText = "Resimler";
            btn1.Text = "Resimler";
            btn1.UseColumnTextForButtonValue = true;

            var singletonUser = SingletonUser.CreateAsSingleton();
            lblUser.Text = singletonUser.ReadUsername();
        }



        /* Uygulama Calıştığında Çalışacak Kodlar */
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();

            FillRentHouseList();
            FillSaleHouseList();

            FillHouseTypesInComboboxes();
        }



        /* Kiralik Butun Evleri Listeleme */
        void FillRentHouseList()
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.IsEnabled == true).ToList();
        }

        /* Satilik Butun Evleri Listeleme */
        void FillSaleHouseList()
        {
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.IsEnabled == true).ToList();
        }

        /* Combobox İçerisine Ev Tiplerini Yazdırma */
        void FillHouseTypesInComboboxes()
        {
            foreach (var item in Enum.GetValues(typeof(House.Types)))
            {
                txtRentType.Items.Add(item);
                txtSaleType.Items.Add(item);
            }
            txtRentType.SelectedIndex = 0;
            txtSaleType.SelectedIndex = 0;
        }



        /* Yeni Kiralik Ev Ekleme */
        private void btnAddRent_Click(object sender, EventArgs e)
        {
            if (txtRentDistrict.Text.Length > 0 && txtRentArea.Text.Length > 0)
            {
                var dialogWindow = MessageBox.Show("Yeni Kiralık Ev Eklemek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    RentHouse rentHouse = new RentHouse();
                    rentHouse.Id = GeneratorId.GenerateId();
                    rentHouse.RoomCount = Convert.ToInt32(txtRentRoomCount.Value);
                    rentHouse.FloorNumber = Convert.ToInt32(txtRentFloorNumber.Value);
                    rentHouse.District = txtRentDistrict.Text;
                    rentHouse.Area = txtRentArea.Text;
                    rentHouse.CreateDate = Convert.ToDateTime(txtRentCreatedDate.Text);
                    rentHouse.Type = ConvertHouseType.GetHouseType(txtRentType.Text);
                    rentHouse.IsEnabled = Convert.ToBoolean(txtRentEnabled.Checked);
                    rentHouse.RentPrice = Convert.ToDecimal(txtRentPrice.Value);
                    rentHouse.RentDeposit = Convert.ToDecimal(txtRentDeposit.Value);

                    string path = Application.StartupPath + "/HouseImages/RentHouses/";
                    GeneratorFolder generatorFolder = new GeneratorFolder();
                    generatorFolder.CreateFolder(path, rentHouse.Id);

                    rentHouseOperations.Add(rentHouse);
                    MessageBox.Show("Yeni Kiralık Ev Eklendi");
                    FillRentHouseList();
                }
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz.");
            }
        }

        /* Kiralık Ev Güncelleme */
        private void btnUpdateRent_Click(object sender, EventArgs e)
        {
            if (txtRentId.Text.Length > 0)
            {
                var dialogWindow = MessageBox.Show("Kiralık Ev Güncellemek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    RentHouse updateHouse = rentHouseOperations.GetById(txtRentId.Text);
                    RentHouse rentHouse = new RentHouse();
                    rentHouse.Id = txtRentId.Text;
                    rentHouse.RoomCount = Convert.ToInt32(txtRentRoomCount.Value);
                    rentHouse.FloorNumber = Convert.ToInt32(txtRentFloorNumber.Value);
                    rentHouse.District = txtRentDistrict.Text;
                    rentHouse.Area = txtRentArea.Text;
                    rentHouse.CreateDate = Convert.ToDateTime(txtRentCreatedDate.Text);
                    rentHouse.Type = ConvertHouseType.GetHouseType(txtRentType.Text);
                    rentHouse.IsEnabled = Convert.ToBoolean(txtRentEnabled.Checked);
                    rentHouse.RentPrice = Convert.ToDecimal(txtRentPrice.Value);
                    rentHouse.RentDeposit = Convert.ToDecimal(txtRentDeposit.Value);

                    rentHouseOperations.Update(updateHouse, rentHouse);
                    MessageBox.Show("Kiralık Ev Güncellendi.");
                    FillRentHouseList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ev Seçiniz.");
            }
        }

        /* Kiralık Ev Silme */
        private void btnDeleteRent_Click(object sender, EventArgs e)
        {
            if (txtRentId.Text.Length > 0)
            {
                var dialogWindow = MessageBox.Show("Kiralık Ev Silmek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    RentHouse deleteHouse = rentHouseOperations.GetById(txtRentId.Text);

                    string path = Application.StartupPath + "/HouseImages/RentHouses/";
                    GeneratorFolder generatorFolder = new GeneratorFolder();
                    generatorFolder.DeleteFolder(path, txtRentId.Text);

                    rentHouseOperations.Delete(deleteHouse);
                    MessageBox.Show("Kiralık Ev Silindi.");
                    FillRentHouseList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ev Seçiniz.");
            }
        }

        /* Kiralık Ev Alanları Temizleme */
        private void btnClearRent_Click(object sender, EventArgs e)
        {
            txtRentId.Text = "";
            txtRentDistrict.Text = "";
            txtRentArea.Text = "";
            txtRentPrice.Value = 0;
            txtRentDeposit.Value = 0;
            txtRentFloorNumber.Value = 0;
            txtRentRoomCount.Value = 0;
        }

        /* Kiralık Ev Seçme İşlemi */
        private void dgvRentHouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string path = Application.StartupPath + "/HouseImages/RentHouses/";
                    string id = dgvRentHouses.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    Process.Start(path + id);
                }
                catch
                {
                    MessageBox.Show("Dosya Bulunamadı.");
                }
            }

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvRentHouses.Rows[e.RowIndex].Selected = true;
            }
            try
            {
                txtRentId.Text = dgvRentHouses.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtRentPrice.Text = dgvRentHouses.Rows[e.RowIndex].Cells["RentPrice"].Value.ToString();
                txtRentDeposit.Text = dgvRentHouses.Rows[e.RowIndex].Cells["RentDeposit"].Value.ToString();
                txtRentRoomCount.Text = dgvRentHouses.Rows[e.RowIndex].Cells["RoomCount"].Value.ToString();
                txtRentFloorNumber.Text = dgvRentHouses.Rows[e.RowIndex].Cells["FloorNumber"].Value.ToString();
                txtRentDistrict.Text = dgvRentHouses.Rows[e.RowIndex].Cells["District"].Value.ToString();
                txtRentArea.Text = dgvRentHouses.Rows[e.RowIndex].Cells["Area"].Value.ToString();
                txtRentCreatedDate.Text = dgvRentHouses.Rows[e.RowIndex].Cells["CreateDate"].Value.ToString();
                txtRentType.Text = dgvRentHouses.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                txtRentEnabled.Checked = Convert.ToBoolean(dgvRentHouses.Rows[e.RowIndex].Cells["IsEnabled"].Value.ToString());
            }
            catch
            {

            }
        }



        /* Yeni Satilik Ev Ekleme */
        private void btnSaleAdd_Click(object sender, EventArgs e)
        {
            if (txtSaleDistrict.Text.Length > 0 && txtSaleArea.Text.Length > 0)
            {
                var dialogWindow = MessageBox.Show("Yeni Satılık Ev Eklemek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    SaleHouse saleHouse = new SaleHouse();
                    saleHouse.Id = GeneratorId.GenerateId();
                    saleHouse.RoomCount = Convert.ToInt32(txtSaleRoomCount.Value);
                    saleHouse.FloorNumber = Convert.ToInt32(txtSaleFloorNumber.Value);
                    saleHouse.District = txtSaleDistrict.Text;
                    saleHouse.Area = txtSaleArea.Text;
                    saleHouse.CreateDate = Convert.ToDateTime(txtSaleCreatedDate.Text);
                    saleHouse.Type = ConvertHouseType.GetHouseType(txtSaleType.Text);
                    saleHouse.IsEnabled = Convert.ToBoolean(txtSaleEnabled.Checked);
                    saleHouse.SalePrice = Convert.ToDecimal(txtSalePrice.Value);

                    string path = Application.StartupPath + "/HouseImages/SaleHouses/";
                    GeneratorFolder generatorFolder = new GeneratorFolder();
                    generatorFolder.CreateFolder(path, saleHouse.Id);

                    saleHouseOperations.Add(saleHouse);
                    MessageBox.Show("Yeni Satılık Ev Eklendi");
                    FillSaleHouseList();
                }
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz.");
            }
        }

        /* Satilik Ev Güncelleme */
        private void btnSaleUpdate_Click(object sender, EventArgs e)
        {
            if (txtSaleId.Text.Length > 0)
            {
                var dialogWindow = MessageBox.Show("Satılık Ev Güncellemek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    SaleHouse updateHouse = saleHouseOperations.GetById(txtSaleId.Text);
                    SaleHouse saleHouse = new SaleHouse();
                    saleHouse.Id = txtSaleId.Text;
                    saleHouse.RoomCount = Convert.ToInt32(txtSaleRoomCount.Value);
                    saleHouse.FloorNumber = Convert.ToInt32(txtSaleFloorNumber.Value);
                    saleHouse.District = txtSaleDistrict.Text;
                    saleHouse.Area = txtSaleArea.Text;
                    saleHouse.CreateDate = Convert.ToDateTime(txtSaleCreatedDate.Text);
                    saleHouse.Type = ConvertHouseType.GetHouseType(txtSaleType.Text);
                    saleHouse.IsEnabled = Convert.ToBoolean(txtSaleEnabled.Checked);
                    saleHouse.SalePrice = Convert.ToDecimal(txtSalePrice.Value);

                    saleHouseOperations.Update(updateHouse, saleHouse);
                    MessageBox.Show("Satılık Ev Güncellendi.");
                    FillSaleHouseList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ev Seçiniz.");
            }
        }

        /* Satilik Ev Silme */
        private void btnSaleDelete_Click(object sender, EventArgs e)
        {
            if (txtSaleId.Text.Length > 0)
            {
                var dialogWindow = MessageBox.Show("Satılık Ev Silmek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    SaleHouse deleteHouse = saleHouseOperations.GetById(txtSaleId.Text);

                    string path = Application.StartupPath + "/HouseImages/SaleHouses/";
                    GeneratorFolder generatorFolder = new GeneratorFolder();
                    generatorFolder.DeleteFolder(path, txtSaleId.Text);

                    saleHouseOperations.Delete(deleteHouse);
                    MessageBox.Show("Satılık Ev Silindi.");
                    txtSaleId.Text = "";
                    FillSaleHouseList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Ev Seçiniz.");
            }
        }

        /* Satilik Ev Alanları Temizleme */
        private void btnSaleClear_Click(object sender, EventArgs e)
        {
            txtSaleId.Text = "";
            txtSaleDistrict.Text = "";
            txtSaleArea.Text = "";
            txtSalePrice.Value = 0;
            txtSaleFloorNumber.Value = 0;
            txtSaleRoomCount.Value = 0;
        }

        /* Satilik Ev Seçme İşlemi */
        private void dgvSaleHouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    string path = Application.StartupPath + "/HouseImages/SaleHouses/";
                    string id = dgvSaleHouses.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    Process.Start(path + id);
                }
                catch
                {
                    MessageBox.Show("Dosya Bulunamadı.");
                }
            }

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvSaleHouses.Rows[e.RowIndex].Selected = true;
            }
            try
            {
                txtSaleId.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtSalePrice.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["SalePrice"].Value.ToString();
                txtSaleRoomCount.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["RoomCount"].Value.ToString();
                txtSaleFloorNumber.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["FloorNumber"].Value.ToString();
                txtSaleDistrict.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["District"].Value.ToString();
                txtSaleArea.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["Area"].Value.ToString();
                txtSaleCreatedDate.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["CreateDate"].Value.ToString();
                txtSaleType.Text = dgvSaleHouses.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                txtSaleEnabled.Checked = Convert.ToBoolean(dgvSaleHouses.Rows[e.RowIndex].Cells["IsEnabled"].Value.ToString());
            }
            catch
            {

            }
        }



        /* Arsiv Sayfasina Gitme */
        private void btnGoArchive_Click(object sender, EventArgs e)
        {
            FrmArchive frmArchive = new FrmArchive();
            frmArchive.Show();
            this.Hide();
        }

        /* Istatistikler Sayfasina Gitme */
        private void btnGoStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();
            this.Hide();
        }



        /* Saat Ve Tarih Gosterimi */
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
