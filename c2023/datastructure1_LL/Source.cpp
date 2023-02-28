#include<stdio.h>
#include<stdlib.h>
#include<string.h>

struct iotNode {
	int id;
	char api_key[20];
	struct iotNode* nextPtr;
};
void instruction();
void append(struct iotNode** sPtr, int id, const char* key);
int isEmpty(struct iotNode* sPtr);
void printList(struct iotNode* currentPtr);

int main()
{	
	struct iotNode* DSptr = NULL;
	printf("Before inserting\n");
	if (isEmpty(DSptr))
	{
		printf("Empty List\n");
	}
	else
	{
		printf("Valid List\n");
	}
	for (int i = 0; i < 100; i++)
	{
		char buffer[6] = { '\0' };
		char key[10] = { '\0'};
		strcpy_s(key, "key");
		_itoa_s(i, buffer, 10);
		strcat_s(key, buffer);
		append(&DSptr, i,key);
	}
	printf("After inserting\n");
	if (isEmpty(DSptr))
	{
		printf("Empty List\n");
	}
	else
	{
		printf("Valid List\n");
	}
	printList(DSptr);

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

		// Starting point 
		struct iotNode* previusPtr = NULL;
		struct iotNode* currentPtr = *sPtr;

		while ( currentPtr!=NULL && currentPtr->nextPtr != NULL) //Not end and 
		{
			previusPtr = currentPtr;
			currentPtr = currentPtr->nextPtr;
		}
		//if the ds is empty then previus pointer is still NULL (because never enter into while loop)
		if (currentPtr == NULL)
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

int isEmpty(struct iotNode *sPtr)
{
	return (sPtr == NULL);
}

void printList(struct iotNode* currentPtr)
{
	if (isEmpty(currentPtr))
	{
		printf("List is Empty\n");
	}
	else {
		printf("List Data\n");
		printf("========\n");
		printf("%6s\t%10s\n", "ID", "KEY");
		while (currentPtr != NULL)
		{
			printf("%6d\t%10s\n", currentPtr->id, currentPtr->api_key);
			currentPtr = currentPtr->nextPtr;
		}
		printf("--- List END ---\n\n");
	}
}