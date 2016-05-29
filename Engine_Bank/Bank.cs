using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Bank
{
    public class Bank : IBank
    {
        public List<IAccount>   AccountList     { get; set; }

        public bool             IsEnabled       { get; set; }
    }
}
