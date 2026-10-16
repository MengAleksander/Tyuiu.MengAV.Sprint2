using Tyuiu.MengAV.Sprint2.Task0.V12.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "0"},
{"{{HV}}", "12"},
{"{{TY}}", "Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False), при x = 1095, y = 475"},
{"{{TV}}", "x = 1095, y = 475"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

bool[] res = ds.GetCompareOperations(1095, 475);
Console.WriteLine(string.Join(", ", res)); 