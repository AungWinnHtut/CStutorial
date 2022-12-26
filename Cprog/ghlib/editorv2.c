#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "ghlib.c" //.hpp
#include "ghlib.h"
void split_command(char *line, char *cmd, const char *command, int command_length);
#define COL_MAX 100
#define ROW_MAX 1000
int main()
{
    FILE *buffer;
    fopen_s(&buffer, "d:\\buffer.sml", "w"); // sml - simpletron machine language file
    if (buffer == NULL)
    {
        printf("cannot open buffer file!");
        return 1;
    }
    char command[COL_MAX] = {"\0"};
    char page[ROW_MAX][COL_MAX];
    char line[3] = {""};
    char cmd[COL_MAX] = {""};
    system("cls");
    system("color 0A");
    printf("\t\t\tGreen Hackers ][\n");
    do
    {
        printf("] ");
        gets_k(command, COL_MAX);
        split_command(line, cmd, command, COL_MAX);
        puts(line);
        puts(cmd);

        // fprintf_s(fp, "%d\n", 1050);
    } while (strcmp_k(command, "exit"));
    printf("\n\n\n\n\n\n");
    fclose(buffer);
    return 0;
}

void split_command(char *line, char *cmd, const char *command, int command_length)
{
    int i = 0;
    int space_index = -1;
    int cmd_index = -1;
    while (cmd_index != -1)
    {
        if (command[i] == ' ' && space_index == -1)
        {
            space_index = i;
        }
        if (space_index > 0 && command[i] != ' ')
        {
            cmd_index = i;
        }
        i++;
    }
    for (int i = 0; i < space_index; i++)
    {
        line[i] = command[i];
    }
    for (int i = 0; i <= command_length - cmd_index; i++)
        cmd[i] = command[i + cmd_index];
}
