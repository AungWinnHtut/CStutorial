#include<stdio.h>
#include<ctype.h>
#include<stdlib.h>
int funtest(const char* s1, const char* const s2, char* s3, char* const s4);
void funargtest(int);
int isdigit_k(int ch);

int main()
{
	FILE* fi=NULL;
	char arr[100][100];
	int row = 0;
	fopen_s(&fi, "d:\\temp.txt", "r");
	if (fi != NULL)
	{
		while (fgets(arr[row], 100, fi) != NULL)
		{
			row++;
		}
		
		*fi;
		fclose(fi);
	}

	
	return 0;
}

int isdigit_k(int ch)
{
	if (ch < 48 || ch>57)
	{
		return -1;
	}
	else
	{
		return ch - 48;
	}
}

int funtest( char* const s1, const char* const s2, char* s3,const char*  s4)
{
	//s1 = "test";
	s1[0] = s2[0];
	s3[0] = 'a';
	s4 = "test";
	return 0;
}
void copy2(char* s1, const char* s2) {

	// loop through strings

	for (; (*s1 = *s2) !=NULL ; ++s1, ++s2) {

		; // do nothing in body

	}
}

void funargtest(int k)
{
	printf("%d\n", k);
}

void funpointer(int funid)
{
	switch (funid) {
	case 0: funargtest(1);  break;
	case 1: funargtest(1);  break;
	case 2: funargtest(1);  break;
	case 3: funargtest(1);  break;
	}
}

void funpointerreal(int (funchoice)(int a))
{

}