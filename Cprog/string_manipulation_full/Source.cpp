//array
//pointer, global variable
//switch
//if else
//fun

#include<stdio.h> //gets
#include<string.h> //strcmp
#include<conio.h> //_getch()
#include <inttypes.h>

#define SIZE 20
int strlen_ghs(const char* str);

char* gets_ghs(char* str, int buffer_size);

int main()
{
	char name[SIZE] = "aung win htut";
	char input1[SIZE] = "a1ung win";
	char input2[SIZE] = "aung win htut";
	char* input3;
	char input4[SIZE]= { '\0' };
	char input5[4];
	int i1 = strlen_ghs(input5);

	printf("line 1\n");
	printf("line 2\n");
	printf("line 3\n");
	printf("line 4\n");
	printf("%" PRId64 "bits \n", sizeof(size_t)*8);
	printf("please enter your name: ");

	gets_ghs(input4, SIZE);
	int i2 = strlen_ghs(input4);
	if (strcmp(input4, name) == 0)
	{
		printf("name correct\n\n");
	}
	else{
		printf("name incorrect\n\n");
	}


	return 0;
}

char* gets_ghs(char* str,int buffer_size)
{
	char ch = '\0'; 
	int i = 0;
	do {
		ch = _getch();
		putchar(ch);
		if (ch != '\n' && ch != '\r')
		{
			str[i++] = ch; //str[0]=ch; i++;
		}
		
	} while (ch!='\r'&&i<buffer_size); //off by one error => 0 to buffer_size - 1
	str[i] = '\0';
	printf("\n"); //need to enter new line
	return str;
}

int strlen_ghs(const char* str)
{
	int i = 0;
	while (str[i] != '\0' && str[i]!=-52)
	{
		i++;
	}
	return i;
}



