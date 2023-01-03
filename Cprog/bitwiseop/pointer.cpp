#include<stdio.h>
#define SIZE 4
void cubeByReference(int* nPtr);
void cubeByReference(int* outPtr,const int* nPtr);
int main()
{
	int i = 10;
	int j = 0;
	int* iptr = &i;
	char c = 'a';
	char* cptr = &c;
	int ia[SIZE] = { 1,2,3,4 };
	int* iaptr = ia; //&ia[0];
	printf("size of ia = %zu\n", sizeof(ia));
	
	for (int i = 0; i < SIZE+6; i++)
	{
		printf("%d %d\n", i, ia[i]);
	}
	printf("pointer testing\n");
	for (int i = 0; i < SIZE ; i++)
	{
		printf("%d %c\n", i, *(cptr+i));
	}
	//*(cptr + 12) = 'z';
	//printf("%c", *(cptr+12));
	
	//cubeByReference(&i);
	cubeByReference(&j, &i);
	printf("i = %d j = %d\n", i,j);


	return 0;
}

void cubeByReference(int* nPtr) {
	 * nPtr = *nPtr * *nPtr * *nPtr; // cube *nPtr	
}
void cubeByReference(int* outPtr, const int* nPtr) {
	*outPtr = *nPtr * *nPtr * *nPtr; // cube *nPtr	
}