using Tyuiu.MoskalevSO.Sprint2.Task3.V23.Lib;

DataService ds = new DataService();

Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x = " + x);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

double res = ds.Calculate(x);
Console.WriteLine("y = " + res);
Console.ReadKey();