using Tyuiu.MengAV.Sprint2.Task3.V12.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");
string yravnenie = File.ReadAllText(@"../../../../Yravnenie.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "3"},
{"{{HV}}", "12"},
{"{{TY}}", "Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой;"},
{"{{TV}}", yravnenie}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

try
{
    double y = ds.Calculate(x);
    Console.WriteLine($"y = {y:F3}");
}
catch (ArgumentOutOfRangeException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
}