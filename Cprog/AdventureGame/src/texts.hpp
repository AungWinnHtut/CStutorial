#ifndef _TEXTS_HPP
#define _TEXTS_HPP

/// Stores most of the texts in the game

// Utility
/** Used to clear the screen */
const char S_UTIL_CLS[] = "\033[2J\033[1;1H";

// ANSI
/** Reset */
const char S_ANSI_RESET[] = "\033[0m";
/** Underline */
const char S_ANSI_UNDERLINE[] = "\033[4m";
/** Blink */
const char S_ANSI_BLINK[] = "\033[5m";

// System messages(?)
/** Arrow key navigation info */
const char S_SYS_HELP_ARROWKEYS[] = "\033[33mTip:\n \033[93mUse your arrow keys to navigate\033[0m";
/** Refresh resolution info */
const char S_SYS_HELP_RESOLUTION[] = "\033[33mTip:\n \033[93mIf you've resized the terminal\n press any key to refresh the screen\033[0m";
/** Main menu screen, new game */
const char S_SYS_MAINMENU_NEWGAME[] = "New Game";
/** Main menu screen, continue game */
const char S_SYS_MAINMENU_CONTINUE[] = "Continue Game";
/** Main menu screen, quit */
const char S_SYS_MAINMENU_QUIT[] = "Quit";
/** Main menu, asks for your name when creating a new game */
const char S_SYS_MAINMENU_NAMEQUESTION[] = "Name your character";
/** Menu, self explanatory probably */
const char S_SYS_MENU_PRESSENTER[] = "         Press \033[33mENTER\033[0m to continue";

#endif