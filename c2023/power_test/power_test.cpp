#include<stdio.h>
#include<stdlib.h>
#include "ghlib.h"
#include "ghlib.c"
int loop();
int setup();
int check_status();
int startwith(const char* source,const char* phrase, int start_index, int count);


int main()
{
	setup();
	while (1)
	{
		loop();
	}
	return 0;
}


int setup()
{

	return 1;
}

int loop()
{
	system("netsh wlan show networks mode=bssid > temp.txt");
	check_status();
	return 1;
}

int check_status()
{
	int status = 0;
	FILE *fi;
	// open temp file
	fopen_s(&fi, "temp.txt", "rt");
	if (fi == 0) {
		printf("Error! Cannot open temp.txt file\n");
		exit(1);
	}
	char c;
	const int line_max = 100;
	const int col_max = 100;
	int line = 0;
	int col = 0;
	char filedata[line_max][col_max] = { '\0' };

	while ((c = getc(fi)) != EOF)
	{
		if (c != '\n')
		{
			filedata[line][col++] = c;
		}
		else {
			filedata[line][col] = '\0';
			line++;
			col = 0;
		}
	}
	char demmy[100] = "";
	char temp[100] = "";
	char ssid[100]="";
		// read line by line
	for (int i = 0; i < line; i++)
	{
		if (startwith(filedata[i], "SSID", 0, 4))
		{
			puts(filedata[i]);
			int count = strlen_k(filedata[i]);
			split_k(demmy, temp, filedata[i], ':', count);
			left_trim_k(ssid, temp, strlen_k(temp));
			if (!strcmp_k(ssid, "Green Hackers"))
			{
				puts(ssid);
				printf("Power is ON");
			}
			
		}
	}
		// check the first four letters whether 'SSID'
		// if found, split by :
		// take right side, or index 1 and trim it
		// compare whether the target SSID is online
		// if found, do - sms, email, http, send data
	fclose(fi);
	
	return status;
}

int startwith(const char* source,const char* phrase,int start_index,int count)
{
	int found = 1;
	for (int j = start_index; j < start_index + count; j++)
	{
		if (source[j] != phrase[j - start_index])
		{
			found = 0;
			break;
		}
	}
	return found;
}

