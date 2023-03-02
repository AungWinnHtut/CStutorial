#include<stdio.h>
int main()
{
	int year = 0;
	int month = 0;
	int day = 0;

	int sum = 0;
	int mod = 0;

	printf("Lucky Star\n");
	printf("==========\n");

	for (int i = 0; i < 5; i++) //i++ -> i = i+1;
	{
		printf("Please enter birthday dd-mm-yyyy : ");
		scanf_s("%d-%d-%d", &day, &month, &year);

		sum = year + month + day;
		mod = sum % 3;
		if (mod == 0)
		{
			printf("You are not LUCKY\n");
		}
		if (mod == 1)
		{
			printf("You are NORMAL\n");
		}
		if (mod == 2)
		{
			printf("You are  LUCKY\n");
		}
	}

	
	return 0;
}