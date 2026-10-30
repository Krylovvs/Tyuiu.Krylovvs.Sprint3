using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task5.V24.Lib;

DataService Examp = new DataService();
double Res = Examp.GetSumSumSeries(2, 1, 1, 3, 12);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Вложенные циклы"},
    {"{{QUEST_NUM}}","5"},
    {"{{VAR_NUM}}","24"},
    {"{{CONDITIONS}}","Да"},
    {"{{ENTER_DATA1_ARRAY}}","2, 1, 1, 3, 12"},
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

