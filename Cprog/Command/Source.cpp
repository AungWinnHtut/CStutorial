#include<stdio.h>//printf puts
#include<string.h>//strcmp()
#include<conio.h>//_getch()
#include<stdlib.h> //system()
int funMENU();
int main()
{
	char uName[20] = { '\0' };
	char passWord[20] = { '\0' };
	int status = 0; // 0 - incorrect u p  1 - correct
	int error_count = 0;

	do {
		system("cls");
		//ask and read uname and password
		printf("please enter your name : ");
		gets_s(uName); //gcc gets() stdio.h
		printf("please enter your password :  ");
		//gets_s(passWord); //gcc gets() stdio.h
		//Enter မခေါက်မချင်း စာလုံးတစ်လုံးချင်းဖတ်ပြီး passWord array ထဲ ထည့်မယ်။
		//အဆုံးမှာ '\0' ထည့်ပေးလိုက်မယ်
		char ch = '\0';
		int i = 0;
		while ((ch = _getch()) != '\r')
		{
			printf("*");
			passWord[i] = ch;
			i++;
		}
		printf("\n");

		//if correct go to fun and exit
		if ((strcmp(uName, "aung") == 0) && (strcmp(passWord, "1234") == 0))
		{
			puts("user name and password are OK!");
			funMENU();
			status = 1;

		}
		else {
			puts("user name and password are NOT OK!");
			status = 0;
			error_count++;
		}
		//else go to do while top

	} while ( ( status==0) && (error_count <3) ); 



	//_getch();
	return 0;
}

int funMENU()
{
	int ans = 0;
	do {
		printf("1 - Area Calculation\n");
		printf("2 - Gold Price\n");
		printf("3 - Exit\n");
		printf("Please choose (1,2,3) : ");
		scanf_s("%d", &ans);

		if (ans == 1)
		{
			//area
			printf("area function\n");
		}
		else if (ans == 2)
		{
			//gold price
			printf("gold price function\n");
		}
		else if (ans == 3)
		{
			//exiting
			return 0;
		}
		else
		{
			printf("wrong answer, pls try again!");
		}
	} while (ans!=3);
	
	
}