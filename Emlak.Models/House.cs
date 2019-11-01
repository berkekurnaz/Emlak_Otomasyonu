using Emlak.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Models
{
    public class House
    {

        /* FIELDS */
        protected string m_id; // Emlak Numarasi
        protected int m_roomCount; // Oda Sayisi
        protected int m_floorNumber; // Kat Numarasi
        protected string m_district; // Semt
        protected string m_area; // Alan
        protected DateTime m_createDate; // Yapım Tarihi
        public enum Types
        {
            Apartment,
            GardenHouse,
            Dublex,
            Seperate
        };
        protected Types m_type; // Ev Tipi
        protected bool m_isEnabled; // Aktif



        /* GET SET METHODS */
        public string Id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        public int RoomCount
        {
            get
            {
                return m_roomCount;
            }
            set
            {
                if (value <= 0)
                {
                    AddLog addLog = new AddLog();
                    addLog.Add(new MyLog("Sıfırdan Kucuk Deger Girildi", "House", DateTime.Now.ToShortDateString()));
                    m_roomCount = 0;
                }
                else
                {
                    m_roomCount = value;
                }
            }
        }

        public int FloorNumber
        {
            get
            {
                return m_floorNumber;
            }
            set
            {
                if (value <= 0)
                {
                    AddLog addLog = new AddLog();
                    addLog.Add(new MyLog("Sıfırdan Kucuk Deger Girildi", "House", DateTime.Now.ToShortDateString()));
                    m_floorNumber = 0;
                }
                else
                {
                    m_floorNumber = value;
                }
            }
        }

        public string District
        {
            get
            {
                return m_district;
            }
            set
            {
                m_district = value;
            }
        }

        public string Area
        {
            get
            {
                return m_area;
            }
            set
            {
                m_area = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return m_createDate;
            }
            set
            {
                m_createDate = value;
            }
        }

        public Types Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }

        public bool IsEnabled
        {
            get
            {
                return m_isEnabled;
            }
            set
            {
                m_isEnabled = value;
            }
        }

        public int Age
        {
            get
            {
                return CalculateHouseAge();
            }
        }

        /* CONSTRUCTORS */
        public House()
        {

        }

        public House(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate, Types type, bool isEnabled)
        {
            Id = id;
            RoomCount = roomCount;
            FloorNumber = floorNumber;
            District = district;
            Area = area;
            CreateDate = createDate;
            Type = type;
            IsEnabled = isEnabled;
        }

        public House(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate, Types type)
        {
            Id = id;
            RoomCount = roomCount;
            FloorNumber = floorNumber;
            District = district;
            Area = area;
            CreateDate = createDate;
            Type = type;
        }

        public House(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate)
        {
            Id = id;
            RoomCount = roomCount;
            FloorNumber = floorNumber;
            District = district;
            Area = area;
            CreateDate = createDate;
        }

        public House(string id, int roomCount, int floorNumber, string district, string area)
        {
            Id = id;
            RoomCount = roomCount;
            FloorNumber = floorNumber;
            District = district;
            Area = area;
        }

        /* METHODS */
        public virtual string ShowHouseInformations()
        {
            return "ev bilgi";
        }

        public decimal CalculateHousePrice()
        {
            decimal prediction = (RoomCount * FloorNumber) * 200;
            return prediction;
        }

        public int CalculateHouseAge()
        {
            int age;
            DateTime bDate = Convert.ToDateTime(DateTime.Now);
            DateTime kDate = Convert.ToDateTime(CreateDate);
            TimeSpan timeDate = bDate - kDate;
            age = Convert.ToInt32(timeDate.TotalDays / 365);

            return age;
        }

    }
}
