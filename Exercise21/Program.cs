
void Distance(int[] firstDot, int[] secondDot) 
{
    double summ = 0;
    for(int i = 0; i < 3; i++)
    {
        summ = summ + Math.Pow((secondDot[i] - firstDot[i]), 2);
    }
    double result = Math.Sqrt(summ);
    Console.WriteLine(result);
}

int[] first = {7, -5, 0};
int[] second = {1, -1, 9};
Distance(first, second);