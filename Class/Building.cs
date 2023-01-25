using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Building
    {
        public string name = "";
        public int height;
        public int area;
        public string adress = "";

        public Building(string name, int height, int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;

        }

        public void GetVolume()
        {
            int volume = height * area;
            Console.WriteLine($"Volume of the building is :{volume}"); ;
        }


    }
}
