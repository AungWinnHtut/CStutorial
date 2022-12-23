#include <stdio.h>
#include <stdlib.h>
#include "ghlib.c" //.hpp
#include "ghlib.h"
int main()
{
    FILE *buffer;
    fopen_s(&buffer, "d:\\buffer.sml", "w"); // sml - simpletron machine language file
    if (buffer == NULL)
    {
        printf("cannot open buffer file!");
        return 1;
    }
    char command[100] = {"\0"};
    char page[1000][100];
    system("cls");
    system("color 0A");
    printf("\t\t\tGreen Hackers ][\n");
    while (strcmp_k(command, "exit"))
    {
        printf("] ");
        gets_k(command, 100);
        // fprintf_s(fp, "%d\n", 1050);
    }
    printf("\n\n\n\n\n\n");
    fclose(buffer);
    return 0;
}