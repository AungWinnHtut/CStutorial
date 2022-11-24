#include <stdio.h>

int main()
{
    FILE *fp;

    fp = fopen("I:\\test\\hello.txt", "w");

    fprintf(fp, "I am Dr. Aung Win Htut");

    fclose(fp);

    return 0;
}