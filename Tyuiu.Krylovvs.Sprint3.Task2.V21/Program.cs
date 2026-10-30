using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task0.V13.Lib;

DataService Examp = new DataService();
double Res = Examp.GetSumSeries(1.5, 1, 10);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Оператор цикла do while"},
    {"{{QUEST_NUM}}","2"},
    {"{{VAR_NUM}}","21"},
    {"{{CONDITIONS}}","Написать программу используя цикл do...while," +
    " которая вычисляет сумму ряда по формуле, при х=1,5"},
    {"{{ENTER_DATA1_ARRAY}}","x = 1.5, y = 1, z = 10"},
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

