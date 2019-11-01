using Emlak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Abstract
{
    public interface IMyLogDal
    {
        void AddLog(MyLog myLog);
    }
}
