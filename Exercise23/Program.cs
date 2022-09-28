
void thirdDegree(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} в кубе = {Math.Pow(i, 3)}");
    }
}

thirdDegree(5);