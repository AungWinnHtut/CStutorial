#include<stdio.h>


struct BOX {
	MEASUREMENT length;
	MEASUREMENT width;
	MEASUREMENT height;
};

struct MEASUREMENT {
	float feet;
	float inches;
};

int main()
{
	BOX lunchbox[100];

	lunchbox[0].height.feet = 0.1;


	return 0;
}