using Tyuiu.MoskalevSO.Sprint2.Task1.V2.Lib;

DataService ds = new DataService();

int a = 135;
int b = 156;
int c = 154;
int d = 174;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c + ", d = " + d);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

bool[] res = ds.GetLogicOperations(a, b, c, d);
for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();