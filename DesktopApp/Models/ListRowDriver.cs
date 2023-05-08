using Domena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Models
{
    public class ListRowDriver
    {
        public ListRowDriver()
        {

        }
        public ListRowDriver(Driver driver)
        {
            Id = driver.Id;
            Name = driver.Name;
            Lastname = driver.Surname;

            if (driver.License != null)
            {
                List<string> categories = new List<string>();

                if (driver.License.CatB != null && driver.License.CatB == true)
                    categories.Add("B");

                if (driver.License.CatC != null && driver.License.CatC == true)
                    categories.Add("C");

                Licenses = categories.Count > 0 ? string.Join(", ", categories) : ""; // B,C
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Licenses { get; set; }
    }
}
