using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Models
{
    public class MyLog
    {
        public string Message { get; set; }
        public string ErrorClassName { get; set; }
        public string Date { get; set; }

        public MyLog(string Message, string ErrorClassName, string Date)
        {
            this.Message = Message;
            this.ErrorClassName = ErrorClassName;
            this.Date = Date;
        }

    }
}
