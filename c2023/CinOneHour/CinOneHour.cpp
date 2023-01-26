#include<stdio.h>
void int2bin(int n, int* bin, int* bin_size, const int  bits);

int main()
{
	char ch;
	ch = 'A';
	int binary[32];
	int binary_size = 0;
	//1- Input scanf_s()
	
	//2- Output printf()
	int2bin('A', binary, &binary_size, 8);
	for (int i = 0; i < 8; i++)
	{
		printf("%d  ", binary[i]);
	}
	//3- Storage variables  = value;
	//4- Processing + - * / %  > < == != && || !
	return 0;
}

void int2bin(int n, int* bin,int *bin_size,const int  bits)
{
	int i = 0;
	int temp[64];
	for (int j = 0; j < 64; j++)
	{
		temp[j] = 0;
	}
	for (int l = 0; l < bits; l++)
	{
		bin[l] = 0;
	}

	while (n > 0)
	{
		temp[i] = n % 2;
		n = n / 2;
		i++;
	}
	*bin_size = i;

	//reverse modulus values
	for (int k = 0; k < *bin_size; k++)
	{
		bin[bits-*bin_size+k] = temp[*bin_size - 1 - k];
	}
}