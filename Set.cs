using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_1
{
    internal class Set<T> : IEnumerable<T>//создаем множество с типом последовательности, так как он на 1 месте иерархии множеств
    {
        public List<T> _list = new List<T>();//создаем коллекцию данных

        public static Set<T> set = new Set<T>();

        public int Count => _list.Count;//счетчик множеств

        public void Print(Set<T> set)//передаем параметр set с типом Set<T>
        {
            foreach(var item in set)//<Т> в данном случае является обобщением всех значимых типов 
            {
                Console.Write(item);//Выводим каждый элемент множества. В нашем случае буквы
            }
        }


        public static Set<T> operator +(Set<T> set1, T item)//Перегрузка метода сложения. Ключевое слово operator говорит,
        {//что мы хотим изменить бинарную операцию сложения
            return set1.Add(item);
        }

        public static Set<T> operator -(Set<T> set1, T item)//Так как мы перегружаем бинарную операцию сложения, компилятор требует
        {//также перегрузить и разницу, так как они взаимосвязаны
            return set1.Remove(item);
        }

        public static bool operator !=(Set<T> set1, Set<T> set2)
        {
            bool result = false;
            if (set1 == set2)
            {
                return result;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Set<T> set1, Set<T> set2)
        {
            bool result = false;
            if (set1 == set2)
            {
                result = true;
                return result;
            }
            else
            {
                return result;
            }
        }

        public Set<T> Add(T item1)
        {
            if(item1 == null)//Проверка элемента на пустоту перед добавлением
            {
                throw new ArgumentNullException(nameof(item1));
            }
            
            if(!_list.Contains(item1))//Множество имеет только уникальные элементы
            {
                _list.Add(item1);//Так что если добавляемый элемент уже есть в множестве, то он игнорируется
            }

            return set;
        }

        public void Add(T item1, T item2)
        {
            if (item1 == null)
            {
                throw new ArgumentNullException(nameof(item1));
            }

            if (item2 == null)
            {
                throw new ArgumentNullException(nameof(item2));
            }

            if (!_list.Contains(item1) && !_list.Contains(item2))
            {
                _list.Add(item1);
                _list.Add(item2);
            }
        }

        public Set<T> Remove(T item1)
        {   
            if(item1 == null)
            {
                throw new ArgumentNullException(nameof(item1));
            }

            _list.Remove(item1);
            return set;
        }

        public void Remove(T item1, T item2)
        {
            if (item1 == null && item2 == null)
            {
                throw new ArgumentNullException(nameof(item1));
            }

            _list.Remove(item1);
            _list.Remove(item2);    
        }

        public static bool Subset(Set<T> set1, Set<T> set2)//Идет проверка, есть ли все элементы из множества set2 в множестве set1
        {            
            var result = set1._list.All(s => set2._list.Contains(s));
            return result;
        }

        public static bool Subset(Set<T> set1, Set<T> set2, Set<T> set3)
        {
            //Идет проверка, есть ли все элементы из множества set3 в множестве set2, а элементы множества set2 в множестве set1
            bool result = false;
            var result1 = set1._list.All(s => set2._list.Contains(s));
            var result2 = set2._list.All(s => set3._list.Contains(s));
            if(result1 == result2)
            {
                result = true;
            }
            return result;
        }

        public static bool Equal(Set<T> set1, Set<T> set2)//Проверка на неравестно множеств. Если элементы множеств неодинаковы, то выдает false
        {
            bool result = false;
            if(set1 == set2)
            {
                result = true;
                return result;
            }
            else
            {
                return result;
            }
        }

        public static bool Equal(Set<T> set1, Set<T> set2, Set<T> set3)
        {
            bool result = false;
            if (set1 == set2 && set2 == set3 && set1 == set3)
            {
                result = true;
                return result;
            }
            else
            {
                return result;
            }
        }

        public static Set<T> Intersection(Set<T> set1, Set<T> set2)//В методе создается множество, которые будет содержать общие элементы множества Set1 и множества Set2
        {
            Set<T> result = new Set<T>();//Создается новое множество

            if (set1 == null)//Проверка на пустоту
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            if (set1.Count < set2.Count)//Если множество set2 больше set1, то ищут общие элементы из set1 для set2
            {
                foreach(var item in set1._list)
                {
                    if(set2._list.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
            else
            {
                foreach(var item in set2._list)//Обратный случай, если Set2 меньше set1
                {
                    if(set1._list.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
            
            return result;//Метод возвращает полученное множество
        }

        public static Set<T> Intersection(Set<T> set1, Set<T> set2, Set<T> set3)//То же самое только с 3 множествами
        {
            Set<T> result = new Set<T>();

            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            if (set3 == null)
            {
                throw new ArgumentNullException(nameof(set3));
            }

            if (set1.Count < set2.Count)
            {
                foreach (var item in set1._list)
                {
                    if (set2._list.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in set2._list)
                {
                    if (set1._list.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }

            if (set2.Count < set3.Count)
            {
                foreach(var item2 in set2._list)
                {
                    if (set3._list.Contains(item2))
                    {
                        result.Add(item2);
                    }
                }
            }
            else
            {
                foreach(var item2 in set3._list)
                {
                    if(set2._list.Contains(item2))
                    {
                        result.Add(item2);
                    }
                }
            }

            return result;
        }

        public void Product()
        {
            Production Org = new Production();
            Console.WriteLine("Организация: " + Org.Organization);
            Console.WriteLine("Идентификационный номер: " + Org.id);
        }

        public class Developer
        {
            public Guid id = Guid.NewGuid();
            public string Name = "Геско Мария";
            public string part = "Разработчик";
            public void PrintDev()
            {
                Console.WriteLine("ФИО: " + Name);
                Console.WriteLine("Идентификационный номер: " + id);
                Console.WriteLine("Отдел: " + part);
            }
        }

        public IEnumerator<T> GetEnumerator()//Необходимые методы для последовательности, так как они помогают нам обращаться к множествам и их элементам
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

    }
    public class Production
        {
            public Guid id = Guid.NewGuid();
            public string Organization = "EmCake";
            public void Print()
            {
                Console.WriteLine("Организация: {0}", Organization);
                Console.WriteLine("Идентификационный номер: {0}", id);
            }
        }
}
