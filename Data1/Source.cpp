#include <stdio.h>

int main()
{
	char ch='a';
	unsigned int i = 2147483648;
	
	int j[6] = { 10,20,30,40,50,-1 };
	int j_count = 5;

	int count = 0;
	

	while (j[count++] != -1)
	{}

	printf("count is %d ", --count);

}
