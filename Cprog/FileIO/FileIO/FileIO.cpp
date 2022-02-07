/*
1- read user command 
    1 - storage char[]
    2 - fill with '\0'
    3 - read and put in command array
        1 - read one char from keyboard
        2 - if enter exit, else put it in command array then go to 1


2-enter command in system function

3-if command = exit then exit else go to 1
    1 - test if same strlen 
    2 - compare one element by another
    3 - if found any different then exit and not equal
    4 - else till the end then equal

*/






#include <stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<string.h>
#include <limits.h>

//#include <unistd.h>
#include <direct.h> // _getcwd


#define NEWLINE putchar('\n')
int strlenn(char* strr);
int strcmpp(char* one, char* two);

int main()
{   
    char command[40] = { '\0' };
    int i = 0;
    char ch;  

    do {

        for (int k = 0; k < 40; k++)
        {
            command[k] = '\0';
        }

        i = 0;      

        char cwd[_MAX_PATH];
        if (_getcwd(cwd, sizeof(cwd)) != NULL) {
            printf("%s> ", cwd);
        }
        else {
            perror("getcwd() error");
            return 1;
        }

        while ((ch = _getch()) != char(13)) {
            putchar(ch);
            command[i++] = ch;
        }

        NEWLINE;
       system(command);      
        
    } while (strcmpp(command, (char*) "exit") != 0);

    exit(0);
    return 0;
}

int strcmpp(char* one, char* two)
{
   
    int i = 0;
    int l1 = strlenn(one);
    int l2 = strlenn(two);

    if (l1 > l2)
        return 1; //str1 longer then str2
    else if (l1 < l2)
        return -1; //str1 shorter then str2



    while (one[i]!='\0')
    {
        if (one[i] != two[i])
        {           
            return 2; //same length but different string
        }
        i++;
    }

    return 0; //equal

}

int strlenn(char* strr)
{
    int count = 0;
    while (   strr[count] != '\0'    )
    {
        count++;
    }
    return count;
}


