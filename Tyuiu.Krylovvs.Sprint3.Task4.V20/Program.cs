using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task4.V20.Lib;

DataService Examp = new DataService();
double Res = Examp.Calculate(0, 1);

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Использование операторов continue и break в циклах"},
    {"{{QUEST_NUM}}","4"},
    {"{{VAR_NUM}}","20"},
    {"{{CONDITIONS}}","На отрезке, где x принимает значения от -5 до 5, " +
    "вычислить значение функции y=x/(cos(x) - x)+2,5 При х = 0 " +
    "пропустить значение. Полученные значения перемножать"},
    {"{{ENTER_DATA1_ARRAY}}","\"*vn98n! b,\""},
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

