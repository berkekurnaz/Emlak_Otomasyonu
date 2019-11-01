using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Models.Helpers
{
    public class AddLog
    {

        public void Add(MyLog myLog)
        {
            string document_path = @"mylogs.txt";
            string addLog = myLog.Message + "," + myLog.ErrorClassName + "," + myLog.Date;
            StreamWriter sw = File.AppendText(document_path);
            sw.WriteLine(addLog);
            sw.Flush();
            sw.Close();
        }

    }
}
