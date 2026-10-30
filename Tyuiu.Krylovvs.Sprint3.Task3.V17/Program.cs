using System.Text;
using Tyuiu.Krylovvs.Sprint3.Task3.V17.Lib;

DataService Examp = new DataService();
double Res = Examp.ConvertStringToInt("*vn98n! b,");

Dictionary<string, string> PlaceHolders = new Dictionary<string, string>
{
    {"{{THEME_PLACEHOLD}}","Оператор цикла foreach"},
    {"{{QUEST_NUM}}","2"},
    {"{{VAR_NUM}}","21"},
    {"{{CONDITIONS}}","Используя цикл foreach удалить все буквы и знаки препинания, " +
    "оставить цифру затем преобразовать в число в строке: *vn98n! b,"},
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

