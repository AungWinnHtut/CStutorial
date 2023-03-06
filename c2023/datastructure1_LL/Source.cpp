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
int deleteEnd(struct iotNode** sPtr);
struct iotNode* find(struct iotNode* currentPtr, int id);
struct iotNode* find(struct iotNode* currentPtr, const char* apikey);
int deleteFirst(struct iotNode** sPtr);
int deletefun(struct iotNode** sPtr, int id);
int deletefun(struct iotNode** sPtr, const char* apikey);
void insertFirst(struct iotNode** sPtr, int id, const char* key);
// TODO


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
	if (deleteEnd(&DSptr))
	{
		printf("Deleted!\n");
	}
	else {
		printf("Cannot Delete!\n");
	}
	for (int i = 0; i <3; i++)
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

	if (deleteEnd(&DSptr))
	{
		printf("Deleted!\n");
	}
	else {
		printf("Cannot Delete!\n");
	}

	printList(DSptr);
	printf("The List contains %d data\n", length(DSptr));

	if (deletefun(&DSptr,"key0"))
	{
		printf("Deleted!\n");
	}
	else {
		printf("Cannot Delete!\n");
	}

	printList(DSptr);
	printf("The List contains %d data\n", length(DSptr));
	insertFirst(&DSptr, 123, "key123");
	printList(DSptr);
	printf("The List contains %d data\n", length(DSptr));
	/*
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
	*/


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
void insertFirst(struct iotNode** sPtr, int id, const char* key)
{
	// DMA create
	struct iotNode* newPtr = (iotNode*)malloc(sizeof(iotNode)); //void * must be casted to (iotNode *)
	if (newPtr != NULL)
	{
		//prepare data in DMA to insert
		newPtr->id = id;
		strcpy_s(newPtr->api_key, key);
		newPtr->nextPtr = NULL;
		
		//if the ds is empty then previus pointer is still NULL (because never enter into while loop)
		if (*sPtr == NULL)
		{
			*sPtr = newPtr;			
		}
		else {			
			newPtr->nextPtr = *sPtr; // connect to old start
			*sPtr = newPtr;			      // new start
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

int  deleteEnd(struct iotNode** sPtr)
{
	// DMA create
	if (isEmpty(*sPtr))
	{
		printf("Empty DS, cannot delete!\n");
		return 0;
	}
		// Starting point 
		struct iotNode* previusPtr = NULL;
		struct iotNode* currentPtr = *sPtr;

		//check if only one data? first data?
		if (currentPtr->nextPtr == NULL)
		{
			*sPtr = NULL;  //Deleted first one
			free(currentPtr);
			return 1;
		}

		while (currentPtr->nextPtr != NULL) //Not end and 
		{
			previusPtr = currentPtr;
			currentPtr = currentPtr->nextPtr;
		}
		//delete currentPtr
		//previusPtr become last
		previusPtr->nextPtr = NULL;
		free(currentPtr);
		return 1;
}


int  deleteFirst(struct iotNode** sPtr)
{
	// DMA create
	if (isEmpty(*sPtr))
	{
		printf("Empty DS, cannot delete!\n");
		return 0;
	}
	// Starting point 
	struct iotNode* previusPtr = NULL;
	struct iotNode* currentPtr = *sPtr;

	//check if only one data? first data?
	if (currentPtr->nextPtr == NULL)
	{
		*sPtr = NULL;  //Deleted first one
		free(currentPtr);
		return 1;
	}
	previusPtr = currentPtr;
	currentPtr = currentPtr->nextPtr;

	*sPtr = currentPtr;
	free(previusPtr);	

	return 1;
}
//1. check if DS exist? if not exit with fail to del
//2. check if found at first block, 
////(if only one block then no more data - NULL, 
////else start pointer point to next block) 
////then delete it, make start null and exit with success
//3. not found but only one DS, then exit with fail to del
//4. if two and more data exists then do loop
///////////////////////////////////////////////////////
///////////// Do Loop //////////
// 1. move to next block
// 2. check if not found, and if not end then go to step 1
// 3. found
//// 3.a. found at end, previus will now end
//// 3.b. found at middle, duty change

int deletefun(struct iotNode** sPtr, int id)
{
	int count = 0;
	struct iotNode* currentPtr = *sPtr;
	struct iotNode* previusPtr = NULL;
	if (isEmpty(currentPtr)) //DS exist?
	{
		return 0;
	}
	else if  (id == currentPtr->id) //found on first one
	{
		if (currentPtr->nextPtr == NULL)
		{
			*sPtr = NULL; //no more data
		}
		else
		{
			*sPtr = currentPtr->nextPtr;
		}
		
		free(currentPtr);
		return 1;
	}	
	else if (currentPtr->nextPtr == NULL) //if only one block and not found
	{
		return 0;
	}

	//at least second one
	do 
	{		
		previusPtr = currentPtr;
		currentPtr = currentPtr->nextPtr; //Next block		
		
		if (id == currentPtr->id ) //found
		{
			//if end?
			if (currentPtr->nextPtr == NULL)
			{
				previusPtr->nextPtr = NULL; //new end
			}
			else {
				//found in the middle 					
				previusPtr->nextPtr = currentPtr->nextPtr;			
			}
			free(currentPtr); //delete it 
			return 1;		      //success flag				
		}
		//if not found, then go to next block -
		
	} while (currentPtr->nextPtr != NULL);
	//if reach here, not found totally
	return 0;
}

int deletefun(struct iotNode** sPtr, const char* api_key)
{
	int count = 0;
	struct iotNode* currentPtr = *sPtr;
	struct iotNode* previusPtr = NULL;
	if (isEmpty(currentPtr)) //DS exist?
	{
		return 0;
	}
	
	else if (!strcmp(api_key, currentPtr->api_key)) //found on first one
	{
		if (currentPtr->nextPtr == NULL)
		{
			*sPtr = NULL; //no more data
		}
		else
		{
			*sPtr = currentPtr->nextPtr;
		}

		free(currentPtr);
		return 1;
	}
	else if (currentPtr->nextPtr == NULL) //if only one block and not found
	{
		return 0;
	}

	//at least second one
	do
	{
		previusPtr = currentPtr;
		currentPtr = currentPtr->nextPtr; //Next block		

		if (!strcmp(api_key, currentPtr->api_key)) //found
		{
			//if end?
			if (currentPtr->nextPtr == NULL)
			{
				previusPtr->nextPtr = NULL; //new end
			}
			else {
				//found in the middle 					
				previusPtr->nextPtr = currentPtr->nextPtr;
			}
			free(currentPtr); //delete it 
			return 1;		      //success flag				
		}
		//if not found, then go to next block -

	} while (currentPtr->nextPtr != NULL);
	//if reach here, not found totally
	return 0;
}