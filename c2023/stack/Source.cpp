#include<stdio.h>
#include<stdlib.h>
#include<string.h>

typedef struct iotData {
	int id;
	char key[10];
}iotDATA;

typedef struct iotNode {
	iotDATA data;
	struct iotNode * nextPtr;
}iotNODE;

int push(iotNODE** Top, iotDATA d);
void print(iotNODE* currentPtr);
struct iotData pop(iotNODE** Top);

int main()
{
	iotNODE* T = NULL;	
	iotDATA k1 = {};
	k1.id = 1;
	strcpy_s(k1.key, 10, "key1");
	push(&T, k1);

	k1.id = 2;
	strcpy_s(k1.key, 10, "key2");
	push(&T, k1);

	k1.id = 3;
	strcpy_s(k1.key, 10, "key3");
	push(&T, k1);
	print(T);

	k1=pop(&T);
	printf("id=%d key=%s \n", k1.id, k1.key);
	print(T);

	k1 = pop(&T);
	printf("id=%d key=%s \n", k1.id, k1.key);
	print(T);

	k1 = pop(&T);
	printf("id=%d key=%s \n", k1.id, k1.key);
	print(T);
	


	return 0;
}

int push(iotNODE** Top, iotDATA d)
{
	iotNODE* node = (iotNODE*) malloc(sizeof(iotNODE));	
	if (node != NULL)
	{
		//if pass
		node->data = d;
		node->nextPtr = *Top;
		*Top = node;
		return 1; //success
	}
	else {
		return 0;
		printf("No more memory in HEAP\n");
	}
	
}

void print(iotNODE* currentPtr)
{
	if (currentPtr == NULL)
	{
		printf("empty stack, no data to show\n");
	}
	else {
		printf("Stack\n");
		printf("=====\n");
		while (currentPtr != NULL)
		{
			printf("id=%d\tkey=%s\n", currentPtr->data.id, currentPtr->data.key);
			currentPtr = currentPtr->nextPtr;
		}
	}
}

struct iotData pop(iotNODE** Top)
{
	struct iotData data = {};
	if (*Top != NULL)
	{
		//if pass
		iotNode* temp = *Top;
		data = (*Top)->data;
		*Top = temp->nextPtr;
		free(temp);
		return data; //success
	}
	else {
		printf("empty stack, can't pop\n");
		{
			return data;
		}
	}
}