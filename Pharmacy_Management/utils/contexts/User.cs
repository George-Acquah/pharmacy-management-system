using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.utils.contexts
{
    public class User
    {
        private static string _UserId;
        private static string _UserName;
        private static bool _PassResReq;
        private static string _TempPass;

        public string ID
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string Username {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public bool PasswordResetRequested {
            get { return _PassResReq; }
            set { _PassResReq = value; }
        }
        public string TemporaryPassword {
            get { return _TempPass; }
            set { _TempPass = value; }
        }
    }
}
