using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class SaveInformation
    {
        public static int isAdmin;

        private static string _name;
        private static string _info;
        private static Color _color;
        private static DateTime _endDate;

        public SaveInformation(string name)
        {
            _name = name;
        }
        
        public SaveInformation(string name, string info, DateTime endDate)
        {
            _name = name;
            _info = info;
            _color = Color.White;
            _endDate = endDate;
        }
       
        public SaveInformation(string name, string info,Color c,DateTime dateTime)
        {
            _name = name;
            _info = info;
            _color = c;
            _endDate = dateTime;
        }

        public static string getName()
        {
            return _name;
        }
        public static string getInfo()
        {
            return _info;
        }
        public static Color getColor()
        {
            return _color;
        }
        public static DateTime getEndDate()
        {
            return _endDate;
        }
    }
}
