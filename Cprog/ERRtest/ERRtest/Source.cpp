#include<stdio.h>//
#include<conio.h>//
#define Age 10
float average(float arr[]);


void main()
{
    float ppl[Age] = { 0.0 };
    int i;
    for (i = 0; i < Age; i++)
    {
        printf("Please enter the age of %d person :  ", i);
        scanf_s("%f", &ppl[i]);
    }
    float avr_age = average(ppl);
    printf("The average age of all people is %f", avr_age);
    _getch();
}

float average(float arr[])
{
    float sum=0;
    for (int i = 0; i < Age; i++)
    {
        sum = sum + arr[i];
    }
    float total = (sum / Age);
    return total;
}