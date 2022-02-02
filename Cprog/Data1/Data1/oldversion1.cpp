
#include <stdio.h>
#include<conio.h>
#include<stdlib.h>
void menu1(int selection);

char _menu1[3][5] = {
   "NEW",
   "OPEN",
   "SAVE"
};

int main1()
{
    char ch = 0;
    int selection = 0; //0 1 2


    do {
        system("cls");
        menu1(selection);
        ch = _getch();
        switch (ch) {
        case 72:  selection = (selection != 0) ? --selection : 2; break; //up
        case 80:   selection = (selection != 2) ? ++selection : 0; break;  //down  selection = ++selection;
        case 27:   exit(0);
        }
    } while (ch != 27);

    return 0;
}

void menu1(int selection)
{
    for (int row = 0; row < 3; row++)
    {
        if (row == selection)
            printf("    #   ");
        else
            printf("        ");

        for (int col = 0; col < 4; col++)
        {
            putchar(_menu1[row][col]);
        }
        printf("\n");
    }
}
