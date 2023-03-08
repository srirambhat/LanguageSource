#include <stdio.h>
#include <Stdlib.h>

#define INT16 __int16
#define INT32 __int32
#define INT64 __int64

typedef struct __node
{
    INT16 value;
    struct __node *next;
} NODE;

static NODE *s_list;

static void AddToList(INT16 value)
{
    NODE *element;

    element = malloc(sizeof(NODE));
    if (!element)
    {
        printf("Unable to allocate Memory");
        return ;
    }

    element->value = value;

    if (s_list == NULL)
    {
        element->next = NULL;
        s_list = element;
    }
    else
    {
        element->next = s_list;
        s_list = element;
    }
}

static void FreeList()
{
    while (s_list)
    {
        NODE *tmp;
        tmp = s_list;
        s_list = s_list->next;
        free(tmp);
    }
}

static void PrintList()
{
    NODE *tmp = s_list;

    printf("List: ");

    while (tmp)
    {
        printf("%d ",tmp->value);
        tmp = tmp->next;
    }
}

void main(void)
{
    s_list = NULL;

    printf("Hello World");
    AddToList(4);
    AddToList(30);
    AddToList(10);
    PrintList();
    FreeList();
}