using Emlak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Helpers
{
    public class ConvertHouseType
    {

        public static House.Types GetHouseType(string text)
        {
            if (text == "Apartment")
            {
                return House.Types.Apartment;
            }
            else if(text == "GardenHouse")
            {
                return House.Types.GardenHouse;
            }
            else if (text == "Dublex")
            {
                return House.Types.Dublex;
            }
            else if (text == "Seperate")
            {
                return House.Types.Seperate;
            }
            else
            {
                return House.Types.Apartment;
            }
        }

    }
}
