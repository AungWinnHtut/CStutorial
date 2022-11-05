#include<stdio.h>
int main()
{
	
	float kyat = 0.0;
	float pae = 0.0;
	float yway = 0.0;
	float price_per_kyat = 0.0;

	float gold_weight = 0.0;
	float total_gold_price = 0.0;

	printf("pls enter kyat :");
	scanf_s("%f", &kyat);
	printf("pls enter pae :");
	scanf_s("%f", &pae);
	printf("pls enter yway :");
	scanf_s("%f", &yway);
	printf("pls enter  gold price :");
	scanf_s("%f", &price_per_kyat);


	gold_weight = kyat + (pae / 16) + (yway / 128);
	total_gold_price = price_per_kyat * (gold_weight);

	printf("Total Gold Weight is %f \n", gold_weight);
	printf("Total Gold Price is %f \n", total_gold_price);
	return 0;
}