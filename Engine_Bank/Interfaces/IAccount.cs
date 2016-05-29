using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Bank
{
    public interface IAccount
    {
        string      FullAccountName         { get; set; }
        decimal     MoneyAmount             { get; set; }
        bool        BalanceIsNegative       { get; set; }
        bool        IsEnabled               { get; set; }

        decimal     AddMoney                (decimal amount);
        decimal     SubtractMoney           (decimal amount);
        IAccount    Save                    ();
        IAccount    Load                    ();
    }
}
