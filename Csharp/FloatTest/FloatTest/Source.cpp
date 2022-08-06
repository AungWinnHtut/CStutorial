#include<stdio.h>
void setup();
void loop();
int main()
{
	setup();
	
		loop();
	
}

float width = 1000;
float length = 120;
float area = 0.0;
float price = 0.0;

void setup()
{

}

void loop()
{


	area = width * length;
	price = area * 100000;

	printf("%f\n", area);
	printf("%f\n", price);
	
}