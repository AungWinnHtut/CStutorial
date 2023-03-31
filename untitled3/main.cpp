#include <stdio.h>
#include<iostream>
#include <string.h>
void changA(int *a);
using namespace std;
int main() {

    int ia[3]={1,2,3};
    char ca[3]={'a','b','c'};

    for(int i : ia)
    {
        cout<<i<<endl;
    }
    return 0;
}

