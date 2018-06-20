using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    /// <summary>
    /// Klasse for lagring informasjon fra og til databasen
    /// </summary>
    public class SaveDataBaseInformation
    {

        public SaveDataBaseInformation(int year, int month, int day, string user, string description, string color, int adminPri)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.user = user;
            this.description = description;
            this.color = color;
            this.adminPri = adminPri;
        }

        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public string user { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public int adminPri { get; set; }

       
        
    }
}
