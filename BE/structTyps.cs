using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class structTyps
    {
        public struct Address
        {
            string street;
            public string Street { get => street; set => street = value; }

            int buildingNum;
            public int BuildingNum { get => buildingNum; set => buildingNum = value; }

            string city;
            public string City { get => city; set => city = value; }

            public Address(string s, int b, string c)
            {
                street = s;
                buildingNum = b;
                city = c;
            }

            public override string ToString()
            {
                return street + " " + buildingNum + " " + city;
            }
        }
    }
}
