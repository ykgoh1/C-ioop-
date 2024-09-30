using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment__Worker_
{
    public class PriceCalculator
    {
        public List<ServiceFee> CalculateFees(List<ServiceSelection> selections, bool isUrgent) 
        {
            List<ServiceFee> fees = new List<ServiceFee>(); //declare an empty list

            foreach (var selection in selections) //Calculate the fees for each selected service one by one
            {

                double fee;
                if (IsDiscountApplicable(selection.ServiceName, selection.Amount, selection.Size)) //Call method to check if discount is applicable
                {
                    fee = CalculateFeeWithDiscount(selection.ServiceName, selection.Amount, selection.Size); //If yes, call method to calculate discounted fees
                }
                else
                {
                    fee = CalculateFeeWithoutDiscount(selection.ServiceName, selection.Amount, selection.Size); //If no, call method to calcualte fees without discount
                }

                //Add 30% surcharge if it's urgent
                if (isUrgent)
                {
                    fee *= 1.30;
                }

                fees.Add(new ServiceFee //Store the post-calculation results for each selected service into the list
                {
                    ServiceName = selection.ServiceName,
                    Amount = selection.Amount,
                    Fee = fee,
                    Size = selection.Size
                });
            }

            return fees; //return the results
        }

        private bool IsDiscountApplicable(string serviceName, int amount, string size) //Return true when the conditions for discount is met
        {
            switch (serviceName)
            {
                case "Printing A4 – Black and White":
                case "Printing A4 - Color":
                case "Printing - Poster" when size == "A0" || size == "A1" || size == "A02" || size == "A03":
                    return amount > 100;
                default:
                    return false;
            }
        }
        private double CalculateFeeWithoutDiscount(string serviceName, int amount, string size) //Calculation when discount is not applicable
        {
            double feePerUnit = 0;

            switch (serviceName)
            {
                case "Printing A4 – Black and White":
                    feePerUnit = 0.80;
                    break;
                case "Printing A4 – Color":
                    feePerUnit = 2.50;
                    break;
                case "Binding – Comb Binding":
                    feePerUnit = 5.50;
                    break;
                case "Binding – Thick Cover":
                    feePerUnit = 9.30;
                    break;
                case "Printing - Poster" when size == "A0" || size == "A1":
                    feePerUnit = 6.00;
                    break;
                case "Printing - Poster" when size == "A2" || size == "A3":
                    feePerUnit = 3.00;
                    break;
                default:
                    throw new ArgumentException("Unknown service type: " + serviceName);
            }

            return Math.Round(amount*feePerUnit, 2); //Round up to 2 decimal places
        }
        private double CalculateFeeWithDiscount(string serviceName, int amount, string size) //Calculation when discount is applicable
        {
            double feeWithoutDiscount = CalculateFeeWithoutDiscount(serviceName, amount, size);
            return feeWithoutDiscount*0.9;
        }
    }
    public class ServiceFee //Store the details of selected services along with the calculated fees
    {
        public string ServiceName { get; set; }
        public int Amount { get; set; }
        public double Fee { get; set; }
        public string Size { get; set; }
    }

    public class ServiceSelection //Fetch the details of selected services in SubmitRequestForm (fees not yet calculated)
    {
        public string ServiceName { get; set; }
        public int Amount { get; set; }
        public string Size { get; set; }
    }
}
