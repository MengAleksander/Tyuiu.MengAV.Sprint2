using Tyuiu.MengAV.Sprint2.Task5.V13.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "5"},
{"{{HV}}", "13"},
{"{{TY}}", "Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат."},
{"{{TV}}", "Дата некоторого дня характеризуется тремя натуральными числами: g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m определить дату следующего дня. Заданный год является високосным."}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите год: ");
int g = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер месяца: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

try
{
    string nextDay = ds.FindDateOfNextDay(g, m, n);
    Console.WriteLine($"Следующий день: {nextDay}");
}
catch (ArgumentOutOfRangeException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
}