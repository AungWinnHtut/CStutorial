#include<stdio.h>
#include<string.h>
void request_amount(int* myacc);
int main()
{

    int my_balance = 0;
    int* my_bank_acc = &my_balance;
    request_amount(my_bank_acc);
    printf("My new balance after request is %d",my_balance);


    return 0;
}

void request_amount(int* myacc)
{
    *myacc += 100;
}


