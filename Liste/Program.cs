// See https://aka.ms/new-console-template for more information

int[] myNum = {10, 20, 30, 40};
var list = new MyList();
list.AddNumber(1);
list.AddNumber(10);
list.AddNumber(100);
list.PrintNumbers();


var randomList = new MyList();
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    int randomTal = random.Next(1, 100);
    randomList.AddNumber(randomTal);
}
Console.WriteLine("Tilfældige tal:");
randomList.PrintNumbers();

public class MyList
{
    private List<int> numbers = new List<int>();

    public void AddNumber(int number)
    {
        numbers.Add(number);
    }

    public void PrintNumbers()
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


