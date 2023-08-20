var number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Narcissistic(number));

static bool Narcissistic(int value)
{
    double result = 0;
    var tempValue = value;

    for (int i = 0; i < value.ToString().Length; i++)
    {
        result += Math.Pow(tempValue % 10, value.ToString().Length);
        tempValue /= 10;
    }

    if (value == result)
        return true;
    else
        return false;
}
