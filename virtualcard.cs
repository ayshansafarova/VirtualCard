using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualCard obj1 = new VirtualCard("Ayshan");
            obj1.setVirtualAccountNumber();
            obj1.setVirtualSecurityNumber();
            Console.WriteLine(obj1.VirtualAccountNumber + " <== The account number of Virtual Card");
            Console.WriteLine("The security number of Virtual Card: " + obj1.VirtualSecurityNumber);
            Console.WriteLine("The name of Virtual Card: " + obj1.VirtualName);
            Console.WriteLine("The expiry date of Virtual Card: {0}/{1}", obj1.ExpiryMonth, obj1.ExpiryYear);
            obj1.ValidTime(5);
            obj1.SetMoney(500);
            Console.WriteLine("Money is {0} AZN", obj1.GetMoney());


        }
    }
    class RealCard
    {
        private int RealAccountNumber;
        private int RealSecurityNumber;
        private int RealPassword;
        public int ExpiryMonth = 10; //bitme ayi
        public int ExpiryYear = 2022; //bitme ili
        protected int RealMoney = 1500;
    }
    class VirtualCard : RealCard
    {
        private int VirtualMoney;
        private int VirtualPassword;
        public string VirtualName;
        public int VirtualAccountNumber;
        public int VirtualSecurityNumber;
        const int CreationMonth = 11; //yaranma ayi
        const int CreationYear = 2018; //yaranmna ili
        public int ValidMonth; //istifade muddeti ay

        public VirtualCard(string name)
        {
            VirtualName = name;
        }

        //Account numbera randomm generate elemek
        public void setVirtualAccountNumber()
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0,2}  ", rnd.Next(1000, 10000));
            }
        }

        //Security numbera randomm generate elemek
        public void setVirtualSecurityNumber()
        {
            int r = (new Random()).Next(100, 1000);
            VirtualSecurityNumber = r;
        }

        //Istifade muddeti teyin etme
        public void ValidTime(int month)
        {
            ValidMonth = month;
            if (month <= ExpiryMonth+(12 - CreationMonth)+(ExpiryYear-CreationYear-2)*12)
            {
                Console.WriteLine("The valid date of Virtual Card: {0} months",  ValidMonth);
            }
            else
            {
                Console.WriteLine("Setting up Valid time: It is invalid process!");
            }
        }
        public void SetMoney(int money)
        {
            if (money <= RealMoney)
            {
                RealMoney = RealMoney - money;
                VirtualMoney = money;
                Console.WriteLine("Money is transferred succesfully!");
            }
            else
            {
                Console.WriteLine("Money transferring: It is invalid process!");
            }
        }
        public int GetMoney()
        {
            return VirtualMoney;
        }


    }
}
     
