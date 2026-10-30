using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib;

DataService Examp = new DataService();
double Res = Examp.GetMultiplySeries(1, 1);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Оператор цикла while"},
    {"{{QUEST_NUM}}","1"},
    {"{{VAR_NUM}}","5"},
    {"{{CONDITIONS}}","Написать программу используя цикл while," +
    " которая вычисляет произведение ряда по формуле"},
    {"{{ENTER_DATA1_ARRAY}}","x = 1, y = 1"},
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

