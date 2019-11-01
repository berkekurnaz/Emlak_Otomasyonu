using Emlak.DataAccess.Abstract;
using Emlak.DataAccess.Concrete.TextDb;
using Emlak.DataAccess.Helpers;
using Emlak.Models;
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
    public partial class FrmArchive : MetroForm
    {

        IRentHouseDal rentHouseOperations;
        ISaleHouseDal saleHouseOperations;

        public FrmArchive()
        {
            InitializeComponent();
            string document_path = Application.StartupPath + "/renthouse.txt";
            string document_path2 = Application.StartupPath + "/salehouse.txt";
            rentHouseOperations = new TDRentHouseDal(document_path);
            saleHouseOperations = new TDSaleHouseDal(document_path2);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvSaleHouses.Columns.Add(btn);
            btn.HeaderText = "Resimler";
            btn.Text = "Resimler";
            btn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dgvRentHouses.Columns.Add(btn1);
            btn1.HeaderText = "Resimler";
            btn1.Text = "Resimler";
            btn1.UseColumnTextForButtonValue = true;
        }

        private void FrmArchive_Load(object sender, EventArgs e)
        {
            FillHouseTypesInComboboxes();
            FillRentHouseList();
            FillSaleHouseList();
        }

        private void FrmArchive_Activated(object sender, EventArgs e)
        {
            FillRentHouseList();
            FillSaleHouseList();
        }


        /* Kiralik Butun Evleri Listeleme */
        void FillRentHouseList()
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll();
        }

        /* Satilik Butun Evleri Listeleme */
        void FillSaleHouseList()
        {
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll();
        }

        /* Combobox İçerisine Ev Tiplerini Yazdırma */
        void FillHouseTypesInComboboxes()
        {
            foreach (var item in Enum.GetValues(typeof(House.Types)))
            {
                txtType.Items.Add(item);
            }
            txtType.SelectedIndex = 0;
        }



        /* Ana Menu Geri Donme Kodu */
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        /* Input Alanlarini Sifirlama Kodu */
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnabled.Checked = false;
            txtRoomMin.Value = 0;
            txtRoomMax.Value = 0;
            txtRentPriceMin.Value = 0;
            txtRentPriceMax.Value = 0;
            txtPriceMin.Value = 0;
            txtPriceMax.Value = 0;
            txtAgeMin.Value = 0;
            txtAgeMax.Value = 0;
            txtDistrict.Text = "";
            txtArea.Text = "";
            FillRentHouseList();
            FillSaleHouseList();
        }



        /* Aktif Olanlari Arama */
        private void txtEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (txtEnabled.Checked == true)
            {
                dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.IsEnabled == true).ToList();
                dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.IsEnabled == true).ToList();
            }
            else
            {
                dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.IsEnabled == false).ToList();
                dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.IsEnabled == false).ToList();
            }
        }



        /* Oda Sayisina Gore Arama */
        private void txtRoomMin_ValueChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.RoomCount >= txtRoomMin.Value).ToList();
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.RoomCount >= txtRoomMin.Value).ToList();
        }

        private void txtRoomMax_ValueChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.RoomCount <= txtRoomMax.Value && x.RoomCount >= txtRoomMin.Value).ToList();
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.RoomCount <= txtRoomMax.Value && x.RoomCount >= txtRoomMin.Value).ToList();
        }



        /* Yasina Gore Arama */
        private void txtAgeMin_ValueChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.Age >= txtAgeMin.Value).ToList();
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.Age >= txtAgeMin.Value).ToList();
        }

        private void txtAgeMax_ValueChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.Age <= txtAgeMax.Value && x.Age >= txtAgeMin.Value).ToList();
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.Age <= txtAgeMax.Value && x.Age >= txtAgeMin.Value).ToList();
        }



        /* Kira Ucretine Gore Arama */
        private void txtRentPriceMin_ValueChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.RentPrice >= txtRentPriceMin.Value).ToList();
        }

        private void txtRentPriceMax_ValueChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.RentPrice <= txtRentPriceMax.Value && x.RentPrice >= txtRentPriceMin.Value).ToList();
        }



        /* Emlak Degerine Gore Arama */
        private void txtPriceMin_ValueChanged(object sender, EventArgs e)
        {
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.SalePrice >= txtPriceMin.Value).ToList();
        }

        private void txtPriceMax_ValueChanged(object sender, EventArgs e)
        {
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.SalePrice <= txtPriceMax.Value && x.SalePrice >= txtPriceMin.Value).ToList();
        }



        /* Ev Tipine Gore Arama */
        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().Where(x => x.Type == ConvertHouseType.GetHouseType(txtType.Text)).ToList();
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().Where(x => x.Type == ConvertHouseType.GetHouseType(txtType.Text)).ToList();
        }



        /* Semtine Gore Arama */
        private void txtDistrict_TextChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().FindAll(x => x.District.Contains(txtDistrict.Text));
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().FindAll(x => x.District.Contains(txtDistrict.Text));
        }



        /* Alanina Gore Arama */
        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            dgvRentHouses.DataSource = rentHouseOperations.GetAll().FindAll(x => x.Area.Contains(txtArea.Text));
            dgvSaleHouses.DataSource = saleHouseOperations.GetAll().FindAll(x => x.Area.Contains(txtArea.Text));
        }



        /* Kiralik Evler DataGridView Tiklama Islemi */
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
                string id = dgvRentHouses.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string rentPrice = dgvRentHouses.Rows[e.RowIndex].Cells["RentPrice"].Value.ToString();

                FrmEdit frmEdit = new FrmEdit(type: "Kiralik", id: id);
                frmEdit.Show();
            }
            catch
            {

            }
        }

        private void dgvRentHouses_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /* Satilik Evler DataGridView Tiklama Islemi */
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
                MessageBox.Show(dgvSaleHouses.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            }
            catch
            {

            }
        }

    }
}
