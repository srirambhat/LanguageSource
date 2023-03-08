#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <stdbool.h>

typedef enum _registry_type_
{
	BLANK_REGISTRY = 0,
	UNICAST_REGISTRY,
	CASE_REGISTRY,
	FOR_REGISTRY,
	WHILE_REGISTRY,
	DOWHILE_REGISTRY,
} REGISTRY_TYPE;

typedef enum _registry_def_
{
	DEFAULT_BLANK = 0,
	POWER_STATUS_INDICATION_REGISTRY,
	BATTERY_STATUS_CHANGE_REGISTRY,
	WLC_PEN_STATUS_CHANGE_REGISTRY,
	WLC_KB_STATUS_CHANGE_REGISTRY,
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
	printf("\n i = %d a = %s", i, a);
}

bool reg_create(REGISTRY_DEFINITION def, REGISTRY_TYPE type, char *name)
{
	bool status = false;

	if (type == UNICAST_REGISTRY) {
		
		if (head == NULL) {
			head = malloc(sizeof(REGISTRY));
			if (!head) {
				printf("\n Memory Allocation Failed\n");
				status = false;
			}
			else {
				printf("\n Allocated Memory, creating structure");

				head->next = NULL;
				head->type = type;
				head->def = def;
				head->registry_name = malloc(sizeof(name));
				strcpy_s(head->registry_name, sizeof(name), name);
				head->fPtr = (void *) &default_func;
				status = true;
			}
		}
		else {
			// Since it is a single call function registry
		}
	}

	return (status);
}


bool reg_add(REGISTRY_DEFINITION def, void(*fptr)())
{
	bool status = false;

	if (head == NULL) {
		return status;
	}
	else {
		head->fPtr = fptr;
		status = true;
	}
	return status;
}

bool reg_close(REGISTRY_DEFINITION def)
{
	bool status = false;

	if (head) {
		free(head->registry_name);
		free(head);
		status = true;
	}
	return status;
}

bool reg_exec(REGISTRY_DEFINITION def, int i, char *a)
{
	bool status = false;

	if (head == NULL) {
		printf("\n No such registry");
		return status;
	}
	else {
		printf("\n Calling fPtr");
		head->fPtr(i, a);
		status = true;
	}
	return status;
}

void loggin_func(int i, char *a)
{
	printf("\n In Logging Function Funcion");
	printf("\n i = %d a = %s", i, a);
}

void main()
{
	reg_create(POWER_STATUS_INDICATION_REGISTRY, UNICAST_REGISTRY, "LOGGING REGISTRY");

	//	reg_add(DEF_LOGGING, (void *)&loggin_func);

	reg_exec(POWER_STATUS_INDICATION_REGISTRY, 19, "ABCD");

	reg_close(POWER_STATUS_INDICATION_REGISTRY);

	printf("\n");
}
