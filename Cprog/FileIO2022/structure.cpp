#include<stdio.h>
#include<string.h>
typedef int INTEGER;

typedef struct PROFILE{
	char name[20] ;
	INTEGER age ;
	float height ;
}PROFILE;  //global variable

PROFILE student1, student2;
int main()
{
	//student1 = { "aungaung",22,5.6 };
	strcpy_s(student1.name , "aung asdkjfla;skjdf;ladjfl;aksdjflaskdjflkasdjflasdjfaung");
	student1.age = 22;
	student1.height = 5.6;
	
	printf("%c", student1.name[0]);


	return 0;
}

void secret_stuff()
{
	PROFILE head_master;

}