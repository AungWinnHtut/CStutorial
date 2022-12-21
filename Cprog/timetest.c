#include <stdio.h>
#include <time.h>
int strlen_k(const char *str);

int main()
{
    time_t current_time;
    struct tm *time_info;
    char time_string[100];

    // Get the current time
    time(&current_time);

    // Convert the time to a local time representation
    time_info = localtime(&current_time);

    // Format the time as a string
    strftime(time_string, sizeof(time_string), "%A, %B %d %Y, %I:%M:%S %p", time_info);
    int count = strlen_k(time_string);
    printf("\ncount is %d\n\n", count);

    for (int k = 0; k < count; k++)
    {
        printf("%d %c\n", k, time_string[k]);
    }

    // Print the time string
    printf("The current date and time is: %s\n", time_string);

    return 0;
}

int strlen_k(const char *str)
{
    int count = 0;
    while (str[count] != '\0' && str[count] != -52)
    {
        count++;
    }
    return count;
}
