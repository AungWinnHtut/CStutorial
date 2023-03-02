#include<stdio.h>
int gold()
{
	float kyat = 0.0;
	float pae = 0.0;
	float yway = 0.0;
	float kyats = 0.0;
	float price_per_kyat = 0.0;
	float total_gold_price = 0.0;

	printf("Please enter price_per_kyat value : ");
	scanf_s("%f", &price_per_kyat);

	printf("Please enter gold weight (kyat pae yway) : ");
	scanf_s("%f %f %f", &kyat,&pae,&yway);

	 kyats = kyat + pae/16 + yway /128;
	total_gold_price = price_per_kyat * kyats;

	printf("Total gold weights is %f kyats and Total price is %f kyats \n\n", kyats, total_gold_price);

	return 0;
}