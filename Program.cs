// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



Console.WriteLine("//1. Iterate and print values----------");


static void PrintList(List<string> MyList)
{
    foreach (string i in MyList)
        Console.WriteLine(i);
}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);




Console.WriteLine("//2. Print Sum-------------");

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;

    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);




Console.WriteLine("// 3. Find Max------------");


static int FindMax(List<int> IntList)
{
    int maxValue = IntList.Max();
    Console.WriteLine(maxValue);
    return maxValue;
}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);






Console.WriteLine("//4. Square the Values-------------");


static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] *= IntList[i];
    }
    foreach (int sq in IntList)
    {
        Console.WriteLine(sq);
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);





Console.WriteLine("//5. Replace Negative Numbers with 0----------");
static int[] NonNegatives(int[] IntArray)
{
    for(int i=0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }

    }
    Console.WriteLine(string.Join(",", IntArray));
    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);



Console.WriteLine("//6. Print Dictionary----------");
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (var kvp in MyDictionary)
    {
        Console.WriteLine(kvp);
    }

}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);




Console.WriteLine("//7. Find Key------------");
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        if (entry.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));




Console.WriteLine("//8. Generate a Dictionary-------------");
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 

List<string> names = new List<string> { "Julie", "Harold", "James", "Monica" };
List<int> numbers = new List<int> { 6, 12, 7, 10 };

Dictionary<string, int> nameNumDict = GenerateDictionary(names, numbers);
foreach (var kvp in nameNumDict)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> nameNumDict = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        nameNumDict[Names[i]] = Numbers[i];
    }
    return nameNumDict;
}



