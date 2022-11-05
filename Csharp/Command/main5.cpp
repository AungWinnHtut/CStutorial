#include<stdio.h>
int funCubeValue(int n);
void funCubeReference(int* nPtr); //int *nPtr = & i;
void swap(int* x, int* y); 
int sum(const int* num, int i);

int main5()
{
	int i = 10;
	int j = 5;
	printf("0x%p", &i);
	printf("0x%p", &j);
	return 0;
}

void swap( int *x, int *y)
{
	int temp = 0;

	temp = *x;  //x = 4, y =5, temp = x = 4;
	*x = *y;       //x=y=5, y=5,temp=4
	*y = temp; //x = 5, y =temp=4, temp = 4
}


int sum(const int* num,int i)
{
	int result = 0;
	for (int k = 0; k < i; k++)
	{
		result = result + *num;
		++num;	
	}
	return result;
}




int funCubeValue(int n) //int n = i;
{
	int cube = 0;
	cube = n * n * n;
	return cube;
}

void funCubeReference(int *nPtr) //int *nPtr = & i;
{
	*nPtr= (* nPtr)*(* nPtr)*(* nPtr);
	
}