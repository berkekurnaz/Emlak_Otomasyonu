using Emlak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Abstract
{
    public interface ISaleHouseDal
    {
        List<SaleHouse> GetAll();
        SaleHouse GetById(string Id);
        void Add(SaleHouse saleHouse);
        void Update(SaleHouse saleHouse, SaleHouse saleHouseNew);
        void Delete(SaleHouse saleHouse);
    }
}
