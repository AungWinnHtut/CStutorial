#include<stdio.h>
#include<string.h>



int main()
{
    char ch = '\0';
    char uname[20];
    int i = 0;
    printf("please enter username: ");

    do{
        ch = getc(stdin);
        uname[i++] = ch;
    } while (ch!='\n');
    //uname[i] = '\0';
    //hard coded string , string lateral
    if (strcmp(uname, "aung win htut\n")==0)
    {
        printf("username is correct! \n");
    }
    return 0;
}

