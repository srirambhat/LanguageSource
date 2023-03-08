#include <stdio.h>
#include <stdlib.h>
#include <assert.h>

unsigned int val, i;

int main(int argc, char** argv) 
{
	do {
		scanf_s("%d", &val);
		
		if (!val) break;

		printf("Value: %x\n", val);
		val = val << 24;
		printf("Value after shift: %x\n", val);
	} while (1);
}