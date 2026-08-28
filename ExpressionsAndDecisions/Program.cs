const double COMMISSION = .07;
const double MIN_COMMISION_SALE = 10000;

Console.Write("What is sale amount? ");
double sale_amount = double.Parse(Console.ReadLine());

// Variable for holding Justin's earning
double commission = 0;

//  Calculate the commissions only if sale is above $10,000
if (sale_amount >= MIN_COMMISION_SALE)
{
    commission = sale_amount * COMMISSION;
}

// :c is for $ currency
Console.WriteLine($"Justin's commission for a sale of {sale_amount:c} is {commission:c}");
