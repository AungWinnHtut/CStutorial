#include <stdio.h>

int eg1() {
    int i;
    int c[4] = { 0,1,2,3 };
    i = 65;
    //printf("0x%x\n", c);
    printf("0x%x\n", &c[0]);
    printf("0x%x\n", &c[1]);
    printf("0x%x\n", &c[2]);
    printf("0x%x\n", &c[3]);
    printf("size of int = %d\n", sizeof(int));
    printf("size of char = %d\n", sizeof(char));

    int* firstadd = &c[0];
    printf("0x%x\n", *firstadd);
    printf("0x%x\n", *firstadd+1);
    printf("0x%x\n", *firstadd+2);
    printf("0x%x\n", *firstadd+3);
    // address = first_address + index * sizeof(datatype);
    // 0       first_add = 0x38;       0->add=first_add  1-> add=first+4=3c 
    return 0;


}