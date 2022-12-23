#include <stdio.h>
#include <conio.h>

int strlen_k(const char *str)
{
    int count = 0;
    while (str[count] != '\0' && str[count] != -52)
    {
        count++;
    }
    return count;
}

void strcpy_k(char *destination, const char *source)
{
    int count = 0;
    while (source[count] != '\0' && source[count] != -52)
    {
        destination[count] = source[count];
        count++;
    }
}

int strcmp_k(const char *str1, const char *str2)
{

    int index = 0;
    int max = 0;
    if (strlen_k(str1) > strlen_k(str2))
    {
        return 1;
    }
    else if (strlen_k(str1) < strlen_k(str2))
    {
        return -1;
    }
    while (str1[index] != '\0' && str1[index] != -52)
    {
        if (str1[index] > str2[index])
        {
            return 1; // str1 > str2
        }
        else if (str1[index] < str2[index])
        {
            return -1; // str1 < str2
        }
        index++;
    }
    return 0; // equal
}

// homework
// 1 - strncpy
// 2 - strncmp

void strcat_k(char *destination, const char *source)
{
    int dl = strlen_k(destination);
    int sl = strlen_k(source);
    for (int i = 0; i < sl; i++)
    {
        destination[dl + i] = source[i];
    }
}

char *gets_k(char *str, int buffer_size)
{
    char ch = '\0';
    int i = 0;
    do
    {
        ch = _getch();
        putchar(ch);
        if (ch != '\n' && ch != '\r')
        {
            str[i++] = ch; // str[0]=ch; i++;
        }

    } while (ch != '\r' && i < buffer_size); // off by one error => 0 to buffer_size - 1
    str[i] = '\0';
    printf("\n"); // need to enter new line
    return str;
}