#include<stdio.h>
#include<stdlib.h>
#include<string.h>

struct iotNode {
	int id;
	char api_key[20];
	struct iotNode* nextPtr;
};
void instruction();
int isEmpty(struct iotNode* sPtr);
void printList(struct iotNode* currentPtr);
int length(struct iotNode* sPtr);
void append(struct iotNode** sPtr, int id, const char* key);
// TODO

int deleteEnd(struct iotNode** sPtr);
void insertFirst(struct iotNode** sPtr, int id, const char* key);
int deleteFirst(struct iotNode** sPtr);
struct iotNode* find(struct iotNode* currentPtr, int id);
struct iotNode* find(struct iotNode* currentPtr, const char* apikey);
int deletefun(int id);
int deletefun(const char* apikey);
// End of TODO

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
	printf("The List contains %d data\n", length(DSptr));

	struct iotNode* foundPtr = NULL;
	foundPtr = find(DSptr, "key200");
	if (foundPtr != NULL)
	{
		printf("We found it!\n");
		printf("id=%d\tapikey=%s\n\n", foundPtr->id, foundPtr->api_key);
	}
	else {
		printf("We could't find it!\n\n");
	}

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

int length(struct iotNode* currentPtr)
{
	int count = 0;
	if (isEmpty(currentPtr))
	{
		return 0;
	}
	else {
		
		while (currentPtr != NULL)
		{
			count++;
			currentPtr = currentPtr->nextPtr; //Next block
		}
		return count;
	}
}

struct iotNode* find(struct iotNode* currentPtr, int id)
{
	int count = 0;
	if (isEmpty(currentPtr))
	{
		return NULL;
	}
	else {

		while (currentPtr != NULL)
		{
			if (id == currentPtr->id)
			{
				return currentPtr;
			}
			else {
				currentPtr = currentPtr->nextPtr; //Next block
			}			
		}		
		return NULL;
	}
}

struct iotNode* find(struct iotNode* currentPtr,const char* apikey)
{
	int count = 0;
	if (isEmpty(currentPtr))
	{
		return NULL;
	}
	else {

		while(currentPtr != NULL)
		{
			if (!strcmp(currentPtr->api_key,apikey))
			{
				return currentPtr;
			}
			else {
				currentPtr = currentPtr->nextPtr; //Next block
			}
		}
		return NULL;
	}
}