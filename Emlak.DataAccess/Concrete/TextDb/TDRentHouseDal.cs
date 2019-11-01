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
    public class TDRentHouseDal : IRentHouseDal
    {

        string document_path = "";

        public TDRentHouseDal(string document_path)
        {
            this.document_path = document_path;
        }

        /* Yeni Ev Ekleme */
        public void Add(RentHouse rentHouse)
        {

            string addHouse = rentHouse.Id + "," + rentHouse.RoomCount + "," + rentHouse.FloorNumber + "," + rentHouse.District + "," + rentHouse.Area + "," + rentHouse.CreateDate + "," + rentHouse.Type + "," + rentHouse.IsEnabled + "," + rentHouse.RentPrice + "," + rentHouse.RentDeposit;
            StreamWriter sw = File.AppendText(document_path);
            sw.WriteLine(addHouse);
            sw.Flush();
            sw.Close();
        }

        /* Ev Silme */
        public void Delete(RentHouse rentHouse)
        {
            List<RentHouse> rentHouses = new List<RentHouse>();
            rentHouses = this.GetAll();
            int index = rentHouses.FindIndex(x => x.Id == rentHouse.Id);

            var file = new List<string>(File.ReadAllLines(document_path));
            file.RemoveAt(index);
            File.WriteAllLines(document_path, file.ToArray());
        }

        /* Evleri Listeleme */
        public List<RentHouse> GetAll()
        {
            List<RentHouse> rentHouses = new List<RentHouse>();
            FileStream fs = new FileStream(document_path, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string line = sw.ReadLine();
            while (line != null)
            {
                string[] splitLine = line.Split(',');

                RentHouse rentHouseModel = new RentHouse(
                    id: splitLine[0],
                    roomCount: Convert.ToInt32(splitLine[1]),
                    floorNumber: Convert.ToInt32(splitLine[2]),
                    district: splitLine[3],
                    area: splitLine[4],
                    createDate: Convert.ToDateTime(splitLine[5]),
                    type: ConvertHouseType.GetHouseType(splitLine[6]),
                    isEnabled: Convert.ToBoolean(splitLine[7]),
                    rentPrice: Convert.ToDecimal(splitLine[8]),
                    rentDeposit: Convert.ToDecimal(splitLine[9])
                );
                rentHouses.Add(rentHouseModel);
                line = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return rentHouses;
        }

        /* Id Numarasina Gore Ev Bulma */
        public RentHouse GetById(string Id)
        {
            List<RentHouse> rentHouses = new List<RentHouse>();
            rentHouses = this.GetAll();
            RentHouse findHouse = rentHouses.Find(x => x.Id == Id);
            return findHouse;
        }

        /* Ev Guncelleme */
        public void Update(RentHouse rentHouse, RentHouse rentHouseNew)
        {
            List<RentHouse> rentHouses = new List<RentHouse>();
            rentHouses = this.GetAll();
            int index = rentHouses.FindIndex(x => x.Id == rentHouse.Id);

            string oldRentHouse = rentHouses[index].Id + "," + rentHouses[index].RoomCount + "," + rentHouses[index].FloorNumber + "," + rentHouses[index].District + "," + rentHouses[index].Area + "," + rentHouses[index].CreateDate + "," + rentHouses[index].Type + "," + rentHouses[index].IsEnabled + "," + rentHouses[index].RentPrice + "," + rentHouses[index].RentDeposit;
            string newRenHouse = rentHouseNew.Id + "," + rentHouseNew.RoomCount + "," + rentHouseNew.FloorNumber + "," + rentHouseNew.District + "," + rentHouseNew.Area + "," + rentHouseNew.CreateDate + "," + rentHouseNew.Type + "," + rentHouseNew.IsEnabled + "," + rentHouseNew.RentPrice + "," + rentHouseNew.RentDeposit;

            string text = File.ReadAllText(document_path);
            text = text.Replace(oldRentHouse, newRenHouse);
            File.WriteAllText(document_path, text);
        }

    }
}
