using Tyuiu.MengAV.Sprint2.Task2.V30.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");
string region = File.ReadAllText(@"../../../../Region.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "2"},
{"{{HV}}", "30"},
{"{{TY}}", "Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится ли точка с координатами X,Y в заштрихованной области."},
{"{{TV}}", region}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

bool ins = ds.CheckDotInShadedArea(x, y);

if (ins)
{
    Console.WriteLine("Точка находится в заштрихованной области.");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области.");
}