using System;

class Property_Application
{
    static void Main(string[] args)
    {
        int month_rent_amount, prop_total_cost, total_deposit, net_monthly_income, gross_monthly_income, month_tax_deductions, housing_expenditure, transportation_expenditure, insurance_expenditure, medical_expenditure, saving_expenditure; //declare global integer variables
        double interest_rate, num_months_repay, loan_amount, monthly_payment, monthly_loan_repayment; //declare global double variables

        try
        {
            Console.WriteLine("Enter your monthly income (before deductions): ");
            gross_monthly_income = Convert.ToInt32(Console.ReadLine()); //convert string input to integer

            Console.WriteLine("\nEnter your estimated monthly tax deductions: ");
            month_tax_deductions = Convert.ToInt32(Console.ReadLine()); //convert string input to integer

            Console.WriteLine("\nEnter your estimated monthly expenditure on housing: ");
            housing_expenditure = Convert.ToInt32(Console.ReadLine()); //convert string input to integer

            Console.WriteLine("\nEnter your estimated monthly expenditure on transportation: ");
            transportation_expenditure = Convert.ToInt32(Console.ReadLine()); //convert string input to integer 

            Console.WriteLine("\nEnter your estimated monthly expenditure on insurance: ");
            insurance_expenditure = Convert.ToInt32(Console.ReadLine()); //convert string input to integer 

            Console.WriteLine("\nEnter your estimated monthly expenditure on medical and health care: ");
            medical_expenditure = Convert.ToInt32(Console.ReadLine()); //convert string input to integer

            Console.WriteLine("\nEnter your estimated monthly expenditure saving, investing, & debt payments: ");
            saving_expenditure = Convert.ToInt32(Console.ReadLine()); //convert string input to integer

            //calculate net income after all deductions.
            net_monthly_income = gross_monthly_income - month_tax_deductions - housing_expenditure - transportation_expenditure - insurance_expenditure - medical_expenditure - saving_expenditure;

            //choose to rent or buy and save to a variable
            Console.WriteLine("\nChoose to rent accomodation(1) or buy property(2). Enter 1 or 2: ");
            string rent_or_buy = Console.ReadLine();

            //if user chooses rent
            if (rent_or_buy == "1")
            {
                Console.WriteLine("\nEnter the monthly rental amount: "); //monthly cost
                month_rent_amount = Convert.ToInt32(Console.ReadLine()); //convert string input to integer

                if (month_rent_amount > gross_monthly_income / 3) //if rent amount is more than the gross income divided by 3
                {
                    Console.WriteLine("\nAccomodation is not affordable.");
                    Console.WriteLine("You have R" + net_monthly_income + " left."); //display net income
                }
                else
                {
                    Console.WriteLine("\nAccomodation is affordable.");
                    Console.WriteLine("You have R" + net_monthly_income + " left."); //display net income
                }

            }
            else if (rent_or_buy == "2") //if user chooses buy
            {
                Console.WriteLine("\nEnter the total cost of the property: ");
                prop_total_cost = Convert.ToInt32(Console.ReadLine()); //convert string to integer

                Console.WriteLine("\nEnter the total deposit: ");
                total_deposit = Convert.ToInt32(Console.ReadLine()); //convert string to integer

                Console.WriteLine("\nEnter the interest rate on the property: ");
                interest_rate = Convert.ToDouble(Console.ReadLine()); //convert string to double
                interest_rate = interest_rate / 100; //divide interest rate with 100

                Console.WriteLine("\nEnter the duration of the home loan (number of months): ");
                num_months_repay = Convert.ToDouble(Console.ReadLine()); //convert string to double

                //purchase price - total deposit = loan
                loan_amount = prop_total_cost - total_deposit;
                //loan / number of months to repay = monthly payment
                monthly_payment = loan_amount / num_months_repay;
                //monthly payment + interest rate percentage = monthly payment with interest
                monthly_loan_repayment = monthly_payment + interest_rate;

                if (monthly_loan_repayment > gross_monthly_income / 3) //if monthly loan repayment is greater than 1/3 of the gross income
                {
                    Console.WriteLine("\nProperty is not affordable.");
                    Console.WriteLine("You have R" + net_monthly_income + " left."); //display net income
                }
                else //if monthly loan repayment is not greater than 1/3 of the gross income
                {
                    Console.WriteLine("\nProperty is affordable.");
                    Console.WriteLine("You have R" + net_monthly_income + " left."); //display net income
                }
            }
        }
        catch
        {
            Console.WriteLine("Please enter a number value");
        }
    }
}
        