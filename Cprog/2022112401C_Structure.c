#include <stdio.h>
#include <string.h>

typedef int INTEGER;

typedef struct PROFILE
{
    char name[20];
    INTEGER age;
    float height;
} PROFILE; // global variable

PROFILE student1, student2;

typedef struct data
{
    int a;
    int b;
    int c;
    char name[20];
} data;

data secret_stuff();
int main()
{
    // student1 = { "aungaung",22,5.6 };
    strncpy(student1.name, "aung aung alkdfjasd;lfjasl;dfjas;ldfjaldksjfals;djf", 20);
    student1.age = 22;
    student1.height = 5.6;

    data stuff_data = secret_stuff();
    printf("%s", stuff_data.name);
    return 0;
}

data secret_stuff()
{
    data mydata;
    mydata.a = 20;
    mydata.b = 40;
    mydata.c = 33;
    strncpy(mydata.name, "koko", 20);
    return mydata;
}