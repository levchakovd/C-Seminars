string f(int n)
{
    if (n == 0)
        return "";
    string? k = Console.ReadLine();
    return f(n - 1) + " " + k;
}


int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));