

// TC5.CPP
// Programmer   Aung Win Htut (5th year)
// 29-7 -2000	Beginning
// 6 -11-2000	Update
// 15-11-2000   Update
// 21-11-2000   Update
// 13-12-2000   Update
// 15-12-2000   Update
// 15-1 -2001   Update
// 15-2 -2003   Update
/////////////////////////////////////////////////////////////////////////////
////////////////////////Function Declaration/////////////////////////////////
/////////////////////////////////////////////////////////////////////////////
#include "aung.h"
void MAINMENU(int s);                                     // line 472
void menu(char[19][19], char[19][19], int size, int pos); // 29-03-2003
void Clrscr();                                            // 15.11.2000
void Msgbox();                                            // 21.11.2000
void Dosshell();                                          // 21.11.2000
void MSGENCIPHER();                                       // 22.11.200
void MSGDECIPHER();                                       // 13.12.2000
void SCAN(void);                                          // 15.12.2000
HELP();                                                   // 15.1.2001
void SOUND();
void Splash();       // 26.2.2001
void HTUT();         // 26.2.2001    (About Aung Win Htut)
void DIRR();         // 27.2.2001
void BIOS1();        // 27.2.2001
void DEL1(int flag); // 27.2.2001
int SAVE();          // 27.2.2001
int CHANGE_DIR();    // 28.2.2001
void EN_1();         // 28.2.2001
void DN_1();         // 28.2.2001
K_DN();
K_EN();

void PROGRAMMER_Pull_Menu();
void PROGRAMMER_Pull_Menu();
void PROGRAMMER_menu(int pos2);

// void  pull();
void File_Pull_Menu();
void File_menu(int pos1);

Popup_Menu();
void Popup_menu(int pos1);

Project_Pull_Menu();
void Project_menu(int pos1);

void active_status_bar(int i, int j); //   line 830
void status_bar();

void Fore_Ground_window();
void PASSWORD(void); // 11.8.2001
void Dsta(void);     // 11.8.2001

/////////////////////////////////////////////////////////////////////////////
////////////////////////Variable Declaration/////////////////////////////////
/////////////////////////////////////////////////////////////////////////////
const int size = 7;

char list_Cap[size][19] = {"   E\0",
                           "   F\0",
                           "   H\0",
                           "   S\0",
                           "   S\0",
                           "   P\0",
                           "   H\0"};

char list[size][19] = {"xit  \0",
                       "ile  \0",
                       "acker  \0",
                       "ystem    \0",
                       "upervisor  \0",
                       "roject  \0",
                       "elp  \0"};

char Status[size][19] = {" Exit\0",
                         " File\0",
                         " PROGRAMMER\0",
                         " System  \0",
                         " Supervisor\0",
                         " Project\0",
                         " Help\0"};

char Status_Shortcut[size][19] = {" Esc\0",
                                  "Ctrl-F\0",
                                  " Ctrl-C\0",
                                  "   F1\0",
                                  " Ctrl-S\0",
                                  " Ctrl-P\0",
                                  " Tab-\0"};

char Status_Expressoin[size][100] = {"³ To Quit\0",
                                     "³ File management - Commands\0",
                                     "³ To show list of Programmer\0",
                                     "³ Temporarily exit to DOS_SHELL \0",
                                     "³ To show list of Supervisor\0",
                                     "³ To start C++ version 3.0\0",
                                     "³ To get online-help\0"};
enum MENU
{
    EXIT = 0,
    FILE_,
    PROGRAMMER,
    SYSTEM,
    SUPERVISOR,
    PROJECT,
    HELP_
};

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// FILE MENU
const File_Size1 = 8;
char file_list[File_Size1 + 2][19] = {
    " ÚÄÄÄÄÄÄÄÄÄÄ¿ \0",
    " ³          ³ \0",
    " ³          ³ \0",
    " ³          ³ \0",
    " ³          ³ \0",
    " ³          ³ \0",
    " ³          ³ \0",
    " ³ÄÄÄÄÄÄÄÄÄÄ³ \0",
    " ³          ³ \0",
    " ÀÄÄÄÄÄÄÄÄÄÄÙ \0"};
char file_list1[File_Size1][19] = {" D\0",
                                   " C\0",
                                   " S\0",
                                   " C\0",
                                   " D\0",
                                   " D\0",
                                   "\0",
                                   " E\0"};

char file_list2[File_Size1][19] = {"ir     \0",
                                   "heck   \0",
                                   "ave    \0",
                                   "hange  \0",
                                   "elete  \0",
                                   "el_opt \0",
                                   "**********\0",
                                   "xit    \0"};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
char File_Status_Expressoin[File_Size1][100] = {
    "³ Directory Listing\0",
    "³ Checking for BIOS\0",
    "³ Save the current file\0",
    "³ Change Directory\0",
    "³ Delete an existing file \0",
    "³ To operate personal file\0",
    "³ Just a break\0",
    "³ To Quit this software\0"};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
// PROGRAMMER MENU
// 11111111111111111111111111111111111111111111
const PROGRAMMER_Size1 = 1;
char PROGRAMMER_list[PROGRAMMER_Size1 + 2][25] = {" ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿ \0",
                                                  " ³                 ³ \0",
                                                  " ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ \0"};

char PROGRAMMER_list1[PROGRAMMER_Size1][19] = {"  Aung Win Htut \0"};

// 11111111111111111111111111111111111111111111
char PROGRAMMER_Status_Expressoin[PROGRAMMER_Size1][100] = {
    "³ To Show About Programmer Aung Win Htut\0"};
//@@@@@@@@@@@@@@@@@@@@@@
// PROJECT MENU
const Project_Size1 = 3;
char project_list[File_Size1 + 2][23] = {
    " ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿ \0",
    " ³               ³ \0",
    " ³               ³ \0",
    " ³               ³ \0",
    " ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ \0"};
char project_list1[File_Size1][19] = {" E\0",
                                      " D\0",
                                      " E\0"};

char project_list2[File_Size1][19] = {"ncryption    \0",
                                      "ecryption    \0",
                                      "xit          \0"};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
char Project_Status_Expressoin[Project_Size1][100] = {
    "³ To encrypt \0",
    "³ To decrypt\0",
    "³ To Quit this software\0"};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//@@@@@@@@@@@@@@@@@@@@@@
// PROJECT MENU
const Popup_Size1 = 3;
char Popup_list[Popup_Size1 + 2][23] = {
    " ÚÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄ¿ \0",
    " ³               ³ \0",
    " ³               ³ \0",
    " ³               ³ \0",
    " ÀÄÄÄÄÄÄÄÄÄÄÄÄÄÄÄÙ \0"};
char popup_list1[Popup_Size1][19] = {" E\0",
                                     " D\0",
                                     " E\0"};

char popup_list2[Popup_Size1][19] = {"ncryption    \0",
                                     "ecryotion    \0",
                                     "xit          \0"};
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
char Popup_Status_Expressoin[Project_Size1][100] = {
    "³ To encrypt \0",
    "³ To decrypt\0",
    "³ To Quit this software\0"};

//****************************************************************************
//                            	MAIN  START HERE
//****************************************************************************

void main(void)
{
    PASSWORD();                      // Identication ROUTING
    Dsta();                          // Splesh Screen
    SCAN();                          // Animation ROUTING for LOADING
    clrscr();                        // Clear the screen
    Window(1, 1, 80, 25, LIGHTGRAY); // CREATE LIGHT GRAY screen
    status_bar();                    // CREAT Status Bar
    Window(1, 1, 80, 23, 1);         // CREAT Foure Ground Window
    MAINMENU(1);                     // CALLING Mainmenu_ROUTING
}
//****************************************************************************
//			       MAINMENU_FUN START HERE
//****************************************************************************
void MAINMENU(int s)
{
    int index = s;                         //'s'  is USED for identifying parameter for MENU_INDEX
    char ch;                               //'ch' id USED for TEMP_VAR while reading command
    Window(1, 2, 80, 22, 1);               // CREAT BLUE SCREEN
    Splash();                              // SPLASH SCREEN
    Window(1, 1, 80, 1, LIGHTGRAY);        // CREAT LIGHT GRAY SCREEN
    textcolor(BLACK);                      // MAKE TEXT_COLOR BLACK
    menu(list_Cap, list, size, index - 1); // CALL FUN_MENU With (Index-1)
    do
    {
        _setcursortype(_NOCURSOR);
        ch = getch(); // READ A CHARACTER FROM KEYBOARD

        if (ch == char(0))
            ch = getch();

        switch (ch) // MENU SELECTING ROUTING
        {
        case char(16):
            _setcursortype(_NORMALCURSOR); // ctrl_p  PROJECT MENU HOT_KEY
            active_status_bar(5, 1);       // PROJECT A_S
            // menu(5);		    //SELECT PROJECT MENU
            menu(list_Cap, list, size, PROJECT);
            Project_Pull_Menu(); // MAKE PROJECT PULLDOWN MENU
            MAINMENU(6);         // CALL MAIN MENU FUN:
            break;               // MAKE A BREAK FOR switch_STATEMENT

        case char(6):
            _setcursortype(_NORMALCURSOR); // ctrl_f  FILE MENU HOT_KEY
            active_status_bar(1, 1);       // FILE A_S
            menu(list_Cap, list, size, FILE_);
            // menu(1);                      //SELETE FILE MENU
            File_Pull_Menu(); // MAKE FILE PULLDOWN MENU
            MAINMENU(6);      // CALL MAIN MENU FUN:
            break;            // MAKE A BREAK FOR switch_STATEMENT

        case char(8):
            _setcursortype(_NORMALCURSOR); // ctrl_h  HACKER MENU HOT_KEY
            active_status_bar(2, 1);       // HACKER A_S
            menu(list_Cap, list, size, PROGRAMMER);
            // menu(2);                      //SELECT HACKER MENU
            PROGRAMMER_Pull_Menu(); // MAKE HACKER PULLDOWN MENU
            MAINMENU(2);            // CALL MAIN MENU FUN:
            break;                  // MAKE A BREAK FOR switch_STATEMENT

        case char(19):
            Popup_Menu();
            break; // ctrl-s   CALL SECRET ROUTING!
        case char(27):
            Msgbox(); // to exit  (Esc) CREATE MESSAGE BOX TO COMFIRM QUITING
        //====================================
        // IF L_ARROW  :IF CURRENT SELETION IS <EXIT>FIRST   THEN SELECT   <HELP>SIZE
        //             IF NOT THEN SELECT CURRENT (SELETION-1) POSITION
        case char(75):
            index = (index == 1) ? size : index - 1;
            break; //<-- L_ARROW
        // IF R_ARROW  :IF CURRENT SELETION IS <HELP>LAST   THEN SELECT   <EXIT>FIRST
        //              IF NOT THEN SELECT CURRENT (SELETION+1) POSITION
        case char(77):
            index = (index == size) ? 1 : index + 1;
            break; //--> R_ARROW
        // IF ENTER    :DO FUN: ACCORDING TO THE CURRENT SELECTED <INDEX>FUN:
        case char(13):
            switch (index)
            { //<--|ENTER
            // IF EXIT
            case 1:
                _setcursortype(_NORMALCURSOR); // INDEX<1>CHOOSE TO EXIT
                Msgbox();                      // COMFIRM EXIT
                exit(0);                       // EXIT THE PROGRAM
                break;
            // IF FILE
            case 2:
                _setcursortype(_NORMALCURSOR);
                active_status_bar(index - 2, 2); // FILE A_S
                File_Pull_Menu();                // FILE PULL DOWN MENU CREATED
                menu(list_Cap, list, size, FILE_);
                // menu(1);                        //FILE HIGHLIGHT
                break;
            // IF HACKER
            case 8:
                _setcursortype(_NORMALCURSOR);
                active_status_bar(index - 3, 3); //
                PROGRAMMER_Pull_Menu();          // PROGRAMMER PULL DOWN
                menu(list_Cap, list, size, PROGRAMMER);
                // menu(2);
                break;
            // IF SYSTEM
            case 4:
                _setcursortype(_NORMALCURSOR);
                Dosshell();
                MAINMENU(4);
                break;
            // IF PROJECT
            case 5:
                MAINMENU(5);
                break;
            // IF SUPERVISOR
            case 6:
                _setcursortype(_NORMALCURSOR);   // PROJECT  MENU ***LEFT ***
                active_status_bar(index - 6, 6); //
                Project_Pull_Menu();
                MAINMENU(6);
                break;
            // IF HELP
            case 7:
                _setcursortype(_NORMALCURSOR); // Help  MENU ***LEFT ***
                HELP();
                MAINMENU(7);
                break;
            }
        // IF SECRECT CODE PRESS(CTRL+S)
        case char(80):
            switch (index)
            {
            case 1:
                _setcursortype(_NORMALCURSOR);
                Msgbox();
                exit(0);
                break;

            case 2:
                _setcursortype(_NORMALCURSOR);
                active_status_bar(index - 2, 2); // FILE
                File_Pull_Menu();                // FILE PULL DOWN
                menu(list_Cap, list, size, FILE_);
                // menu(1);    //FILE HIGHLIGHT
                break;
            case 3:
                _setcursortype(_NORMALCURSOR);
                active_status_bar(index - 3, 3); //
                PROGRAMMER_Pull_Menu();          // PROGRAMMER PULL DOWN
                menu(list_Cap, list, size, PROGRAMMER);
                // menu(2);
                break;
            case 4:
                _setcursortype(_NORMALCURSOR);
                Dosshell();
                active_status_bar(1, 1); //
                MAINMENU(3);

                break;
            case 5:
                MAINMENU(5);
                break;
            case 6:
                _setcursortype(_NORMALCURSOR);   // PROJECT  MENU ***LEFT ***
                active_status_bar(index - 6, 6); //
                Project_Pull_Menu();
                MAINMENU(6);
                break;

            case 7:
                _setcursortype(_NORMALCURSOR); // Help  MENU ***LEFT ***
                HELP();
                MAINMENU(7);
                break;

            } // inner switch end

        }                                // outter switch  end
        active_status_bar(index - 1, 1); //
        menu(list_Cap, list, size, index - 1);
    } while (ch != 13 || ch != 27 || ch != 6 || ch != 3 || ch != 27);
}
////////////////////////////////////////////////////////////////////////////////////
//////////////**************MAIN MENU END HERE***********************/////////////
///////////////////////////////////////////////////////////////////////////////////
//-------------------------------------------------------------------------------
///////////////////////////////////////////////////////////////////////////////////
//////////////************** MENU START HERE***********************/////////////
///////////////////////////////////////////////////////////////////////////////////

void status_bar() // defaultvalue
{
    int row = 13, i;
    for (i = 0; i < size - 2; i++)
    {
        gotoxy(row * i + 1, 24);
        textcolor(4);
        cprintf(Status_Shortcut[i]);
        textcolor(0);
        cprintf(Status[i]);
    }
    window(1, 25, 80, 25);
    textbackground(1);
    clrscr();
}
//`````````````````````````````````````````````````````````
void File_Pull_Menu()
{
    int index = 1;
    char ch;
    File_menu(0);
    do
    {
        _setcursortype(_NOCURSOR);
        ch = getch();
        if (ch == char(0))
            ch = getch();
        switch (ch)
        {
        case char(16):
            break; // ctrl-p
        case char(3):
            break; // ctrl-c
        case char(19):
            break; // ctrl-s
        case char(75):
            active_status_bar(0, 1); //<--------
            MAINMENU(1);
            break;

        case char(77): //--------->
            Fore_Ground_window();
            active_status_bar(0, 3);
            menu(list_Cap, list, size, 2);
            PROGRAMMER_Pull_Menu();
            break;

        case char(27):
            active_status_bar(1, 1); // FILE
            MAINMENU(2);             // FILE
            break;
        //====================================
        case char(72):
            index = (index == 1) ? File_Size1 : index - 1;
            break; // up
        case char(80):
            index = (index == File_Size1) ? 1 : index + 1;
            break; // down
        case char(13):
            switch (index)
            {
            case 1:
                _setcursortype(_NORMALCURSOR); // dir
                DIRR();
                active_status_bar(1, 1); //
                MAINMENU(2);

            case 2:
                _setcursortype(_NORMALCURSOR);
                BIOS1();                 // CHECK BIOS
                active_status_bar(1, 1); //
                MAINMENU(2);

            case 3:
                _setcursortype(_NORMALCURSOR);
                SAVE();
                active_status_bar(1, 1); //
                MAINMENU(2);
                break;
            case 4:
                _setcursortype(_NORMALCURSOR);
                CHANGE_DIR();
                active_status_bar(1, 1); //
                MAINMENU(2);
                break;
            case 5:
                _setcursortype(_NORMALCURSOR);
                DEL1(1);
                active_status_bar(1, 1); //
                MAINMENU(2);
                break;
            case 6:
                _setcursortype(_NORMALCURSOR);
                DEL1(2);
                active_status_bar(1, 1); //
                MAINMENU(2);
                break;
            case 7:
                _setcursortype(_NORMALCURSOR);

                active_status_bar(1, 1); //
                MAINMENU(2);
                break;
            case 8:
                _setcursortype(_NORMALCURSOR);
                Msgbox();
                exit(0);
                break;
            }
        }
        active_status_bar(index - 1, 2); //
        File_menu(index - 1);
    } while (ch != 13 || ch != 27 || ch != 6 || ch != 3 || ch != 19 || ch != 27);
}

void File_menu(int pos1) // defaultvalue
{
    int row = 1, i;
    window(9, 2, 23, 12);
    textbackground(0);
    clrscr();
    for (i = 0; i < File_Size1 + 2; i++)
    {

        textbackground(7);
        gotoxy(1, row * i + 1);
        textcolor(0);
        cprintf(file_list[i]);
    }
    for (i = 0; i < File_Size1; i++)
    {
        if (pos1 == i)
            textbackground(2);
        else
            textbackground(7);
        gotoxy(3, row * i + 2);
        textcolor(4);
        cprintf(file_list1[i]);
        textcolor(0);
        cprintf(file_list2[i]);
    }
}
//````````````````````````````````````````````````````````
// PROGRAMMER MENU
// 111111111111111111111111111111111111111111111111111111111111111
void PROGRAMMER_Pull_Menu()
{
    int index = 1;
    char ch;
    PROGRAMMER_menu(0);
    do
    {
        _setcursortype(_NOCURSOR);
        ch = getch();
        if (ch == char(0))
            ch = getch();
        switch (ch)
        {
        case char(75):
            Fore_Ground_window();
            active_status_bar(0, 2);
            menu(list_Cap, list, size, 1);
            // menu(1);
            File_Pull_Menu();
            break;

        case char(77):
            active_status_bar(3, 1); // PROGRAMMER
            MAINMENU(4);             //--------->
            break;
        case char(6):
            break; // ctrl-f
        case char(3):
            break; // ctrl-c
        case char(19):
            break; // ctrl-s
            // case char(75) :  Fore_Ground_window();
            //		       active_status_bar(0,2);
            //		       menu(1);
            //	       File_Pull_Menu();
            // case char(77) :
        case char(27):
            active_status_bar(2, 1); // PROGRAMMER
            MAINMENU(3);             // PROGRAMMER
        //====================================
        case char(72):
            index = (index == 1) ? PROGRAMMER_Size1 : index - 1;
            break;
        case char(80):
            index = (index == PROGRAMMER_Size1) ? 1 : index + 1;
            break;
        case char(13):
            switch (index)
            {
            case 1:
                _setcursortype(_NORMALCURSOR);
                HTUT();
                break;
            case 2:
                _setcursortype(_NORMALCURSOR);
                File_Pull_Menu();
                menu(list_Cap, list, size, 1);
                break;
            case 3:
                _setcursortype(_NORMALCURSOR);
                MAINMENU(3);
                break;
            case 4:
                _setcursortype(_NORMALCURSOR);
                MAINMENU(3);
                break;
            }
        }
        active_status_bar(index - 1, 3);
        PROGRAMMER_menu(index - 1);
    } while (ch != 13 || ch != 27 || ch != 6 || ch != 3 ||
             ch != 19 || ch != 27);
}

void PROGRAMMER_menu(int pos2) // defaultvalue
{

    int row = 1, i;
    window(15, 2, 36, 5);
    textbackground(0);
    clrscr();
    for (i = 0; i < PROGRAMMER_Size1 + 2; i++)
    {
        textbackground(7);
        gotoxy(1, row * i + 1);
        textcolor(0);
        cprintf(PROGRAMMER_list[i]);
    }

    for (i = 0; i < PROGRAMMER_Size1; i++)
    {
        if (pos2 == i)
            textbackground(2);
        else
            textbackground(7);
        gotoxy(3, row * i + 2);
        textcolor(0);
        cprintf(PROGRAMMER_list1[i]);
    }
}
//$$$$$$$$$$$$$$$$$$$$$$$$
void active_status_bar(int i, int j) // defaultvalue  i==
{

    // int row=13;

    struct dostime_t t;
    _dos_gettime(&t);

    struct dosdate_t d;
    _dos_getdate(&d);

    window(1, 2, 80, 23);
    textbackground(1);
    clrscr();

    window(1, 24, 80, 25);
    textbackground(7);
    clrscr();

    switch (j)
    {
    case 1:
        gotoxy(1, 1);
        textcolor(4);

        cprintf(Status[i]);

        gotoxy(14, 1);
        textcolor(0);
        cprintf(Status_Expressoin[i]);
        break;
    case 2:
        gotoxy(1, 1);
        textcolor(4);

        cprintf(file_list1[i]);
        cprintf(file_list2[i]);

        gotoxy(14, 1);
        textcolor(0);
        cprintf(File_Status_Expressoin[i]);
        break;
    case 3:
        gotoxy(1, 1);
        textcolor(4);

        cprintf(PROGRAMMER_list1[i]);

        gotoxy(17, 1);
        textcolor(0);
        cprintf(PROGRAMMER_Status_Expressoin[i]);
        break;

    case 4:
        gotoxy(1, 1);
        textcolor(4);

        cprintf("");

        gotoxy(17, 1);
        textcolor(0);
        cprintf(PROGRAMMER_Status_Expressoin[i]);
        break;

    case 5:
        gotoxy(1, 1);
        textcolor(4);

        cprintf(project_list1[i]);
        cprintf(project_list2[i]);
        gotoxy(17, 1);
        textcolor(0);
        cprintf(Project_Status_Expressoin[i]);
        break;

    case 6:
        gotoxy(1, 1);
        textcolor(4);

        cprintf(project_list1[i]);
        cprintf(project_list2[i]);
        gotoxy(17, 1);
        textcolor(0);
        cprintf(Project_Status_Expressoin[i]);
        break;

    case 7:
        gotoxy(1, 1);
        textcolor(4);

        cprintf(project_list1[i]);
        cprintf(project_list2[i]);
        gotoxy(17, 1);
        textcolor(0);
        cprintf(Project_Status_Expressoin[i]);
        break;
    }

    textcolor(6);
    gotoxy(57, 1);
    cprintf("%d - %d - %d ", d.month, d.day, d.year);
    cprintf(" %2d : %02d", t.hour, t.minute);
    window(1, 25, 80, 25);
    textbackground(1);
    clrscr();
}

void Fore_Ground_window()
{
    window(1, 2, 80, 24);
    textbackground(1);
    clrscr();
}

//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
// POPUP MENU
Popup_Menu()
{
    int index = 1;
    char ch;

    active_status_bar(0, 5);
    Popup_menu(0);
    do
    {
        _setcursortype(_NOCURSOR);
        ch = getch();
        if (ch == char(0))
            ch = getch();
        switch (ch)
        {
        case char(6):  // ctrl-f
        case char(3):  // ctrl-c
        case char(19): // ctrl-s
        case char(75):
            active_status_bar(0, 1);
            MAINMENU(1);

        case char(77):
            Fore_Ground_window();
            active_status_bar(0, 3);
            menu(list_Cap, list, size, 2);
            // menu(2);
            PROGRAMMER_Pull_Menu();

        case char(27):
            MAINMENU(1);
        //====================================
        case char(72):
            index = (index == 1) ? File_Size1 : index - 1;
            break;
        case char(80):
            index = (index == Popup_Size1) ? 1 : index + 1;
            break;
        case char(13):
            switch (index)
            {
            case 1:
                _setcursortype(_NORMALCURSOR);
                K_EN();
                break;

            case 2:
                _setcursortype(_NORMALCURSOR);
                K_DN();
                break;

            case 3:
                _setcursortype(_NORMALCURSOR);
                Msgbox();
                return 0;
            }
        }

        active_status_bar(index - 1, 5); //
        Popup_menu(index - 1);

    } while (ch != 13 || ch != 27 || ch != 6 || ch != 3 || ch != 19 || ch != 27);
    return 0;
}

void Popup_menu(int pos1) // defaultvalue
{

    int row = 1, i;
    window(15, 12, 36, 17);
    textbackground(0);
    clrscr();

    for (i = 0; i < Popup_Size1 + 2; i++)
    {

        textbackground(7);
        gotoxy(1, row * i + 1);
        textcolor(0);
        cprintf(Popup_list[i]);
    }

    for (i = 0; i < Popup_Size1; i++)
    {

        if (pos1 == i)
            textbackground(2);
        else
            textbackground(7);

        gotoxy(3, row * i + 2);
        textcolor(4);
        cprintf(popup_list1[i]);

        textcolor(0);
        cprintf(popup_list2[i]);
    }
}

//###############
// Project Menu

Project_Pull_Menu()
{
    int index = 1;
    char ch;

    Project_menu(0);
    do
    {
        _setcursortype(_NOCURSOR);
        ch = getch();
        if (ch == char(0))
            ch = getch();
        switch (ch)
        {
        case char(6):  // ctrl-f
        case char(3):  // ctrl-c
        case char(19): // ctrl-s
        case char(75):
            Fore_Ground_window();
            active_status_bar(6, 1);
            MAINMENU(5);
            break;
        case char(27):
            Fore_Ground_window();
            active_status_bar(6, 1);
            MAINMENU(6);
            break;

        case char(77):
            active_status_bar(6, 1); // PROGRAMMER
            MAINMENU(7);             //--------->
            break;

        //====================================
        case char(72):
            index = (index == 1) ? Project_Size1 : index - 1;
            break;
        case char(80):
            index = (index == Project_Size1) ? 1 : index + 1;
            break;
        case char(13):

            switch (index)
            {
            case 1:
                _setcursortype(_NORMALCURSOR);
                EN_1();
                // K_EN();
                // system("c:\\caeser_e.exe");
                // MSGENCIPHER();
                break;

            case 2:
                _setcursortype(_NORMALCURSOR);
                DN_1();
                // K_DN();
                // system("c:\\caeser_d.exe");
                // MSGDECIPHER();
                break;

            case 3:
                _setcursortype(_NORMALCURSOR);
                Msgbox();
                return 0;
            }
        }

        active_status_bar(index - 1, 6); //
        Project_menu(index - 1);

    } while (ch != 13 || ch != 27 || ch != 6 || ch != 3 || ch != 19 || ch != 27);
    return 0;
}

void Project_menu(int pos1)
{

    int row = 1, i;
    window(56, 2, 75, 7);
    textbackground(0);
    clrscr();

    for (i = 0; i < Project_Size1 + 2; i++)
    {

        textbackground(7);
        gotoxy(1, row * i + 1);
        textcolor(0);
        cprintf(project_list[i]);
    }

    for (i = 0; i < Project_Size1; i++)
    {
        if (pos1 == i)
            textbackground(2);
        else
            textbackground(7);

        gotoxy(3, row * i + 2);
        textcolor(4);
        cprintf(project_list1[i]);

        textcolor(0);
        cprintf(project_list2[i]);
    }
}

//################
void Splash()
{
    Window(1, 2, 80, 22, 3); // SPLESH_FORM_WINDOW
    textbackground(1);
    for (int ii = 0; ii <= 10; ii++)
        for (int i = 0; i <= 188; i++)
            cprintf("°");
    gotoxy(80, 25);
    cprintf("°");
}
