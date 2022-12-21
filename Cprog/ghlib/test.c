#include <stdio.h>
#include "ghlib.h"
#include "ghlib.c"
int main()
{
    char a[10] = "aung win";
    strcat_k(a, " htut is a teacher");
    puts(a);
    return 0;
}
