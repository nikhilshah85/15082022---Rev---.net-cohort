
using bankingDLL;

Console.WriteLine("Welcome to Banking");

Accounts accObj = new Accounts(101, "John", "Murray", 6000, 5050);
Console.WriteLine("Before : " + accObj.accBalance);
try
{
    accObj.Deposit(-300);
}
catch(Exception es)
{
    Console.WriteLine(es.Message);
}
Console.WriteLine("After : " + accObj.accBalance);




