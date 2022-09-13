#include<stdio.h>
#include<string.h>
#pragma warning(disable : 4996)
int strlen2(const char* arr);
int modifyArray(char* arr);
char* strcpy2(char* destination, const char* source);
char* strcat2(char* destination, const char* source);
int strcmp2(const char* str1, const char* str2);
void strlwr2(char* str);
void strupr2(char* str);

int main()
{
	char g[] = { 'a','u','n','g' };
	char a[15] = { 'a','u','n','g'};
	char b[] = { 'v','k','n','t','\0'};
	char c[] = "aungc"; //null terminated string
	char d[] = "aunge";
	char j[] = "This is A tesT";
	char k[7] ;
	char* array;
	int result = strcmp2(a, g);
	strupr2(j);
	printf("%s\n", j);
	
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

int strcmp2(const char* str1, const char* str2)
{
	int count = 0;	
	int str1_len = strlen2(str1);
	int str2_len = strlen2(str2);
	if (str1_len > str2_len)
	{
		return 1;
	}
	if (str1_len < str2_len)
	{
		return -1;
	}
	if (str1_len == str2_len)
	{
		while (str2[count] != '\0' && str2[count] != -52)
		{
			if (str1[count] == str2[count])
			{
				count++;
			}
			else
			{
				return str1[count] - str2[count];
			}
		}
	}	
	return str1[count] - str2[count];
}

void strlwr2(char* str)
{
	int count = 0;
	while (str[count] != '\0' && str[count] != -52)
	{
		if (str[count] >= 65 && str[count] <= 90)
		{
			str[count] += 32;
		}
		count++;
	}
}

void strupr2(char* str)
{
	int count = 0;
	while (str[count] != '\0' && str[count] != -52)
	{
		if (str[count] >= 97 && str[count] <= 122)
		{
			str[count] -= 32;
		}
		count++;
	}
}

