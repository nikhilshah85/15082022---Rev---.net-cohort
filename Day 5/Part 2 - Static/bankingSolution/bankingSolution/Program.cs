
using bankingDLL;

Console.WriteLine("Welcome to Banking");

//Savings accObj = new Savings("John", "Murray", 6000, 5050);
//Console.WriteLine(accObj.accNo);

//Console.WriteLine("Before : " + accObj.accBalance);
//try
//{
//    accObj.Deposit(-300);
//}
//catch(Exception es)
//{
//    Console.WriteLine(es.Message);
//}
//Console.WriteLine("After : " + accObj.accBalance);


Savings sav = new Savings("nik", "shah", 5000, 6060);
Savings sav1 = new Savings("nik", "shah", 5000, 6060);
Savings sav2 = new Savings("nik", "shah", 5000, 6060);
Savings sav3 = new Savings("nik", "shah", 5000, 6060);
Savings sav4 = new Savings("nik", "shah", 5000, 6060);
Savings sav5 = new Savings("nik", "shah", 5000, 6060);
Console.WriteLine(sav.accNo);
Console.WriteLine(sav1.accNo);
Console.WriteLine(sav2.accNo);
Console.WriteLine(sav3.accNo);
Console.WriteLine(sav4.accNo);
Console.WriteLine(sav5.accNo);



Checking chk1 = new Checking("nik", "shah", 5000, 6060);
Checking chk2 = new Checking("nik", "shah", 5000, 6060);

Loan ln = new Loan("housing");
Loan ln1 = new Loan("housing");
Loan ln2 = new Loan("housing");

Console.WriteLine(chk1.accNo);
Console.WriteLine(chk2.accNo);

Console.WriteLine(ln.accNo);
Console.WriteLine(ln1.accNo);
Console.WriteLine(ln2.accNo);






