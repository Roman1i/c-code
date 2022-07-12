int a, b;



a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
bool what;

if (b * b == a || a * a == b)
{
    what = true;
}
else
{
    what = false;
}

Console.WriteLine(what);