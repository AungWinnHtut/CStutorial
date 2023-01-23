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

void left_trim_k(char *t_arr, const char *str, int count)
{
    int i = 0;
    while (str[i] == ' ')
    {
        i++;
    }
    for (int k = 0; k < count - i; k++)
    {
        t_arr[k] = str[k + i];
    }
}

void split_k(char *line, char *command, const char *str, const char ch, int count)
{
    int s_index = 0;
    char buffer[100] = {"\0"};
    while (str[s_index++] != ch)
    {
    }
    for (int k = 0; k < s_index; k++)
    {
        line[k] = str[k];
    }
    for (int k = 0; k < count - s_index; k++)
    {
        buffer[k] = str[k + s_index];
    }
    left_trim_k(command, buffer, strlen_k(buffer));
}

int s2i_k(const char *line, int count)
{
    int result = 0;
    int temp = -1;
    for (int i = 0; i < count - 1; i++)
    {
        // temp = c2i_k(line[count  - i]);
        temp = c2i_k(*(line + count - 2 - i));
        if (temp == -1)
        {
            printf("s2i error! not an integer!\n");
            return -1;
        }
        else
        {
            result += (temp * pow_k(10, i));
        }
    }
    return result;
}

int c2i_k(char c)
{
    if (c >= 48 && c <= 57)
    {
        return (c - 48);
    }
    else
    {
        // printf("c2i error! %c is not an integer!", c);
        return -1;
    }
}

int pow_k(int base, int exp)
{
    int result = base;
    if (exp == 0)
    {
        return 1;
    }
    else if (exp == 1)
    {
        return base;
    }
    else
    {
        for (int i = 1; i < exp; i++)
        {
            result *= base;
        }
    }
    return result;
}

void clear_str_k(char *str, int count)
{
    for (int i = 0; i < count; i++)
    {
        str[i] = '\0';
    }
}