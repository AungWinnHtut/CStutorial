#include<stdio.h>
int intro()
{
   
 
    int age;
    int tax;
   char c;
    float f;

    age = 10;
    c = 'a';
    f = 2.45;

    printf("Please Enter your age: ");
    scanf_s("%c", &c);

    //Process
    tax = age * 2;

    printf("age = %d years so the tax will be %d kyats\n", age,tax);
    printf("char = %c \n", c);
    printf("float = %f \n", f);


    return 0;
}
