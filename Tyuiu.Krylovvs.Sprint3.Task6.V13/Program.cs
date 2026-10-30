using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task6.V13.Lib;

DataService Examp = new DataService();
double Res = Examp.GetSumTheDivisors(8, 17);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Вложенные циклы"},
    {"{{QUEST_NUM}}","6"},
    {"{{VAR_NUM}}","13"},
    {"{{CONDITIONS}}","Напишите программу, которая ищет среди целых чисел," +
    "принадлежащих числовому отрезку [8, 17] сумму всех делителей больше 8"},
    {"{{ENTER_DATA1_ARRAY}}","8, 17"},
    {"{{OUT_DATA_ARRAY}}",string.Join(",",Res)}
};

Console.Title = "Спринт #3 | Выполнил: Крылов В.С. | ПИНб-26-1";
//huh
var Text = File.ReadAllText(@"..\..\..\..\Ender.txt", Encoding.UTF8);

foreach (var i in PlaceHolders)
{
    Text = Text.Replace(i.Key, i.Value);
}

Console.WriteLine(Text);
Console.ReadKey();

