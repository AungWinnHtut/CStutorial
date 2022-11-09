#include<string.h>
#include<stdio.h>

struct studata {
	int age;
	char name[20];
	float length;
};

class STUDENT {
	int age;
	char name[20];
	float length;
public:
	void swim()
	{
		printf("swimming");
	}
	void eat()
	{
		printf("eating");
	}
	void write()
	{
		printf("writing");
	}
};




int main10() {
	struct studata tuntun;
	struct studata agag;
	tuntun.age = 23;
	STUDENT koko;
	//RUST

	char str1[100] = "This is ", str2[] = "programiz.com";
	char str3[100] = { '\0' };

	strcat_s(str1, str2);

	puts(str1);
	puts(str2);


	return 0;
}