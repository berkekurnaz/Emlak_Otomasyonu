using Emlak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Abstract
{
    public interface IRentHouseDal
    {
        List<RentHouse> GetAll();
        RentHouse GetById(string Id);
        void Add(RentHouse rentHouse);
        void Update(RentHouse rentHouse, RentHouse rentHouseNew);
        void Delete(RentHouse rentHouse);
    }
}
