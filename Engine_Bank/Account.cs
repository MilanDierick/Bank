using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Bank
{
    public class Account : IAccount
    {
        public string       FullAccountName     { get { return _FullAccountName; }      set { _FullAccountName = value; } }
        public decimal      MoneyAmount         { get { return _MoneyAmount; }          set { _MoneyAmount = value; } }
        public bool         BalanceIsNegative   { get { return _BalanceIsNegative; }    set { _BalanceIsNegative = value; } }
        public bool         IsEnabled           { get;                                  set; }

        private string      _FullAccountName    { get;                                  set; }
        private decimal     _MoneyAmount        { get;                                  set; }
        private bool        _BalanceIsNegative  { get;                                  set; }

        // Default constructor to create a basic account without any data
        public Account()
        {

        }

        /// <summary>
        /// Constructor used to create a fully functional account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        public Account(string name, decimal amount)
        {
            _FullAccountName = name;
            _MoneyAmount = amount;
        }

        /// <summary>
        /// Adds a given amount of money to an account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal AddMoney(decimal amount)
        {
            _MoneyAmount += amount;
            Update();
            return MoneyAmount;
        }

        /// <summary>
        /// Subtracts a given amount of money to an account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal SubtractMoney(decimal amount)
        {
            _MoneyAmount -= amount;
            Update();
            return MoneyAmount;
        }

        public void Update()
        {
            if (MoneyAmount < 0)
            {
                _BalanceIsNegative = true;
            }
        }

        public IAccount Save()
        {
            return this;
        }

        public IAccount Load()
        {
            return this;
        }
    }
}
