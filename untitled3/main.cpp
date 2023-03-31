#include <stdio.h>
#include <string.h>
void changA(int *a);

int main() {

    int ia[3]={1,2,3};
    char ca[3]={'a','b','c'};

    printf("%d\n",*ia);     //ia[0]
    printf("%d\n",*(ia+1)); //ia[1]
    printf("%d\n",*(ia+3)); //ia[2]
    return 0;
}

