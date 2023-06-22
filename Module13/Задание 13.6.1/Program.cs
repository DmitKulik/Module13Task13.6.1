using System.Diagnostics;

namespace Module13{
    class Program{
        static void Main(string[] args){

            LinkedList<string> l = new LinkedList<string>();
            var _list = new List<string>();

            string _testText = File.ReadAllText(@"C:\Users\uites\OneDrive\Документы\ListVSLinkedList.txt");

            var _countingForLinkedList = Stopwatch.StartNew();
            _list.Add(_testText);
            var x = _countingForLinkedList.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Связанный список: {x}");

            var _countingForList = Stopwatch.StartNew();
            _list.Add(_testText);
            var y = _countingForList.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Обычный список: {y}");
            //Разница
            var _difference = (x - y);
            Console.WriteLine($"Вставка текста в связанный список {_difference}");
        }
    }
}