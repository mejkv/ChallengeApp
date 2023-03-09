var number = 166354780;
var NumberToString = number.ToString();
char[] numbers = NumberToString.ToArray();
int[] numbercount = new int[10];
foreach (char digit in numbers)
{
    int digits = int.Parse(digit.ToString());
    numbercount[digits]++;
}
Console.WriteLine("W liczbie  {0}", number);
for (int i = 0; i < numbercount.Length; i++)
    Console.WriteLine("Cyfra {0} występuje {1} razy", i, numbercount[i]);
