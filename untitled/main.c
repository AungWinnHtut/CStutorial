#include <stdio.h>

typedef struct dimension{
    int feet;
    int inches;
}dimension;

typedef struct Area{
   dimension length;
   dimension width;
   float area;
}Area;

int main() {
    Area K1,K2;
    K1.length.feet=10;
    K1.length.inches=5;
    K1.width.feet=10;
    K1.width.inches=5;
    K1.area = (K1.length.feet+K1.length.inches/12) * (K1.width.feet+K1.width.inches/12);


    printf("Hello, World!\n");
    return 0;
}
