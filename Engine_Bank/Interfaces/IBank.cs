using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Bank
{
    public interface IBank
    {
        List<IAccount>  AccountList     { get; set; }
        bool            IsEnabled       { get; set; }
    }
}