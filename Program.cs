// Project Euler

//Problem 1
/* int sum = 0;
for (int i = 0; i < 1000; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);*/


// Problem 2
/*int first = 1;
int second = 2;
int sum = 0;
while (second < 4000000)
{
    int temp = second;
    second = first + second;
    first = temp;
    if (first % 2 == 0)
    {
        sum += first;
    }
}
Console.WriteLine(sum);*/

// Problem 3
Int64 number = 600851475143;
Int64 largest = 1;
bool checkPrime(Int64 num)
{
    bool isPrime = true;
    for (int i = 2; i < Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
        }
    }
    return isPrime;
}
for (int i = 2; i < Math.Sqrt(number); i++)
{
    if (number % i == 0 && checkPrime(i))
    {
        largest = i;
    }
}
Console.WriteLine(largest);
