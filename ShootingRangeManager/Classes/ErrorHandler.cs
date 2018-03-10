using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRangeManager.Classes
{
    public class ErrorHandler
    {
        public ErrorHandler(Exception e, out string message)
        {
            string msg = "";
            string retString = GetExceptionMessages(e, msg);
            message = retString;
        }

        private string GetExceptionMessages(Exception e, string msgs = "")
        {
            if (e == null) return string.Empty;
            if (msgs == "") msgs = e.Message;
            if (e.InnerException != null)
                msgs += "\r\n" + GetExceptionMessages(e.InnerException);
            return msgs;
        }
    }
}
