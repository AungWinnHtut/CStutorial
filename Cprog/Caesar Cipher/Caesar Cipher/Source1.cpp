#include <stdio.h>
#include <stdlib.h>
#include<string.h>
int strlen2(const char* s);
int main()
{
    char sr[] = { 'a','b','a','a','c','a','b','b','a','g','a','c','a','o'};
    char sr1[] = { 'a','b','a','a','c','a','b','b','a','g','a','c','a','o' ,'\0'};
    char ar[] = { 'a','b','c','d' };
    char br[] = { 'e','f','g' };
    char cr[] = { '\0' };
    int i = 0;
   
    printf("my fun %d\n", strlen2(sr));
    printf("lib fun %d\n", strlen(sr));

    printf("my fun %d\n", strlen2(sr1));
    printf("lib fun %d\n", strlen(sr1));
    return 0;
}

int strlen2(const char* s)
{
    int i = 0;
    while ( (s[i] != -52) && (s[i] != '\0')) //end is char(-52)
    {
        i++;
    }
    return i;
}