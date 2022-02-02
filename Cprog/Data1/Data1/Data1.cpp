
#include <stdio.h>
#include<conio.h>
#include<stdlib.h>
void menu(int selection);

char _menu[3][5] = { 
   "NEW",
   "OPEN",
   "SAVE"
};

int main()
{
    char ch=0;
    int selection = 0; //0 1 2


      do{
          printf("\033[2J\033[1;1H");
           menu(selection);
           ch = _getch();
           switch (ch) {
                case 75:  selection = (selection != 0) ? --selection : 2; break; //up
                case 77:   selection = (selection != 2) ? ++selection : 0; break;  //down  selection = ++selection;
                case 27:   exit(0);
           }
      } while (ch != 27);     

      return 0;
}

void menu(int selection)
{
   
    for (int row = 0; row < 3; row++)
    {         
        for (int col= 0; col < 4; col++)
        {
            putchar(_menu[row][col]);
        }
        printf("    ");
    }
    printf("\n");

       
    for (int i = 1; i <= selection*2; i++)
    {
        printf("   ");
    }
    //NEW ssss OPEN ssss SAVE
    //123 4567 8901 2345 6789
} //1-3 8-14 16-4
