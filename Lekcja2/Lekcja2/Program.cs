// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Kajetan and Lukasz");
int number = 1211190;
int[] ile = new int[10];

string numberInString = number.ToString();
for (int i = 0; i < numberInString.Length; i++)
{
    if (numberInString[i] == '0')
    {
        ile[0]++;
    }
    else if (numberInString[i] == '1')
    {
        ile[1]++;
    }
    else if (numberInString[i] == '2')
    {
        ile[2]++;
    }
    else if (numberInString[i] == '3')
    {
        ile[3]++;
    }
    else if (numberInString[i] == '4')
    {
        ile[4]++;
    }
    else if (numberInString[i] == '5')
    {
        ile[5]++;
    }
    else if (numberInString[i] == '6')
    {
        ile[6]++;
    }
    else if (numberInString[i] == '7')
    {
        ile[7]++;
    }
    else if (numberInString[i] == '8')
    {
        ile[8]++;
    }
    else
    {
        ile[9]++;
    }

}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("ilość " + i + ": " + ile[i]);
}