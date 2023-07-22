using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.utils.constants
{
    internal class Shared
    {
        public static string wrongOperation(string input)
        {
            string text = "Wrong Operation... Click on the " + input + " to be Updated";
            return text;
        } 
        public static string missingData = "Missing Data... Fill All the Information";

        public static string updateSuccess(string input)
        {
            string text = input +" Updated Successfully";
            return text;
        }

        public static string addSuccess(string input)
        {
            string text = input + " Successfully  Added";
            return text;
        }

        public static string deleteSuccess(string input)
        {
            string text = input + " Successfully  Deleted";
            return text;

        }
        public static string noSelection(string input1, string input2)
        {
            string text = "Please select a " + input1 + " to " +  input2 + "...";
            return text;
        }

        //BEGIN SHORTCUTS
        public static char delete = 'D';
        public static char back = 'B';
        public static char print = 'P';
        public static char add = 'A';
        public static char update = 'U';
        public static char home = 'H';

        public static string shortcut(char inp)
        {
            string text = "Ctrl" + inp;
            return text;
        }
        public static string del_shortcut = shortcut(delete);
        public static string back_shortcut = shortcut(back);
        public static string print_shortcut = shortcut(print);
        public static string add_shortcut = shortcut(add);
        public static string update_shortcut = shortcut(update);
        public static string home_shortcut = shortcut(home);
    }
}
