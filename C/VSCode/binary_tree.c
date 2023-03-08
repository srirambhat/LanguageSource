#include <stdio.h>
#include <string.h>

// Define the Binary Tree
struct binary_tree {
	int data;
	struct binary_tree * right, * left;
};
typedef struct binary_tree NODE;

void insert(NODE **tree, int val) 
{
	NODE *temp = NULL;

	if (!(*tree)) {
		temp = malloc(sizeof(NODE));
		if (!temp) {
			printf("\n No More Memory");
			exit(1);
		}
		temp-> right = temp->left = NULL;
		temp->data = val;
		*tree = temp;
		return ;
	}

	if (val < (*tree)->data)) {
		insert(&(*tree)->left, val);
	}

	if (val > (*tree)->data)) {
		insert(&(*tree)->right, val);
	}
}

void print_preoder (NODE *tree) {
	
	if (tree) {
		printf("%d ", tree->data);
		print_preorder(tree->left);
		print_preorder(tree->right);
	}

}

void print_inorder(NODE *tree)
{
    if (tree)
    {
        print_inorder(tree->left);
        printf("%d ",tree->data);
        print_inorder(tree->right);
    }
}

void print_postorder(NODE *tree)
{
    if (tree)
    {
        print_postorder(tree->left);
        print_postorder(tree->right);
        printf("%d ",tree->data);
    }
}

void deltree(NODE *tree)
{
    if (tree)
    {
        deltree(tree->left);
        deltree(tree->right);
        free(tree);
    }
}

NODE* search(NODE **tree, int val)
{
    if(!(*tree))
    {
        return NULL;
    }

    if(val < (*tree)->data)
    {
        search(&((*tree)->left), val);
    }
    else if(val > (*tree)->data)
    {
        search(&((*tree)->right), val);
    }
    else if(val == (*tree)->data)
    {
        return *tree;
    }
}

void main()
{
    NODE *root;
    NODE *tmp;
    //int i;

    root = NULL;
    /* Inserting nodes into tree */
    insert(&root, 9);
    insert(&root, 4);
    insert(&root, 15);
    insert(&root, 6);
    insert(&root, 12);
    insert(&root, 17);
    insert(&root, 2);

    /* Printing nodes of tree */
    printf("Pre Order Display\n");
    print_preorder(root);

    printf("In Order Display\n");
    print_inorder(root);

    printf("Post Order Display\n");
    print_postorder(root);

    /* Search node into tree */
    tmp = search(&root, 4);
    if (tmp)
    {
        printf("Searched node=%d\n", tmp->data);
    }
    else
    {
        printf("Data Not found in tree.\n");
    }

    /* Deleting all nodes of tree */
    deltree(root);
}