
void isPalindrom(int number) 
{
   int absNumber = Math.Abs(number);
   string numToString = Convert.ToString(absNumber);

   if ( absNumber > 99999 || absNumber < 10000 )
   {
      Console.WriteLine("Неверная длина числа, требуется пятизначное!");
   }
   else if ( $"{numToString[1]}{numToString[0]}" == $"{numToString[3]}{numToString[4]}" ) 
   {
      Console.WriteLine($"{number} - является палиндромом");
   }
   else {
      Console.WriteLine($"{number} - не является палиндромом");
   }
}

isPalindrom(-23432);
isPalindrom(90981);
isPalindrom(14212);
isPalindrom(3433);
isPalindrom(-1001);