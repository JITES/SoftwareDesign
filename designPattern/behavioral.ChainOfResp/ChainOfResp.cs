using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.behavioral.ChainOfResp
{
    class Purchase
    {
        private int _number;
        private double _amount;
        private string _purpose;

        // Constructor
        public Purchase(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

        // Gets or sets purchase number
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Gets or sets purchase amount
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        // Gets or sets purchase purpose
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }

    abstract class Approver
    {
        protected Approver sucessor;

        public void SetSucessor(Approver sucessor) => this.sucessor = sucessor;

        public abstract void ProcessRequest(Purchase purchase);
    }

    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 1000)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else if (sucessor != null)
            {
                sucessor.ProcessRequest(purchase);
            }
        }
    }

    class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 2000)
            {
                Console.WriteLine("{0} approved request #{1}",this.GetType().Name,purchase.Number);
            }
            else if(sucessor!= null)
            {
                sucessor.ProcessRequest(purchase);
            }
        }
    }

    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount > 2000 && purchase.Amount < 500000)
            {
                Console.WriteLine("{0} approved request #{1}", this.GetType().Name, purchase.Number);
            }
            else if (sucessor != null)
            {
                /// Execution will never reach to this code as there no sucessor of President hence _sucessor is null
                Console.WriteLine("Forget about it");
            }
        }
    }

    class ChainOfResp
    {
        static void DMain()
        {
            Approver _director = new Director();
            Approver _vp = new VicePresident();
            Approver _jitesh = new President();

            _director.SetSucessor(_vp);
            _vp.SetSucessor(_jitesh);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            _director.ProcessRequest(p);

            p = new Purchase(2035, 1500, "Employee Outing");
            _director.ProcessRequest(p);

            p = new Purchase(2036, 55100.00, "Acquisition");
            _director.ProcessRequest(p);

            p = new Purchase(2037, 100000000, "Dreamland");
            _director.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
