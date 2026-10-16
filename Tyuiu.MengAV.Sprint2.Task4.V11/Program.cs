using Tyuiu.MengAV.Sprint2.Task4.V11.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "4"},
{"{{HV}}", "11"},
{"{{TY}}", "Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора, где пользователь вводит значение переменных x, y с клавиатуры."},
{"{{TV}}", "если x - 20 * 2 < y / 4, то z = (3 + 8 / x^2)^y, иначе y - ((x + 1) / (y + 2))^x"}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

try
{
    double z = ds.Calculate(x, y);

    Console.WriteLine($"z = {z:F3}");
}
catch (ArgumentException exception)
{
    Console.WriteLine($"Ошибка: {exception.Message}");
}