using Emlak.DataAccess.Abstract;
using Emlak.DataAccess.Concrete.TextDb;
using Emlak.DataAccess.Helpers;
using Emlak.Models;
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
    public partial class FrmEdit : MetroForm
    {

        string type = "";
        string id = "";

        IRentHouseDal rentHouseOperations;
        ISaleHouseDal saleHouseOperations;

        public FrmEdit(string type, string id)
        {
            InitializeComponent();
            this.type = type;
            this.id = id;

            string document_path = Application.StartupPath + "/renthouse.txt";
            string document_path2 = Application.StartupPath + "/salehouse.txt";
            rentHouseOperations = new TDRentHouseDal(document_path);
            saleHouseOperations = new TDSaleHouseDal(document_path2);

            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            FillHouseTypesInComboboxes();

            if (type == "Kiralik")
            {
                panel1.Visible = true;

                try
                {
                    RentHouse rentHouse = rentHouseOperations.GetById(id);
                    txtId.Text = rentHouse.Id;
                    txtRentPrice.Text = rentHouse.RentPrice.ToString();
                    txtRentDeposit.Text = rentHouse.RentDeposit.ToString();
                    txtRoomCount.Text = rentHouse.RoomCount.ToString();
                    txtFloorNumber.Text = rentHouse.FloorNumber.ToString();
                    txtDistrict.Text = rentHouse.District;
                    txtArea.Text = rentHouse.Area;
                    txtCreatedDate.Text = rentHouse.CreateDate.ToString();
                    txtType.Text = rentHouse.Type.ToString();
                    txtEnabled.Checked = Convert.ToBoolean(rentHouse.IsEnabled.ToString());
                }
                catch
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
            else if(type == "Satilik")
            {
                panel2.Visible = true;

                try
                {
                    SaleHouse rentHouse = saleHouseOperations.GetById(id);
                    txtId.Text = rentHouse.Id;
                    txtSalePrice.Text = rentHouse.SalePrice.ToString();
                    txtRoomCount.Text = rentHouse.RoomCount.ToString();
                    txtFloorNumber.Text = rentHouse.FloorNumber.ToString();
                    txtDistrict.Text = rentHouse.District;
                    txtArea.Text = rentHouse.Area;
                    txtCreatedDate.Text = rentHouse.CreateDate.ToString();
                    txtType.Text = rentHouse.Type.ToString();
                    txtEnabled.Checked = Convert.ToBoolean(rentHouse.IsEnabled.ToString());
                }
                catch
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (type == "Kiralik")
            {
                var dialogWindow = MessageBox.Show("Kiralık Ev Güncellemek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    RentHouse updateHouse = rentHouseOperations.GetById(txtId.Text);
                    RentHouse rentHouse = new RentHouse();
                    rentHouse.Id = txtId.Text;
                    rentHouse.RoomCount = Convert.ToInt32(txtRoomCount.Value);
                    rentHouse.FloorNumber = Convert.ToInt32(txtFloorNumber.Value);
                    rentHouse.District = txtDistrict.Text;
                    rentHouse.Area = txtArea.Text;
                    rentHouse.CreateDate = Convert.ToDateTime(txtCreatedDate.Text);
                    rentHouse.Type = ConvertHouseType.GetHouseType(txtType.Text);
                    rentHouse.IsEnabled = Convert.ToBoolean(txtEnabled.Checked);
                    rentHouse.RentPrice = Convert.ToDecimal(txtRentPrice.Value);
                    rentHouse.RentDeposit = Convert.ToDecimal(txtRentDeposit.Value);

                    rentHouseOperations.Update(updateHouse, rentHouse);
                    MessageBox.Show("Kiralık Ev Güncellendi.");
                    this.Hide();
                }
            }
            else
            {
                var dialogWindow = MessageBox.Show("Satılık Ev Güncellemek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    SaleHouse updateHouse = saleHouseOperations.GetById(txtId.Text);
                    SaleHouse saleHouse = new SaleHouse();
                    saleHouse.Id = txtId.Text;
                    saleHouse.RoomCount = Convert.ToInt32(txtRoomCount.Value);
                    saleHouse.FloorNumber = Convert.ToInt32(txtFloorNumber.Value);
                    saleHouse.District = txtDistrict.Text;
                    saleHouse.Area = txtArea.Text;
                    saleHouse.CreateDate = Convert.ToDateTime(txtCreatedDate.Text);
                    saleHouse.Type = ConvertHouseType.GetHouseType(txtType.Text);
                    saleHouse.IsEnabled = Convert.ToBoolean(txtEnabled.Checked);
                    saleHouse.SalePrice = Convert.ToDecimal(txtSalePrice.Value);

                    saleHouseOperations.Update(updateHouse, saleHouse);
                    MessageBox.Show("Satılık Ev Güncellendi.");
                    this.Hide();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (type == "Kiralik")
            {
                var dialogWindow = MessageBox.Show("Kiralık Ev Silmek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    RentHouse deleteHouse = rentHouseOperations.GetById(txtId.Text);

                    string path = Application.StartupPath + "/HouseImages/RentHouses/";
                    GeneratorFolder generatorFolder = new GeneratorFolder();
                    generatorFolder.DeleteFolder(path, txtId.Text);

                    rentHouseOperations.Delete(deleteHouse);
                    MessageBox.Show("Kiralık Ev Silindi.");
                    this.Hide();
                }
            }
            else
            {
                var dialogWindow = MessageBox.Show("Satılık Ev Silmek İstiyor Musunuz ?", "Bilgi Kutusu", MessageBoxButtons.YesNo);
                if (dialogWindow == DialogResult.Yes)
                {
                    SaleHouse deleteHouse = saleHouseOperations.GetById(txtId.Text);

                    string path = Application.StartupPath + "/HouseImages/SaleHouses/";
                    GeneratorFolder generatorFolder = new GeneratorFolder();
                    generatorFolder.DeleteFolder(path, txtId.Text);

                    saleHouseOperations.Delete(deleteHouse);
                    MessageBox.Show("Satılık Ev Silindi.");
                    this.Hide();
                }
            }
        }
    }
}
