int n = 8;
int i;
int count=0;

for (i=1; i<=n; i++)
{
    if (n % i==0)
    {
        count++;
    }
}
if (count == 2)
    Console.WriteLine("n is prime");
else
    Console.WriteLine("n is not prime");