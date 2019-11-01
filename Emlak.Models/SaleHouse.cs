using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Models
{
    public class SaleHouse : House
    {

        /* FIELDS */
        protected decimal m_salePrice;



        /* GET SET METHODS */
        public decimal SalePrice
        {
            get
            {
                return m_salePrice;
            }
            set
            {
                if (value <= 0)
                {
                    m_salePrice = 0;
                }
                else
                {
                    m_salePrice = value;
                }
            }
        }



        /* CONSTRUCTORS */
        public SaleHouse()
        {

        }

        public SaleHouse(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate, Types type, bool isEnabled, decimal salePrice) : base(id, roomCount, floorNumber, district, area, createDate, type, isEnabled)
        {
            this.SalePrice = salePrice;
        }

        public SaleHouse(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate, Types type) : base(id, roomCount, floorNumber, district, area, createDate, type)
        {

        }

        public SaleHouse(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate) : base(id, roomCount, floorNumber, district, area, createDate)
        {

        }

        public SaleHouse(string id, int roomCount, int floorNumber, string district, string area) : base(id, roomCount, floorNumber, district, area)
        {

        }

        /* METHODS */
        public override string ShowHouseInformations()
        {
            return Id + " " + RoomCount + " " + FloorNumber + " " + District + " " + Area + " " + CreateDate + " " + Type + " " + IsEnabled + " " + SalePrice;
        }
    }
}
