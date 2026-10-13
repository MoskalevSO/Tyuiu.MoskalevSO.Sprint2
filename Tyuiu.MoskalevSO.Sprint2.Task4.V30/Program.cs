using Tyuiu.MoskalevSO.Sprint2.Task4.V30.Lib;

DataService ds = new DataService();

Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x = " + x + ", y = " + y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

double res = ds.Calculate(x, y);
Console.WriteLine("z = " + res);
Console.ReadKey();