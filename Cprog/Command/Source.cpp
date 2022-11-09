#include<stdio.h>
#include<string.h>
#include<conio.h>

int main()
{
	char uName[20] = { '\0' };
	char passWord[20] = { '\0' };
	printf("please enter your name : ");
	gets_s(uName); //gcc gets() stdio.h
	printf("please enter your password :  ");
	//gets_s(passWord); //gcc gets() stdio.h
	//Enter မခေါက်မချင်း စာလုံးတစ်လုံးချင်းဖတ်ပြီး passWord array ထဲ ထည့်မယ်။
	//အဆုံးမှာ '\0' ထည့်ပေးလိုက်မယ်
	char ch = '\0';
	int i = 0;
	while (   (ch = _getch())   != '\r')
	{
		printf("*");
		passWord[i] = ch;
		i++;
	}
	printf("\n");
	

	
	if (    (strcmp(uName, "aung") == 0 ) && (strcmp(passWord, "1234") == 0)  )
	{
		puts("user name and password are OK!");
	}
	else {
		puts("user name and password are NOT OK!");
	}
	
	return 0;
}