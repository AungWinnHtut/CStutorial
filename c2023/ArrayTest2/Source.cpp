#include<stdio.h>
#include<stdlib.h> //srand() rand()
#include<time.h> //time()

int main()
{
	printf("%d\n", (int)time(NULL));
	int freq[7] = { 0 };
	srand(time(NULL));
	for (int i = 0; i < 10000; i++)
	{
		int dice = rand() % 6 + 1;
		printf("%d ", dice);		
		++freq[dice];
		if ((i+1) % 60 == 0)
		{
			printf("\n");
		}
	}
	printf("\n\nNumber\tFrequency\tBargraph\n");
	for (int k = 1; k <= 6; k++)
	{
		printf("%d\t%d\t", k, freq[k]);
		for (int j = 0; j < (freq[k]/100); j++)
		{
			printf("*");
		}
		printf("\n");
	}
	
	return 0;
}

