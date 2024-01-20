using firstproject;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

//18 JAN summary
/*
//data types

//var sayi = 1;
//byte byteName1 = 255; // 0 to 255
//short shortName1 = 32767; // -32768 to 32767
//ushort ushortName1 = 65535; //0 to 65535
//int int1 = 0;
//float float1 = 1.0f; // 32 bit have to write  "f or F" after number
//double double1= 1.0; //64 bit more sensitive for huge numbers if we compared to float
//decimal d1 = 0.15m; // for dot and comma (money transformation)

//Date Library

//var date = DateTime.Now;
//Console.WriteLine(" 12 saatlik zaman dilimi kullanırken hh =>" + date.ToString("yyyy-MM-dd hh:mm:ss tt")); //tt ös öö  hh 12 24 saatlik kullanim
//Console.WriteLine("  24 saatlik zaman dilimi kullanırken hh " + date.ToString("yyyy-MM-dd HH:mm:ss"));
//Console.WriteLine(date.ToString());
//date = DateTime.UtcNow;
//Console.WriteLine(" GREEN WICH TIME ZONE UNIVERSAL"+date.ToString("yyyy-MM-dd hh:mm:ss"));
//Console.WriteLine(" GREEN WICH TIME ZONE UNIVERSAL " + date.ToString("yyyy-MM-dd HH:mm:ss"));

// how to use var object dynamic 

var obj = new { test = "key" };
//obj.test="assd";
dynamic dynamicObj = new { test = "key" };
Console.WriteLine(obj.ToString());
Console.WriteLine(obj.GetType().Name);

// class accesibility  
// public private protected internal 
var obj = new User();
//obj.test = "deneme";
Console.WriteLine(obj.test);
*/
/*
Banka Uygulaması
IBaseBank bank = new ZiraatBank();
bank.AddMoney(15);
bank.SpendMoney(5);
Console.WriteLine(bank.Money);
if(bank is ITosunBank)
{
var nBank = (bank as ITosunBank);
nBank.BuyChicken();
Console.WriteLine(bank.Money);
}
*/

var user = UserFactory.GetInstance(UserTypeEnum.Personal);
user.UserName = "bahribas";
user.Password = "123";
user.IsActive = true;

Console.WriteLine(user.GetType().Name);
if(user is IPersonal)
{
    var personal = (IPersonal)user;
    personal.Salary = 250;
    personal.CalculateSalaryWithDebt(20,100);
}
Console.WriteLine(JsonConvert.SerializeObject(user));

Console.ReadKey();
public static class UserExtensions
{
    public static void CalculateSalaryWithDebt(this IPersonal personal, short workHours,int debt)
    {
        Console.WriteLine(personal.Salary* workHours - debt);
    }
}