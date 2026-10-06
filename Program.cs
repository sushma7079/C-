namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // TODO 1: Declare your name
            string userName = "Sushma";

            // TODO 2: Declare your favourite single-digit number
            int luckyNumber = 5;

            // TODO 3: Print using string interpolation
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        // Task 2
    Circle circle = new Circle();

    Console.WriteLine($"PI = {Circle.PI}");

// ---- Task 3: data types and type conversion ----

byte tiny = 200;
short small = 30000;

int whole = 123456;
long bigWhole = 9876543210L;
float decimalFloat = 3.14f;
double decimalDouble = 3.14159;
decimal money = 99.99m;
char letter = 'A';
bool isStudent = true;

Console.WriteLine($"byte   = {tiny}      (type: byte)");
Console.WriteLine($"short  = {small}     (type: short)");

string numberText = 42.ToString();
Console.WriteLine($"42 as string = {numberText}");

double parsedNumber = double.Parse("3.14");
Console.WriteLine($"Parsed double = {parsedNumber}");

int[] numbers = { 42, 7, 19, 3, 88 };
Console.WriteLine($"Original : {string.Join(", ", numbers)}");

Array.Sort(numbers);
Console.WriteLine($"Sorted   : {string.Join(", ", numbers)}");

Array.Reverse(numbers);
Console.WriteLine($"Reversed : {string.Join(", ", numbers)}");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"  [{i}] = {numbers[i]}");
}
int indexOf19 = Array.IndexOf(numbers, 19);
Console.WriteLine($"IndexOf(19)  = {indexOf19}");

int indexOf100 = Array.IndexOf(numbers, 100);
Console.WriteLine($"IndexOf(100) = {indexOf100}");

// ---- Task 5: DateTime and TimeSpan ----

DateTime birthDate = new DateTime(2004, 3, 15);
DateTime today = DateTime.Now;
TimeSpan ageSpan = today - birthDate;
int years = (int)(ageSpan.TotalDays / 365.25);
Console.WriteLine($"Birth date : {birthDate:yyyy-MM-dd}");
Console.WriteLine($"Today      : {today:yyyy-MM-dd}");
Console.WriteLine($"Age        : {years} years");

DateTime tenDaysLater = birthDate.AddDays(10);
Console.WriteLine($"Birth + 10 days : {tenDaysLater:yyyy-MM-dd}");

// ---- Task 6: List and Dictionary ----

List<string> fruits = new() { "Apple", "Mango", "Banana" };
fruits.Add("Orange");
fruits.Remove("Mango");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Dictionary<int, string> fruitDictionary = new()
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Banana" }
};
        }
    }
}
