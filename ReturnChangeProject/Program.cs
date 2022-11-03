using System;
using System.Runtime.InteropServices;

namespace ReturnChangeProject
{
  public class Program
  {
       public static void Main(string[] args)
       {
            CaluculateChange caluculateobject = new CaluculateChange();
            Productprice prodcutobject = new Productprice();
            CustomerDetails customerdetailobject = new Customers();
            GetAmountValues obj4 = new GetAmountValues();
            Console.WriteLine("Enter your RentalID");
            Console.WriteLine("-----------------------------------------");
            int EmployeeID=int.Parse(Console.ReadLine());
            customerdetailobject.CheckcustomerDetails(EmployeeID);
            prodcutobject.ProductCost1 = 38.83;
            prodcutobject.ProductCost2 = 120;
            prodcutobject.ProductCost3 = 130;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1)pending tollamount1" + " " + prodcutobject.product1 + " "+"Cost"+" " +prodcutobject.ProductCost1);
            Console.WriteLine("2)pending tollamount2" + " " + prodcutobject.product2 + " "+"Cost"+" " + prodcutobject.ProductCost2);
            Console.WriteLine("3)pending tollamount3" + " " + prodcutobject.product3 + " "+"Cost"+" " + prodcutobject.ProductCost3);
            Console.WriteLine("Select any of the toll to pay dues:\npress tollamount number to pay due:");
            Console.WriteLine("OR\n4)For payment of First one\n5)For payment of First Two\n6)For First Threee Payment:");
            int selectednumber = int.Parse(Console.ReadLine());
            switch (selectednumber)
            {
                case 1:
                    Console.WriteLine("you have selected tollamount1\nEnter amount to pay");
                    int CustomerEnteredCost = int.Parse(Console.ReadLine());
                    if (CustomerEnteredCost == prodcutobject.ProductCost1)
                    {
                        Console.WriteLine("You have paid correct amount change you would get is in Rupees: 0.00");
                    }
                    if(CustomerEnteredCost <prodcutobject.ProductCost1)
                    {
                        Console.WriteLine("You have entered lower amount then your due");
                    }
                    else
                    {
                        caluculateobject.Caluculation(CustomerEnteredCost, prodcutobject.ProductCost1);
                    } 
                    break;
                case 2:
                    Console.WriteLine("you have selected tollamount2\nEnter amount to pay");
                    int CustomerEnteredCost1 = int.Parse(Console.ReadLine());
                    if (CustomerEnteredCost1 == prodcutobject.ProductCost2)
                    {
                        Console.WriteLine("You have paid correct amount change you would get is in Rupees: 0.00");
                    }
                    if (CustomerEnteredCost1 < prodcutobject.ProductCost1)
                    {
                        Console.WriteLine("You have entered lower amount then your due");
                    }
                    else
                    {
                        caluculateobject.Caluculation(CustomerEnteredCost1, prodcutobject.ProductCost2);
                    }
                    break;
                case 3:
                    Console.WriteLine(" you have selected tollamount3\nEnter amount to pay");
                    int CustomerEnteredCost3 = int.Parse(Console.ReadLine());
                    if(CustomerEnteredCost3 == prodcutobject.ProductCost3)
                    {
                        Console.WriteLine("You have paid correct amount change you would get is in Rupees: 0.00");
                    }
                    if (CustomerEnteredCost3 < prodcutobject.ProductCost1)
                    {
                        Console.WriteLine("You have entered lower amount then your due");
                    }
                    else
                    {
                        caluculateobject.Caluculation(CustomerEnteredCost3, prodcutobject.ProductCost3);
                    }
                    break;
                case 4:
                    Console.WriteLine("You have selected payment of first one toll amount");
                    double Totalvalue=obj4.Tollamount(prodcutobject.ProductCost1);
                    Console.WriteLine("Your total amount is for first one payment is" + Totalvalue+"\nEnter amount That want to pay:");
                    int CustomerEnteredamount = int.Parse(Console.ReadLine());
                    if (CustomerEnteredamount >=Totalvalue)
                    {
                        caluculateobject.Caluculation(CustomerEnteredamount, Totalvalue);
                    }
                    else
                    {
                        Console.WriteLine("You have entered lower amount");
                    }
                    break;
                case 5:
                    Console.WriteLine("You have selected payment of first two toll amount");
                    double Totalvalue1 = obj4.Tollamount((int)(prodcutobject.ProductCost1),prodcutobject.ProductCost2);
                    Console.WriteLine("Your total amount is for first one payment is" + Totalvalue1 + "\nEnter amount That want to pay:");
                    int CustomerEnteredamount1= int.Parse(Console.ReadLine());
                    if (CustomerEnteredamount1 >= Totalvalue1)
                    {
                        caluculateobject.Caluculation(CustomerEnteredamount1, Totalvalue1);
                    }
                    else
                    {
                        Console.WriteLine("You have entered lower amount");
                    }
                    break;
                case 6:
                    Console.WriteLine("You have selected payment of first three toll amount");
                    double Totalvalue2 = obj4.Tollamount((int)(prodcutobject.ProductCost1), prodcutobject.ProductCost2,prodcutobject.ProductCost3);
                    Console.WriteLine("Your total amount is for first one payment is" + Totalvalue2 + "\nEnter amount That want to pay:");
                    int CustomerEnteredamount2 = int.Parse(Console.ReadLine());
                    if (CustomerEnteredamount2 >= Totalvalue2)
                    {
                        caluculateobject.Caluculation(CustomerEnteredamount2, Totalvalue2);
                    }
                    else
                    {
                        Console.WriteLine("You have entered lower amount");
                    }
                    break;
            }
       }
  }
}
