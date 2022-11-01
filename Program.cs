using System;

namespace OOP_3_1
{
    class Program
    {
        static void Main()
        {
            char symU = 'U';
            char symL = 'L';
            char symJ = 'J';
            char symM = 'M';
            char symA = 'A';
            char symN = 'N';
            
            var set1 = new Set<char>()
            {
                'G','R','A','Y',' ','M','E','N'
            };


            var set2 = new Set<char>()
            {
                'M','A','N','G','O',   
            };

            var set3 = new Set<char>()
            {
                'R','I','N','G'
            };

            set1.Product();

            Set<char>.Developer Dev = new Set<char>.Developer();
            Dev.PrintDev();

            Console.WriteLine("\n");
            
            Console.WriteLine("Первое множество");
            set1.Print(set1);

            Console.WriteLine("\nВторое множество");
            set2.Print(set2);


            Console.WriteLine("\nТретье множество");
            set3.Print(set3);


            Console.WriteLine("\nПервое множество после добавление одного элемента");
            set1.Add(symU);
            set1.Print(set1);

            Console.WriteLine("\nПервое множество после добавление двух элементов");
            set1.Add(symJ, symL);
            set1.Print(set1);

            Console.WriteLine("\nУдаление одного элемента из второго множества");
            set2.Remove(symM);
            set2.Print(set2);

            Console.WriteLine("\nУдаление двух элементов из второго множества");
            set2.Remove(symA, symN);
            set2.Print(set2);

            Console.WriteLine("\nПроверка на неравенство первого и второго множества");
            Console.WriteLine(Set<char>.Equal(set1,set2));

            Console.WriteLine("\nПроверка на неравенство первого, второго и третьего множества");
            Console.WriteLine(Set<char>.Equal(set1, set2, set3));

            Console.WriteLine("\nПроверка на множество первого и второго множества");
            Console.WriteLine(Set<char>.Subset(set1, set2));

            Console.WriteLine("\nПроверка на множество первого, второго и третьего множества");
            Console.WriteLine(Set<char>.Subset(set1, set2, set3));

            Console.WriteLine("\nПересечение первого и второго множества");
            Set<char> intersection = Set<char>.Intersection(set1, set2);
            set1.Print(intersection);

            Console.WriteLine("\nПересечение первого, второго и третьего множества");
            Set<char> intersection1 = Set<char>.Intersection(set1, set2, set3);
            set1.Print(intersection1);

            set1 = new Set<char>()
            {
                'G','R','A','Y',' ','M','E','N'
            };


            set2 = new Set<char>()
            {
                'M','A','N','G','O',
            };

            set3 = new Set<char>()
            {
                'R','I','N','G'
            };

            Console.WriteLine("Кол-во буков самого короткого слова");
            Console.WriteLine(set1.Minimal(set2, set3));
            Console.WriteLine("Порядок слов по возрастанию");
            Console.WriteLine(set1.Balance(set2, set3));
            
        }
    }
}