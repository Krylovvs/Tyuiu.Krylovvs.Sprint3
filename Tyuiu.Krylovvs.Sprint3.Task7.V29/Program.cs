using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task7.V29.Lib;

DataService Examp = new DataService();
double[] Res = Examp.GetMassFunction(0, 0);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Добавление к решение итоговых проектов по спринту"},
    {"{{QUEST_NUM}}","7"},
    {"{{VAR_NUM}}","29"},
    {"{{CONDITIONS}}","Значения занести в массив!"},
    {"{{ENTER_DATA1_ARRAY}}","0, 0"},
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

