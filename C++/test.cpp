#include <iostream>


#define INT16 __int16
#define INT32 __int32
#define INT64 __int64

typedef struct __node
{
    INT16 value;
    struct __node *next;
} NODE;

static NODE *s_list;

void AddToList(INT16 value)
{
    NODE new *element;

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

void PrintList()
{
    NODE *tmp = s_list;

    printf("List: ");

    while (tmp)
    {
        std::cout << tmp->value << std::endl;
        tmp = tmp->next;
    }
}


int main()
{
    std::cout << "Hello, World!" << std::endl;
    AddToList(4);
    AddToList(10);
    AddToList(30);
    PrintList();
    return 0;
}