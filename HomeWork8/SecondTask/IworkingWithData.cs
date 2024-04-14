using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork8.SecondTask
{
    internal interface IworkingWithData
    {
        public void GetInfo()
        {

        }
        public bool CheckingExpirationDate()
        {
            return false;
        }
    }
}
