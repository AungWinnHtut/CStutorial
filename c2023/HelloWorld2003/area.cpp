#include<stdio.h>
#include<stdlib.h>

//fun declaration
void area();
void BMI();
void  lucky();
void  gold();
int max(int i1, int i2);
int main()
{
	int ans = 0;
	do {
		printf("menu\n");
		printf("-------\n");
		printf("1-area calculation\n");
		printf("2-gold calculation\n");
		printf("3-bmi calculation\n");
		printf("4-lucky baydin\n");
		printf("5-maximum number test\n");
		printf("0-exit\n");
		printf("Choose one please (0,1,2,3,4,5): ");
		scanf_s("%d", &ans);
		printf("\n\n");
		switch (ans) {
		case 0: exit(0); break;
		case 1: area(); break;
		case 2: gold();  break;
		case 3: BMI(); break;
		case 4: lucky(); break;
		case 5:  int a = 0; int b = 0;
			int c = 0;
			printf("Please Enter First Integer: ");
			scanf_s("%d", &a);
			printf("Please Enter Second Integer: ");
			scanf_s("%d", &b);
			c = max(a, b);
			printf("max number is %d\n", c);
			break;

		}
		printf("\n\n");
	} while (ans != 0); //until user choice to exit
	
	
	return 0;
}

void area() //fun definition 
{
	//Input storatge
	float L = 0.0;
	float W = 0.0;
	//Output storage
	float A = 0.0;

	printf("Please enter L: ");
	scanf_s("%f", &L);

	printf("Please enter W: ");
	scanf_s("%f", &W);

	A = L * W;

	printf("Area = %0.2f\n\n", A);
	
}

void BMI()
{
	float weight = 0.0;
	float height = 0.0;
	float BMI = 0.0;
	float feet = 0.0;
	float inches = 0.0;
	int i = 0;

	printf("enter your weight in kg: ");
	scanf_s("%f", &weight);

	weight = weight * 2.2;
	printf("your weight is %f pounds\n", weight);

	printf("enter your height  (feet:) ");
	scanf_s("%f", &feet);
	printf("enter your height  (inches:) ");
	scanf_s("%f", &inches);

	height = (feet * 12) + inches;
	printf("your height in  (inches:) is %f inches\n", height);

	BMI = (weight / (height * height)) * 703; //w=lb, h=inches

	printf("Your BMI is %f \n", BMI);

	if (BMI < 18.5)
	{
		printf("you are underweight\n");
	}
	else if ((BMI >= 18.5) && (BMI < 24.9))
	{
		printf("you are normal\n");
	}
	else if ((BMI >= 24.9) && (BMI < 29.9))
	{
		printf("you are overweight\n");
	}
	else
	{
		printf("you are Obese\n");
	}
	printf("\n\n");

	
}

void  gold()
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
	scanf_s("%f %f %f", &kyat, &pae, &yway);

	kyats = kyat + pae / 16 + yway / 128;
	total_gold_price = price_per_kyat * kyats;

	printf("Total gold weights is %f kyats and Total price is %f kyats \n\n", kyats, total_gold_price);


}

void  lucky()
{
	int year = 0;
	int month = 0;
	int day = 0;

	int sum = 0;
	int mod = 0;

	printf("Lucky Star\n");
	printf("==========\n");

	for (int i = 0; i < 1; i++) //i++ -> i = i+1;
	{
		printf("Please enter birthday dd-mm-yyyy : ");
		scanf_s("%d-%d-%d", &day, &month, &year);

		sum = year + month + day;
		mod = sum % 3;
		if (mod == 0)
		{
			printf("You are not LUCKY\n");
		}
		else if (mod == 1)
		{
			printf("You are NORMAL\n");
		}
		else if (mod == 2)
		{
			printf("You are  LUCKY\n");
		}
		else {
			printf("Invalid data\n");
		}
	}


}

int max(int i1, int i2)
{
	int bigger = 0;
	if (i1 > i2)
	{
		bigger = i1;
	}
	else {
		bigger = i2;
	}
	return bigger;
}