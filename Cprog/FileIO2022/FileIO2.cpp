#include<stdio.h>
#include<stdlib.h> //exit()

int FileIO2()
{
	FILE* fpl;
	FILE* fpw;
	FILE* fpa;

	float l[20] ;
	float w[20];
	float a[20];

	int fstatus = 0; // 0 - neutral
	float data = 0.0;
	int index = 0;
	int lcount = 0;
	int wcount = 0;

	for (int k = 0; k < 20; k++)
	{
		l[k] = -1;
		w[k] = -1;
		a[k] = -1;
	}


	//1-read l values and store in l array
	fopen_s(&fpl, "I:\\test\\l.txt", "r");
	if (fpl == NULL)
	{
		printf("!Error, cannot open file!");
		exit(1);
	}
	do {
		fstatus = fscanf_s(fpl, "%f", &data); //success = 1 , fail = -1
		if (fstatus == 1)//1 - OK | -1 Not OK
		{
			l[index] = data;
			index++;
		}
	} while (fstatus != -1);
	lcount = index;
	fclose(fpl);

	//2-read w values and store in w array
	index = 0;
	fopen_s(&fpw, "I:\\test\\w.txt", "r");
	if (fpw == NULL)
	{
		printf("!Error, cannot open file!");
		exit(1);
	}
	do {
		fstatus = fscanf_s(fpw, "%f", &data); //success = 1 , fail = -1
		if (fstatus == 1)//1 - OK | -1 Not OK
		{
			w[index] = data;
			index++;
		}
	} while (fstatus != -1);
	wcount = index;
	fclose(fpw);

	//3-calculate area and store in a.txt file
	if (lcount == wcount)
	{
		for (int j = 0; j < lcount; j++)
		{
			a[j] = l[j] * w[j];
		}
	}
	fopen_s(&fpa, "I:\\test\\a.txt", "w");
	if (fpa == NULL)
	{
		printf("!Error, cannot open file!");
		exit(1);
	}
	for (int z = 0; z < lcount; z++)
	{
		fprintf_s(fpa, "%0.2f\n", a[z]);
	}
	fclose(fpa); //really save to file in harddisk
	return 0;
}