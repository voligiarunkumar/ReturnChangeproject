using System;
using System.Collections.Generic;
using System.Text;

namespace ReturnChangeProject
{
    class GetAmountValues
    {

        //using the concept of Method overloading under polymorphism 
        public double  Tollamount(double Firstamount)
        {
            double Totalpayment = Firstamount;
            return Totalpayment;
        }
        public int Tollamount(int Firstamount,int Secondamount)
        {
            int Totalpayment = Firstamount + Secondamount;
            return Totalpayment;
        }
        public int Tollamount(int Firstamount, int Secondamount,int Thirdamount)
        {
            int Totalpayment = Firstamount + Secondamount + Thirdamount;
            return Totalpayment;
        }

    }
}
