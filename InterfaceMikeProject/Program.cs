using System;

namespace InterfaceMikeProject {
    class Program {
        static void Main(string[] args) {

            Partner p1 = new Partner();
            p1.VendorId = 123;
            p1.CreditLimit = 1000m;

            PrintLabel(p1);

            Customer c1 = new Customer();
            PrintLabel(c1);

            Partner p2 = new Partner();
            p2.VendorId = 123;
            p2.CreditLimit = 5000m;

            if (p1.CompareTo(p2)>0) //CompareTo is used to compare sorting
                {
                Console.WriteLine("P1 is better");
            }else { Console.WriteLine("P1 is not better");
            }

        }
        static void PrintLabel(IPrintLabel theAddressObject) 
        {
            Console.WriteLine(theAddressObject.Name + " " + theAddressObject);
        }
   
    }

    interface IPrintLabel {
        string Name { get; set; }
        string Address { get; set; }
    }



    interface IVendor {
        int VendorId { get; set; }
        string Name { get; set; }
        decimal CreditLimit { get; set; }
        void YellAtVendor(string Msg);
        string Purchase(string Item, int Qty);

        //Events

    }
    class Customer : IPrintLabel {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Partner : IVendor, IComparable, IPrintLabel 
        {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public decimal CreditLimit { get; set; }

        public int CompareTo(object obj) {
            Partner theOtherGuy = (Partner)obj;
            if (this.CreditLimit == theOtherGuy.CreditLimit) {
                return 0;
            }
            else if(this.CreditLimit > theOtherGuy.CreditLimit)
            {
                return 1;
            }
            else {

            }
            return -1;
            throw new NotImplementedException();
        }

        public string Purchase(string Item, int Qty) {
            return "Ok";
        }

        public void YellAtVendor(string Msg) {
            Console.WriteLine(Msg);
        }
    }

    //Field
    class BankAccount {
        public int Fred;
    }
}
