using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p618
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "Park");
            scope.SetVariable("p", "010-0000-0000");
            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard:
    name = ''
    phone = ''

    def __init__(self, name, phone):
        self.name = name
        self.phone = phone

    def printNameCard(self):
        print(self.name + ', ' + self.phone)

NameCard(n, p)
");
            dynamic result = source.Execute(scope);
            result.printNameCard();

            WriteLine("{0}, {1}", result.name, result.phone);


            ReadLine();
        }
    }
}