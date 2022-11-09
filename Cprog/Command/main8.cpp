#include <stdio.h>
#include <string.h>
int strlen2(char* str);
int main8()
{
    char a[20] = "Program";  //string = null terminated string
    char b[20] = { 'P','r','o','g','r','a','m','\0'};

    // using the %zu format specifier to print size_t
    printf("Length of string a = %zu \n", strlen(a));
    printf("Length of string b = %zu \n", strlen(b));

    return 0;
}

int strlen2(char* str)
{
    int count = 0;
    while (*str != '\0')
    {
        str++;
        count++;
    }
    return count;
}