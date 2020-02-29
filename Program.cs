using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Estimate estimateOne = new Estimate();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter your name: ");
            estimateOne.dogOwner = Console.ReadLine();
            Console.WriteLine("Please enter your dog's name: ");
            estimateOne.dogName = Console.ReadLine();
            Console.WriteLine("Please enter your dog's weight in pounds: ");
            estimateOne.dogWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of days your dog will be with us: ");
            estimateOne.dogDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like no add-ons please enter N: ");
            Console.WriteLine("If you would like a bathing add-on please enter C: ");
            Console.WriteLine("If you would like a bathing and grooming add-on please enter A: ");
            estimateOne.addOn = Console.ReadLine();

            estimateOne.EstimateCalc();

            Console.WriteLine();
            Console.WriteLine("Dog Owner's Name: {0}", estimateOne.dogOwner);
            Console.WriteLine("Dog's Name: {0}", estimateOne.dogName);
            Console.WriteLine("Dog's Weight: {0} lbs.", estimateOne.dogWeight);
            Console.WriteLine("Number Days: {0}", estimateOne.dogDays);
            Console.WriteLine("Package: {0}", estimateOne.addOn);
            Console.WriteLine();
            Console.WriteLine("Estimate Total:");
            Console.WriteLine(estimateOne.cost.ToString("C"));

        }
    }
    class Estimate
    {
        public string dogOwner {get;set;}
        public string dogName {get;set;}
        public int dogWeight {get;set;}
        public int dogDays {get;set;}
        public string addOn {get;set;}
        public int cost {get;set;}

    

        public void EstimateCalc(){

            if (addOn == "N"){
                cost = 75 * dogDays;
            }
            else if (addOn == "A"){
                cost = 169 * dogDays;
            }
            else{
                cost = 112 * dogDays;
            }
        }
        


    }
}
