using System.Runtime.ConstrainedExecution;
using thetask;
// 1)
List<int> ints = new List<int>(){1, 2, 3, 4, 5};
int sum = 0;
foreach (var item in ints)
{
    sum += item;
}
System.Console.WriteLine(sum);
// 2)
List<string> strings = new List<string>(){ "door", "window","banana", "orangejuice", "apple"};
List<string>  strings1 = strings.OrderByDescending(e => e.Length).ToList();
foreach (var item in strings1)
{
    System.Console.Write(item + " ");                                                                                                            
}
// 3)
List<Person> people = new List<Person>();
Person person1 = new Person();
person1.Name = "Maruf";
person1.Age = 16;
people.Add(person1);
Person person2 = new Person();
person2.Name = "Amir";
person2.Age = 15;
people.Add(person2);
List<Person> people1 = people.OrderBy(e => e.Age).ToList();
foreach (var item in people1)
{
    System.Console.WriteLine(item.Name);
}
// 4)
List<int> ints1 = new List<int>(){1, 2, 3, 4, 5, 6};
ints1.RemoveAll(e => e % 2 != 0);
// 5)
List<string> strings2 = new List<string>(){"maruf", "rauf", "niyazov"};
foreach (var item in strings2)
{
    System.Console.Write(item.ToUpper() + " ");
}
// 6)
List<int> ints2 = new List<int>(){1, 2, 3, 4, 5, 6};
System.Console.WriteLine(ints2.Max());
System.Console.WriteLine(ints2.Min());
// 7)
List<string> strings3 = new List<string>(){"maruf", "niyazov", "rauf"};

bool allDifferent = strings3.All(e => e.Distinct().Count() == e.Length);
System.Console.WriteLine(allDifferent);
// 8)
int s = 0;
foreach (var item in people)
{
    s += item.Age;
}
System.Console.WriteLine(s/people.Count);
// 9)
List<int> ints3 = new List<int>(){1, 2, 2, 3, 4, 5, 6, 6, 6};
List<int> ints4 = ints3.Distinct().ToList();
foreach (var item in ints4)
{
    System.Console.WriteLine(item);
}

// 10)
List<string> strings4 = new List<string>(){"mom", "dad","arra"};
bool IsAllPalindrome = strings4.All(e => e == e.Reverse());
System.Console.WriteLine(IsAllPalindrome);
// 11)
List<Person> people2 = new List<Person>();
people2.Add(person1);
people2.Add(person2);
List<Person> people3 = people2.FindAll(e => e.Age < 10);
foreach (var item in people3)
{
    System.Console.WriteLine(item);
}
// 12)
List<string> strings6 = new List<string>(){"maruf", "niyazov", "rauf"};
string concat = string.Join(";", strings6);
System.Console.WriteLine(concat);
// 13)
List<int> ints5 = new List<int>(){1, 2, 3, 4, 5};
List<int> ints6 = new List<int>();
for (int i = 0; i < ints5.Count; i++)
{
    if (i % 2 != 0)
    {
        ints6.Add(ints5[i]);
    }
}
int c = 0;
foreach (var item in ints6)
{
    c += item;
}
System.Console.WriteLine(c);
// 14)
List<string> strings5 = new List<string>(){"mom", "do", "apple", "oranjejuice"};
string str = strings5[0];
for (int i = 0; i < strings5.Count; i++)
{
    if (strings5[i].Length < str.Length)
    str = strings5[i];
}
System.Console.WriteLine(str);
// 15)

List<Person> people4 = new List<Person>();
people4.Add(person1);
people4.Add(person2);
List<Person> people5 = people4.OrderBy(e => e.Name).ToList();
// 16)
List<int> ints7 = new List<int>(){ 1, 2, 3, 4, 6, 6, 7};
int a = 10;
for (int i = 0; i < ints7.Count - 1; i++)
{
    if (ints7[i] + ints7[i + 1] == a)
    System.Console.WriteLine(ints[i] + " " + ints7[i + 1]);
}
// 17)
List<Person> people6 = people.FindAll(e => e.Age > s/people.Count);
// 18)
///////////////////////////////////////////////
// 19)
List<int> ints8 = new List<int>(){-1, 2, -3, 4, -5, 6, -7, 8};
for (int i = 0; i < ints8.Count; i++)
{
    if (ints8[i] < 0) System.Console.WriteLine(ints8[i] * -1);
    else System.Console.WriteLine(ints8[i]);
}
// 20)



