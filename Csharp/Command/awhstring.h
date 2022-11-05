#include <stdio.h>
#include <string.h>
void strcat2(char* str1, const char* str2);


void strcat2(char* str1, const char* str2)
{
	while (*str1 != '\0')
	{
		str1++;
	}
	while (*str2 != '\0')
	{
		*str1 = *str2;
		str1++;
		str2++;
	}
	*str1 = '\0';
}