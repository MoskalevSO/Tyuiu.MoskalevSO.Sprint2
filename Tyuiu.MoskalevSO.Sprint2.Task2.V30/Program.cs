using Tyuiu.MoskalevSO.Sprint2.Task2.V30.Lib;

DataService ds = new DataService();

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x = " + x + ", y = " + y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

bool res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine(res ? "Точка в заштрихованной области" : "Точка вне заштрихованной области");
Console.ReadKey();