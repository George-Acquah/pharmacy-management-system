using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.utils.contexts
{
    public static class MyAppContext
    {
        private static string _userRole;
        private static string _empid;
        private static string _userName;
        private static string _userPass;
        private static int _billId;
        private static int _empId;
        private static int _compId;
        private static int _custId;
        private static int _loginId;
        private static int _medId;
        private static int _roleId;
        private static int _saleId;

        private static int _loginCount;

        public static string UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

        public static int LoginCount
        {
            get { return _loginCount; }
            set { _loginCount = value; }
        }

        public static string EmpID
        {
            get { return _empid; }
            set { _empid = value; }
        }

        public static string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public static string UserPass
        {
            get { return _userPass; }
            set { _userPass = value; }
        }

        public static int billIdNum
        {
            get { return _billId; }
            set { _billId = value; }
        }

        public static int empIdNum
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public static int compIdNum
        {
            get { return _compId; }
            set { _compId = value; }
        }

        public static int custIdNum
        {
            get { return _custId; }
            set { _custId = value; }
        }

        public static int loginIdNum
        {
            get { return _loginId; }
            set { _loginId = value; }
        }

        public static int medIdNum
        {
            get { return _medId; }
            set { _medId = value; }
        }

        public static int roleIdNum
        {
            get { return _roleId; }
            set { _roleId = value; }
        }

        public static int saleId
        {
            get { return _saleId; }
            set { _saleId = value; }
        }
    }

}
