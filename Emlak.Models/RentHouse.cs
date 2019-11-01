using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Models
{
    public class RentHouse : House
    {

        /* FIELDS */
        protected decimal m_rentPrice;
        protected decimal m_rentDeposit;



        /* GET SET METHODS */
        public decimal RentPrice
        {
            get
            {
                return m_rentPrice;
            }
            set
            {
                if (value <= 0)
                {
                    m_rentPrice = 0;
                }
                else
                {
                    m_rentPrice = value;
                }
            }
        }

        public decimal RentDeposit
        {
            get
            {
                return m_rentDeposit;
            }
            set
            {
                if (value <= 0)
                {
                    m_rentDeposit = 0;
                }
                else
                {
                    m_rentDeposit = value;
                }
            }
        }



        /* CONSTRUCTORS */
        public RentHouse()
        {

        }

        public RentHouse(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate, Types type, bool isEnabled, decimal rentPrice, decimal rentDeposit) : base(id, roomCount, floorNumber, district, area, createDate, type, isEnabled)
        {
            this.RentPrice = rentPrice;
            this.RentDeposit = rentDeposit;
        }

        public RentHouse(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate, Types type) : base(id, roomCount, floorNumber, district, area, createDate, type)
        {

        }

        public RentHouse(string id, int roomCount, int floorNumber, string district, string area, DateTime createDate) : base(id, roomCount, floorNumber, district, area, createDate)
        {

        }

        public RentHouse(string id, int roomCount, int floorNumber, string district, string area) : base(id, roomCount, floorNumber, district, area)
        {

        }

        /* METHODS */
        public override string ShowHouseInformations()
        {
            return Id + " " + RoomCount + " " + FloorNumber + " " + District + " " + Area + " " + CreateDate + " " + Type + " " + IsEnabled + " " + RentPrice + " " + RentDeposit;
        }

    }
}
