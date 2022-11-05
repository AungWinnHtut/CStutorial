#include <stdio.h>
int size_of_array(char *arr);

int main()
{
    char name[20] = {'\0'};
    char test[] = {"aung win htut is a teacher"};
    char ch;
    int i = 0;
    while ((name[i++] = fgetc(stdin)) != '\n' && (i < 20))
    {
    }

    for (int j = 0; j < i; j++)
    {
        printf("%c", name[j]);
    }

    int count = size_of_array(name);
    printf("%d\n", count);
    for (int k = 0; k < count; k++)
    {
        printf("%c - %d ", name[k], name[k]);
    }
    // 123456en\0
    return 0;
}

int size_of_array(char *arr)
{
    int i = 0;
    while (1)
    {
        if (arr[i] != '\0')
        {
            if (arr[i] != 10)
            {
                i++;
            }
        }
    }
    return i;
}