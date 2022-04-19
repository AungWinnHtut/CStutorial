#include <stdio.h>
#include <stdlib.h>

int main()
{

    long num;
    long count = 0;
    printf("Enter a number : ");
    scanf_s("%ld", &num);
    while (num != 0) {
        num = num / 10;
        count++;
    }
    printf("There are %d digits", count);
    return 0;
}