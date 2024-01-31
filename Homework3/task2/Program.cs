List<int> ints1 = new List<int>(){1,2,3,4};
List<int> ints2 = new List<int>(){1,2,3,4};
bool Is = ints2.All(e => ints1.Contains(e));
System.Console.WriteLine(Is);