using Emlak.DataAccess.Abstract;
using Emlak.DataAccess.Helpers;
using Emlak.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Concrete.TextDb
{
    public class TDSaleHouseDal : ISaleHouseDal
    {

        string document_path = "";

        public TDSaleHouseDal(string document_path)
        {
            this.document_path = document_path;
        }

        /* Yeni Ev Ekleme */
        public void Add(SaleHouse saleHouse)
        {

            string addHouse = saleHouse.Id + "," + saleHouse.RoomCount + "," + saleHouse.FloorNumber + "," + saleHouse.District + "," + saleHouse.Area + "," + saleHouse.CreateDate + "," + saleHouse.Type + "," + saleHouse.IsEnabled + "," + saleHouse.SalePrice;
            StreamWriter sw = File.AppendText(document_path);
            sw.WriteLine(addHouse);
            sw.Flush();
            sw.Close();
        }

        /* Ev Silme */
        public void Delete(SaleHouse saleHouse)
        {
            List<SaleHouse> saleHouses = new List<SaleHouse>();
            saleHouses = this.GetAll();
            int index = saleHouses.FindIndex(x => x.Id == saleHouse.Id);

            var file = new List<string>(File.ReadAllLines(document_path));
            file.RemoveAt(index);
            File.WriteAllLines(document_path, file.ToArray());
        }

        /* Evleri Listeleme */
        public List<SaleHouse> GetAll()
        {
            List<SaleHouse> saleHouses = new List<SaleHouse>();
            FileStream fs = new FileStream(document_path, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string line = sw.ReadLine();
            while (line != null)
            {
                string[] splitLine = line.Split(',');

                SaleHouse saleHouseModel = new SaleHouse(
                    id: splitLine[0],
                    roomCount: Convert.ToInt32(splitLine[1]),
                    floorNumber: Convert.ToInt32(splitLine[2]),
                    district: splitLine[3],
                    area: splitLine[4],
                    createDate: Convert.ToDateTime(splitLine[5]),
                    type: ConvertHouseType.GetHouseType(splitLine[6]),
                    isEnabled: Convert.ToBoolean(splitLine[7]),
                    salePrice: Convert.ToDecimal(splitLine[8])
                );
                saleHouses.Add(saleHouseModel);
                line = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return saleHouses;
        }

        /* Id Numarasina Gore Ev Bulma */
        public SaleHouse GetById(string Id)
        {
            List<SaleHouse> saleHouses = new List<SaleHouse>();
            saleHouses = this.GetAll();
            SaleHouse findHouse = saleHouses.Find(x => x.Id == Id);
            return findHouse;
        }

        /* Ev Guncelleme */
        public void Update(SaleHouse saleHouse, SaleHouse saleHouseNew)
        {
            List<SaleHouse> saleHouses = new List<SaleHouse>();
            saleHouses = this.GetAll();
            int index = saleHouses.FindIndex(x => x.Id == saleHouse.Id);

            string oldSaleHouse = saleHouses[index].Id + "," + saleHouses[index].RoomCount + "," + saleHouses[index].FloorNumber + "," + saleHouses[index].District + "," + saleHouses[index].Area + "," + saleHouses[index].CreateDate + "," + saleHouses[index].Type + "," + saleHouses[index].IsEnabled + "," + saleHouses[index].SalePrice;
            string newSaleHouse = saleHouseNew.Id + "," + saleHouseNew.RoomCount + "," + saleHouseNew.FloorNumber + "," + saleHouseNew.District + "," + saleHouseNew.Area + "," + saleHouseNew.CreateDate + "," + saleHouseNew.Type + "," + saleHouseNew.IsEnabled + "," + saleHouseNew.SalePrice;

            string text = File.ReadAllText(document_path);
            text = text.Replace(oldSaleHouse, newSaleHouse);
            File.WriteAllText(document_path, text);
        }

    }
}
