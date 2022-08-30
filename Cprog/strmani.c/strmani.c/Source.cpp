#include<stdio.h>
#include<string.h>
#pragma warning(disable : 4996)
int strlen2(const char* arr);
int modifyArray(char* arr);
char* strcpy2(char* destination, const char* source);
char* strcat2(char* destination, const char* source);
int main()
{
	char a[15] = { 'a','u','n','g',' '};
	char b[] = { 'v','k','n','t','\0'};
	char c[] = "aung";
	char k[7] ;
	char* array;
	array = strcat2(a, c);
	printf("%s\n", a);
	printf("%s\n", array);
	//printf("strlen2(a)= %d  strlen2(b)= %d", strlen2(a), strlen2(b));
	
}

int strlen2(const char * arr)
{
	int count = 0;
	while (arr[count] != '\0' && arr[count] != -52)
	{
		//printf("arr[%d]=%d=%c\n", count, arr[count], arr[count]);
		count++;
	}
	printf("\n\n\n");
	return count;
}

int modifyArray(char* arr)
{
	arr[0] = 'p';
	arr[1] = 'a';
	arr[2] = 'd';
	return 0;
}

char* strcpy2(char* destination, const char* source)
{
	int count = 0;
	while (source[count] != '\0' && source[count] != -52)
	{
		destination[count] = source[count];
		count++;
	}
	destination[count] = '\0';
	return destination;
}

char* strcat2(char* destination, const char* source)
{
	int len1 = strlen2(source);
	int len2 = strlen2(destination);
	for (int i = 0; i < len1; i++)
	{
		destination[len2 + i] = source[i];
	}
	return destination;
}
