#include <stdio.h>
#include <stdlib.h>

int main()
{
    char input[100];
	scanf("%8[^aeiou]", input);
	printf("input string is %s \n", input);

	return 0;
}
