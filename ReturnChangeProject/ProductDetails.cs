using System;
using System.Collections.Generic;
using System.Text;

namespace ReturnChangeProject
{
 
    //using concepts of properties
    public  class Products
        {

            public String product1;
            public String product2;
            public String product3;
        //using the concept of constructor
             public Products()
             {
              product1 = "Toll1";
              product2 = "Toll2";
              product3 = "Toll3";

             }
        }
    //using the concept of inheritance
        class Productprice : Products
        {
          //using some concepts of encaptulation.
            private double product1cost;
            private int product2cost;
            private int product3cost;
            public double ProductCost1
            {
                set
                {
                    product1cost = value;
                }
                get
                {
                    return product1cost;
                }
            }
            public int ProductCost2
            {
                set
                {
                    product2cost = value;
                }
                get
                {
                    return product2cost;
                }
            }
            public int ProductCost3
            {
                set
                {
                    product3cost = value;
                }
                get
                {
                    return product3cost;
                }
            }



        }

    }
