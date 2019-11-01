using Emlak.DataAccess.Abstract;
using Emlak.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Concrete.TextDb
{
    public class TDMyLogDal : IMyLogDal
    {

        string document_path = @"mylogs.txt";

        public void AddLog(MyLog myLog)
        {
            string addLog = myLog.Message + "," + myLog.ErrorClassName + "," + myLog.Date;
            StreamWriter sw = File.AppendText(document_path);
            sw.WriteLine(addLog);
            sw.Flush();
            sw.Close();
        }

    }
}
