using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib;

DataService Examp = new DataService();
double Res = Examp.GetSumSeries(0.5, 1, 1);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Оператор цикла for"},
    {"{{QUEST_NUM}}","0"},
    {"{{VAR_NUM}}","13"},
    {"{{CONDITIONS}}","Написать программу используя цикл for," +
    " которая вычисляет сумму ряда по формуле, при a = 0,5"},
    {"{{ENTER_DATA1_ARRAY}}","x = 0.5, y = 1, z = 1"},
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

