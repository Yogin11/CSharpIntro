int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}    

int a1 = 34;
int a2 = 45;
int a3 = 70;
int b1 = 32;
int b2 = 105;
int b3 = 71;
int c1 = 33;
int c2 = 21;
int c3 = 15;


int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a2, b2, c2)
    );

Console.WriteLine(max);

