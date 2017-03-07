using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = 
                @"select from table
            where id>1000";
            string xml =
                @"<Pokemon>
                    <NationNo>#001</NationalNo>
                    <Name>Bulbsaur</Name>
                  </Pokemon>";
            string json =
                @"Pokemon = {
                    NationalNo:'#001'
                    Name:Bulbsaur
                    }";

        }
    }
}
