using Tyuiu.MengAV.Sprint2.Task7.V7.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "7"},
{"{{HV}}", "7"},
{"{{TY}}", "Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет, находится ли точка с координатами X,Y в заштрихованной области."},
{"{{TV}}", "То есть область находится выше прямой y = x и ниже параболы y = 2 - x^2, между точками их пересечения (-2, -2) и (1, 1)."}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (ds.CheckDotInShadedArea(x, y))
    Console.WriteLine("Точка находится в заштрихованной области.");
else
    Console.WriteLine("Точка не находится в заштрихованной области.");