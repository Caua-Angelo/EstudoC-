using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_108Herança.Entities
{
    class Account
    {
        public int Number { get;private set; }
        public string Holder { get;private set; }
        public double Balance { get;protected set; }//protect diz que só pode ser alterado pela propria classe ou subsclasses

        public Account() { }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount +5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
