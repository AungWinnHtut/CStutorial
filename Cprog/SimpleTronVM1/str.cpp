#include <stdio.h>
#include<string.h>
int sizeof_k(const char* a);
int main()
{
    char a[100] = "aung win";
    strcat_s(a, " htut is a teacher");
    puts(a);
    printf("%d", sizeof_k(a));
    return 0;
}

int sizeof_k(const char* a)
{
    return strlen(a);
    return sizeof(a);
}