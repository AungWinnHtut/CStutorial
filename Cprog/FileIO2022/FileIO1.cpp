#include<stdio.h>
#include<stdlib.h> //exit()

int fileio1()
{
	FILE* fo;
	FILE* fi;
	FILE* fo2;

	float A[10];
	float L[10] = { 1.7,2.3,4.6,7.8,1,2,3,4,5,6};
	float W[10] = { 5.2,4.1,1.6,6.8,7,8,9,0,9,8 };

	fopen_s(&fo, "I:\\test\\area.dat", "w"); //a - append

	if (fo == NULL)
	{
		printf("!Error, cannot open file!");
		exit(1);
	}

	for (int i = 0; i < 10; i++)
	{
		A[i] = L[i] * W[i];
		printf("%d L=%0.2f W=%0.2f A=%0.2f\n",i+1, L[i], W[i], A[i]);
		fprintf_s(fo, "%0.2f\n",A[i]);
	}	
	
	fclose(fo);

	fopen_s(&fi, "I:\\test\\area.dat", "r"); //r - read

	if (fi == NULL)
	{
		printf("!Error, cannot open file!");
		exit(1);
	}

	float A2[20] = {};
	for (int u = 0; u < 20; u++)
	{
		A2[u] = -1;
	}


	float data = 0.0;
	int fstatus = 0;
	int index = 0;

	do {
		fstatus = fscanf_s(fi, "%f", &data); //success = 1 , fail = -1
		if (fstatus == 1)//OK
		{
			A2[index] = data;
			index++;
		}
		
	} while (fstatus != -1);
	fclose(fi);

	int h = 0;

	while(A2[h]!=-1)
	{
		printf("Read data from file is %f\n", A2[h]);
		h++;
	}
	


	
	return 0;
}