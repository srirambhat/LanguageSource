#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <stdbool.h>

typedef enum _registry_type_
{
	TYPE_BLANK = 0,
	TYPE_SINGLE,
	TYPE_CASE,
	TYPE_FOR,
	TYPE_WHILE, 	
	TYPE_DOWHILE
} REGISTRY_TYPE;

typedef enum _registry_def_
{
	DEF_BLANK = 0,
	DEF_LOGGING
} REGISTRY_DEFINITION;

typedef struct _registry 
{
	void (*fPtr) (int, char *);
	char *registry_name;
	REGISTRY_TYPE type;	
	REGISTRY_DEFINITION def;	
	struct _registry *next;
} REGISTRY;

REGISTRY *head;

void default_func(int i, char *a)
{
	printf("\n In Default Funcion");
	printf("\n i = %d a = %s",i,a);
}

bool reg_create(REGISTRY_DEFINITION def, REGISTRY_TYPE type, char *name)
{

	if (type == TYPE_SINGLE) {

		if (head == NULL) {
			head = malloc(sizeof(REGISTRY));
			printf("\n Created the structure.");

			head->next = NULL;
			head->type = type;
			head->def = def;
			head->registry_name = malloc(sizeof(name));
			strcpy(head->registry_name, name);
			head->fPtr = &default_func;
		} else {
			// Since it is a single call function registry
		}
	}
}


bool reg_add(REGISTRY_DEFINITION def, void (*fptr)())
{
	if (head == NULL) {
		return 0;
	} else {
		head->fPtr = fptr;
	}	
	
}

bool reg_close(REGISTRY_DEFINITION def)
{
	if (head) {
		free(head->registry_name);
		free(head);
	}
}

bool reg_exec(REGISTRY_DEFINITION def, int i, char *a)
{
	if (head == NULL) {
		printf("\n No such registry");
	} else {
		printf("\n Calling fPtr");
		head->fPtr(i, a);		
	}
}

void loggin_func(int i, char *a)
{
	printf("\n In Logging Function Funcion");
	printf("\n i = %d a = %s",i,a);
}

void main()
{
	reg_create(DEF_LOGGING, TYPE_SINGLE, "LOGGING REGISTRY");

//	reg_add(DEF_LOGGING, (void *)&loggin_func);

	reg_exec(DEF_LOGGING, 19, "ABCD");

	reg_close(DEF_LOGGING);

	printf("\n");
}
