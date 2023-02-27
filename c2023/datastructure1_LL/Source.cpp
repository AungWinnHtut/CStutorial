#include<stdio.h>
#include<stdlib.h>
#include<string.h>

struct iotNode {
	int id;
	char api_key[20];
	struct iotNode* nextPtr;
};
void instruction();


int main()
{


	return 0;
}

void instruction()
{
	system("cls");
	printf("1-Insert Data\n");
	printf("\n");
	printf("\n");
	printf("\n");
	printf("0-Exit\n");
	
}

void append(struct iotNode **sPtr,int id,const char* key)
{
	// DMA create
	struct iotNode * newPtr = (iotNode *) malloc(sizeof(iotNode)); //void * must be casted to (iotNode *)
	if (newPtr != NULL)
	{
		//prepare data in DMA to insert
		newPtr->id = id;
		strcpy_s(newPtr->api_key, key);
		newPtr->nextPtr = NULL;

		struct iotNode* previusPtr = NULL;
		struct iotNode* currentPtr = *sPtr;

		while (currentPtr->nextPtr != NULL) //Not end and 
		{
			previusPtr = currentPtr;
			currentPtr = currentPtr->nextPtr;
		}
		//if the ds is empty then previus pointer is still NULL (because never enter into while loop)
		if (previusPtr == NULL)
		{
			 *sPtr =  newPtr;
		}
		else {
			currentPtr->nextPtr = newPtr;
		}
	}
	else {
		printf("IoT device id=%d fail to insert data", id);
	}

}