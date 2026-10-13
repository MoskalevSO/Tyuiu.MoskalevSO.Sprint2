using Tyuiu.MoskalevSO.Sprint2.Task5.V7.Lib;

DataService ds = new DataService();

Console.Write("Введите количество месяцев n: ");
int n = Convert.ToInt32(Console.ReadLine());
int days = 2;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("n = " + n);
Console.WriteLine("days = " + days);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

string res = ds.FindMonthName(n, days);
Console.WriteLine(res);

Console.ReadKey();