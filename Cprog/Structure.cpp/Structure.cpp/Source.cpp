#include<stdio.h>
#include<stdlib.h>
#include<string.h>


struct NEWDATA {
	STUDENT KOKO;
	DIMENSION CYL;
	int k;
};


struct STUDENT {
	char cName[40];
	int age;
};

struct DIMENSION {
	float A;
	float V;
};

DIMENSION  funAreaVolume(float r);

int main()
{	
	DIMENSION result;
	int i[10];
	DIMENSION kunits[10];
	result = funAreaVolume(3.45);
	return 0;
}

DIMENSION  funAreaVolume(float r)
{
	DIMENSION cy;	
	cy.A = 3.14 * r * r;
	cy.V = cy.A * 22;
	return cy;
}