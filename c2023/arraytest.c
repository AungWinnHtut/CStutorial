#include <stdio.h>
#include <stdlib.h>
int main()
{
    int age[5] = {0};
    for (int i = 0; i < 6; i++)
    {
        age[i] = 100;
    }
    printf("%d\n", age[0]);
    printf("%d\n", age[1]);
    printf("%d\n", age[2]);
    printf("%d\n", age[3]);
    printf("%d\n", age[4]);

    return 0;
}