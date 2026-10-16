using Tyuiu.MengAV.Sprint2.Task6.V15.Lib;

DataServies ds = new DataServies();

#region Шапка
string text = File.ReadAllText(@"../../../../TXT.txt");

Dictionary<string, string> zam = new Dictionary<string, string>
{{"{{HZ}}", "6"},
{"{{HV}}", "15"},
{"{{TY}}", "Написать программу, которая использует сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат."},
{"{{TV}}", "Дано целое число k (1 <= k <= 365). Определить, каким днем недели (понедельником, вторником, …, субботой или воскресеньем) является k-й день не високосного года, в котором 1 января понедельник."}};

foreach (var key in zam)
{
    text = text.Replace(key.Key, key.Value);
}

Console.WriteLine(text);
#endregion

Console.Write("Введите k (от 1 до 365): ");
int k = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine(ds.FindDayName(k));
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Ошибка: k должно быть от 1 до 365.");
}