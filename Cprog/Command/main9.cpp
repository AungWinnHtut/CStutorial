#include <stdio.h>
#include <string.h>
void strcpy2(char* str2, const char* str1);
int main9() {
	char str1[20] = "C programming";
	char str2[20];
	
	// copying str1 to str2
	strcpy2(str2, str1);
	puts(str2); // C programming

	return 0;
}

void strcpy2(char* str2, const char* str1)
{
	while (*str1 != '\0')
	{
		*str2 = *str1;
		str1++; str2++;
	}
	*str2 = '\0';
}