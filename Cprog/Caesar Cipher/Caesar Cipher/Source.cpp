#include<stdio.h>
int main2()
{
	int index = -1;
	char plain[26] = { 'a','b','c','d','e','f' ,'g','h','i' ,'j','k','l' ,'m','n','o','p' ,'q','r','s' ,'t','u','v' ,'w','x','y' ,'z' };
	char sub[26] =   { 'z','w','k','u','g','i' ,'e','o','f' ,'m','c','4' ,'j','0','h','@' ,'1','s','r' ,'7','d','x' ,'b','v','3' ,'a' };
	char ch = '\0'; //null
	char cipher = '\0';
	char decipher = '\0';
	printf("Please Enter a char to encrypt :  ");
	scanf_s("%c", &ch);

	for (int i = 0; i < 26; i++)
	{
		if (ch == plain[i])
		{
			index = i;
			break;
		}
	}
	cipher = sub[index];
	printf("The cipher char is : %c \n\n", cipher);


	for (int i = 0; i < 26; i++)
	{
		if (cipher == sub[i])
		{
			index = i;
			break;
		}
	}
	decipher = plain[index];
	printf("The original char is : %c \n\n", decipher);


	return 0;
}