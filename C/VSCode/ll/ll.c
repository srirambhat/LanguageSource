#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <stdbool.h>

typedef struct _node {
   int data;
   int key;
   struct _node *next;
} NODE;

NODE *head = NULL;
NODE *current = NULL;

//display the list
void printList() 
{
   NODE *ptr = head;
   printf("\n[ ");
	
   //start from the beginning
   while(ptr != NULL) {
      printf("(%d,%d) ",ptr->key,ptr->data);
      ptr = ptr->next;
   }
	
   printf(" ]");
}

//insert link at the first location
void insertFirst(int key, int data) 
{
   //create a link
   NODE *link = (NODE *) malloc(sizeof(NODE));
	
   link->key = key;
   link->data = data;
	
   //point it to old first node
   link->next = head;
	
   //point first to new first node
   head = link;

	printf("\n Inserting key: %d Data: %d",key,data);	
}

//delete first item
NODE* deleteFirst() 
{

   //save reference to first link
   NODE *tempLink = head;
	
   //mark next to first link as first 
   head = head->next;
	
   //return the deleted link
   return tempLink;
}

//is list empty
bool isEmpty() 
{
   return head == NULL;
}

int length() 
{
   int length = 0;
   NODE *current;
	
   for(current = head; current != NULL; current = current->next) {
      length++;
   }
	
   return length;
}

//find a link with given key
NODE* find(int key) 
{

   //start from the first link
   NODE* current = head;

   //if list is empty
   if(head == NULL) {
      return NULL;
   }

   //navigate through list
   while(current->key != key) {
	
      //if it is last node
      if(current->next == NULL) {
         return NULL;
      } else {
         //go to next link
         current = current->next;
      }
   }      
	
   //if data found, return the current Link
   return current;
}

//delete a link with given key
NODE* delete(int key) 
{

   //start from the first link
   NODE* current = head;
   NODE* previous = NULL;
	
   //if list is empty
   if(head == NULL) {
      return NULL;
   }

   //navigate through list
   while(current->key != key) {

      //if it is last node
      if(current->next == NULL) {
         return NULL;
      } else {
         //store reference to current link
         previous = current;
         //move to next link
         current = current->next;
      }
   }

   //found a match, update the link
   if(current == head) {
      //change first to point to next link
      head = head->next;
   } else {
      //bypass the current link
      previous->next = current->next;
   }    
	
   return current;
}

void sort() 
{

   int i, j, k, tempKey, tempData;
   NODE *current;
   NODE *next;
	
   int size = length();
   k = size ;
	
   for ( i = 0 ; i < size - 1 ; i++, k-- ) {
      current = head;
      next = head->next;
		
      for ( j = 1 ; j < k ; j++ ) {   

         if ( current->data > next->data ) {
            tempData = current->data;
            current->data = next->data;
            next->data = tempData;

            tempKey = current->key;
            current->key = next->key;
            next->key = tempKey;
         }
			
         current = current->next;
         next = next->next;
      }
   }   
}

void reverse(NODE** head_ref) 
{
   NODE* prev   = NULL;
   NODE* current = *head_ref;
   NODE* next;
	
   while (current != NULL) {
      next  = current->next;
      current->next = prev;   
      prev = current;
      current = next;
   }
	
   *head_ref = prev;
}

void main() 
{
   	insertFirst(1,10);
   	insertFirst(2,20);
   	insertFirst(3,30);
   	insertFirst(4,1);
   	insertFirst(5,40);
   	insertFirst(6,56); 
	
   	printf("\nOriginal List: "); 
		
   	//print list
   	printList();
	
	reverse(&head);
	
	printf("\n Reversed List:");
   	//print list
   	printList();

   	while(!isEmpty()) {            
   	   NODE *temp = deleteFirst();
   	   printf("\nDeleted value:");
   	   printf("(%d,%d) ",temp->key,temp->data);
   	}  
		
   	printf("\nList after deleting all items: ");
   	printList();
   	insertFirst(1,10);
   	insertFirst(2,20);
   	insertFirst(3,30);
   	insertFirst(4,1);
   	insertFirst(5,40);
   	insertFirst(6,56);
	
   	printf("\nRestored List: ");
   	printList();
   	printf("\n");  
	
   	NODE *foundLink = find(4);
		
   	if(foundLink != NULL) {
   	   printf("Element found: ");
   	   printf("(%d,%d) ",foundLink->key,foundLink->data);
   	   printf("\n");  
   	} else {
   	   printf("Element not found.");
   	}
	
   	delete(4);
   	printf("List after deleting an item: ");
   	printList();
   	printf("\n");
   	foundLink = find(4);
		
   	if(foundLink != NULL) {
   	   printf("Element found: ");
   	   printf("(%d,%d) ",foundLink->key,foundLink->data);
   	   printf("\n");
   	} else {
   	   printf("Element not found.");
   	}
		
   	printf("\n");
   	sort();
        
   	printf("List after sorting the data: ");
   	printList();
       
   	reverse(&head);
   	printf("\nList after reversing the data: ");
   	printList();

	printf("\n");
}
