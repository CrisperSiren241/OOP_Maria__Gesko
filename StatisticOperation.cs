using System;


namespace OOP_3_1
{
    static class StatisticOperation
    {
        public static int Minimal(this Set<char> set1, Set<char> set2, Set<char> set3)//указатель this ссылается на объект существующего класса
        {
            //Благодаря чему мы можем дополнить этот объект новыми методами
            int[] Mass = new int[3];
            Mass[0] = set1.Count;
            Mass[1] = set2.Count;
            Mass[2] = set3.Count;
            int Min = Mass.Min();
            return Min;
        }

        public static int[] Balance(this Set<char> set1, Set<char> set2, Set<char> set3)
        {
            int[] Mass = new int[3];
            Mass[0] = set1.Count;
            Mass[1] = set2.Count;
            Mass[2] = set3.Count;
            int[] Num = Mass.OrderBy(x => x).ToArray();
            return Num;
        }
    }
}
