using Tyuiu.MengAV.Sprint2.Task2.V30.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "1"},
{"{{HV}}", "16"},
{"{{TY}}", "Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую последовательность(массив): (True, True, True, False, True, False), при a = 145, b = 716, c = 144, d = 137"},
{"{{TV}}", "a = 145, b = 716, c = 144, d = 137"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion