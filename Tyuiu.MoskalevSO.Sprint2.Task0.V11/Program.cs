using Tyuiu.MoskalevSO.Sprint2.Task0.V11.Lib;

DataService ds = new DataService();

int x = 8105;
int y = 275;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("x = " + x + ", y = " + y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

bool[] res = ds.GetCompareOperations(x, y);
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();