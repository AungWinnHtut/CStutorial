#include<stdio.h>
#include<stdlib.h>
int main()
{

	int i = 0;
	do{		
		printf("1-single user\n");
		printf("2-multi user\n");
		printf("3-exit\n");
		scanf_s("%d", &i);
		switch (i)
		{	
		case 1: printf("you choose single user!\n"); break;
		case 2: 
			printf("you choose multiple user!\n"); 
			break;
		case 3: 
			printf("you choose to exit!\n");
			exit(0); 
			break;
		default: printf("you should choose only 1 , 2 and 3!\n"); break;
		}
		
	} while (i!=3);

	return 0;
}