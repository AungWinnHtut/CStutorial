#include<stdio.h>
int funIsbnCheckDigit(int count, int* book1);
int isIsbnCorrect(int count, int* book1);
int main(int argc, char *argv[])
{
	int book1[13] = { 9,7,8,1,3,9,8,3,1,8,2,8,0 };
	int book2[13] = { 9,7,8,1,3,9,8,3,1,8,2,8,0 };
	int cd = funIsbnCheckDigit(13, book1);
	book1[12] = cd;

	printf("0x %x\n", &book1[0]);
	printf("0x %x\n", &book1[1]);
	printf("0x %x\n", &book1[2]);
	printf("0x %x\n", &book1[3]);

	printf("ISBN 13 : ");
	for (int j = 0; j < 13; j++)
	{
		printf("%d ", book1[j]);
	}
	if (isIsbnCorrect(13, book2))
	{
		printf("ISBN number is correct!");
	}
	else
	{
		printf("ISBN number is not correct!");
	}
}

int funIsbnCheckDigit(int count, int* book1)
{
	int oddsum = 0;
	int evensum = 0;
	int reminder = 0;
	int check_digit = 0;	
	for (int i = 0; i < 12; i = i + 2)
	{
		oddsum += book1[i];
	}
	for (int i = 1; i < 12; i = i + 2)
	{
		evensum += book1[i];
	}
	evensum *= 3;
	reminder = (oddsum + evensum) % 10;
	check_digit = 10 - reminder;
	return check_digit;
		
}
int isIsbnCorrect(int count, int* book1)
{
	int oddsum = 0;
	int evensum = 0;
	int reminder = 0;
	int check_digit = 0;
	for (int i = 0; i < 12; i = i + 2)
	{
		oddsum += book1[i];
	}
	for (int i = 1; i < 12; i = i + 2)
	{
		evensum += book1[i];
	}
	evensum *= 3;
	reminder = (oddsum + evensum) % 10;
	check_digit = 10 - reminder;
	if (check_digit == book1[12])
	{
		return 1;
	}
	else
	{
		return 0;
	}
}
