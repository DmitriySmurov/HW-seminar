// задание 4
int a = 22;

int b = 3;

int c = 9;

int max = a;

if (a > b ) max = a;

if (b > a) max = b;

if (c > a) max = c;

if (b > a) max = c;

Console.WriteLine (max);
