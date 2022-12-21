#include <stdio.h>
#include <time.h>

int maintt()
{
    time_t current_time=NULL;  
    struct tm time_info;
    char time_string[100];

    // Get the current time
    time(&current_time);

    // Convert the time to a local time representation
     localtime_s(&time_info ,&current_time);

    // Format the time as a string
    strftime(time_string, sizeof(time_string), "%c", &time_info);
    //yyyymmddhhmmss.dmp
    // Print the time string
    printf("The current date and time is: %s\n", time_string);

    return 0;
}