#include <stdio.h>
void funArea(void);
int main7()
{
    char ca[5] = { 'h','e','l','l','o' };
    char ca_upper[5] = { '\0' };
    char az[27] = { '\0' };

    for (int a =0 ; a <26; a++)
    {
        az[a] = a + 97;
    }
    for (int a = 0; a < 26; a++)
    {
        printf("%c\n", az[a]);
    }

    for (int i = 0; i < 5; i++)
    {
        ca_upper[i] = ca[i] - 32 + 3;
    }

    for (int i = 0; i < 5; i++)
    {
        printf("%c\n", ca_upper[i]);
    }
    funArea();

    return 0;
}


void funArea(void)
{
    int L[4] = { 2,5,7,8 };
    int W[4] = { 6,2,1,4 };
    int A[4] = { 0 };
    for (int i = 0; i < 4; i++)
    {
        A[i] = L[i] * W[i];
    }
   
    for (int i = 0; i < 4; i++)
    {
        printf("Area is %d\n", A[i]);
    }

 
}
