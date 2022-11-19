using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConsole
{
    internal interface IPerson
    {
        public string FullName { get; set; }
        public void Introduction();
    }
}
