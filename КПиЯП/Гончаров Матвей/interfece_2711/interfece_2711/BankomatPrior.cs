using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    class BankomatPrior : Ibankomat, IbankomatPriorbank
    {
        // номер банкомата
        int num;
        double money = 0.0;
        bool Bonus = false;

        public BankomatPrior() { }
        public BankomatPrior(int num, double money) 
        {
            this.num = num;
            this.money = money;
        }

        // Ibankomat.snatDengi()
        public void snatDengi(double money)
        {
            if (this.money > 0 && this.money >= Abs(money))
            {
                Console.WriteLine($"У вас на балансе {this.money}, а вы сняли {money}");
                this.money -= money;
                Console.WriteLine($"Теперь на вашем балансе {this.money}"); // this.money,1:2f
            }
            else 
            {
                Console.WriteLine($"У вас на балансе {this.money}, а вы хотите снять {money}");
            }
        }

        public void getBonus()
        {
            Console.WriteLine("Допустим вы получили бонус");
            this.Bonus = true;
        }
    }
}
