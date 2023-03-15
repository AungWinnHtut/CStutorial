#include<stdio.h>
#include<stdlib.h>
#include<string.h>

typedef struct iotData {
	int id;
	char key[20];
}iotDATA;

typedef struct iotNode {
	iotDATA data;	
	struct iotNode *nextPtr;
}iotNODE;

int enqueue(iotNODE** head, iotNODE** tail, iotDATA data);
iotDATA dequeue(iotNODE** head, iotNODE** tail);
void printQueue(iotNODE* current);


int main()
{
	iotDATA d = { 1,"k1" };
	iotNODE* h = (iotNODE*)malloc(sizeof(iotNODE));
	iotNODE* t = (iotNODE*)malloc(sizeof(iotNODE));
	h = NULL;
	t = NULL;
	printQueue(h);

	enqueue(&h, &t, d);
	printQueue(h);

	d.id = 2;
	strcpy_s(d.key, "k2");
	enqueue(&h, &t, d);
	printQueue(h);

	d.id = 3;
	strcpy_s(d.key, "k3");
	enqueue(&h, &t, d);
	printQueue(h);

	d = dequeue(&h, &t);
	printf("we got %d %s\n", d.id, d.key);
	printQueue(h);
	d = dequeue(&h, &t);
	printf("we got %d %s\n", d.id, d.key);
	printQueue(h);
	d = dequeue(&h, &t);
	printf("we got %d %s\n", d.id, d.key);
	printQueue(h);

	return 0;
}

int enqueue(iotNODE** head, iotNODE** tail,iotDATA data)
{
	iotNODE* new_node = (iotNODE*)malloc(sizeof(iotNODE));
	if (new_node != NULL)
	{
		new_node->data = data;
		new_node->nextPtr = NULL;
		//pass
		if (*head == NULL)
		{
			*head = new_node;
		}
		else
		{
			(*tail)->nextPtr = new_node;
		}
		*tail = new_node;
		return 1; //added
	}
	else {
		//fail to create
		printf("memorry error\n");
		return 0; //fail
	}

}

iotDATA dequeue(iotNODE** head, iotNODE** tail)
{
	iotDATA data = {};
	iotNODE* temp = *head;
	data = (*head)->data;
	*head = (*head)->nextPtr;
	if (*head == NULL)//no data or single block of data
	{
		*tail = NULL;
	}
	return data;
}

void printQueue(iotNODE* current)
{
	if (current != NULL)
	{
		printf("Queue\n");
		while (current != NULL) {
			printf("%d %s\n", current->data.id, current->data.key);
			current = current->nextPtr;
		}
		printf("End Queue\n\n");
	
	}
	else {
		printf("empty queue!\n");
	}
}
