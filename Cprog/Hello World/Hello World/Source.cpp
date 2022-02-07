#include<stdio.h> //std - standard io - input output

struct STUDENT {
	char name[40];
	int age;
	int totalMarks;
};


int main()
{
	int i=0;
	char ch;
	FILE* ifp;
	char line[100] = { '\0' };

	fopen_s(&ifp, "D:\\test\\data.txt", "r");
	//fscanf_s(ifp, "%s", line,100);
	while ((ch = fgetc(ifp)) != EOF) {
		i = 0;
		for (int k = 0; k < 100; k++)
			line[k] = '\0';

		while (ch != '\n' && ch != EOF)
		{
			line[i++] = ch;
			ch = fgetc(ifp);
		}
		printf("%s\n", line);
	}
	fclose(ifp);

	
	return 0;
}

