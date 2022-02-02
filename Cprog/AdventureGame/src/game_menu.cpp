#include "./game.hpp"
#include "./texts.hpp"
#include "./utils.hpp"

MenuOption MainMenu::Show(bool forceShowContinue)
{
  // Decides whether to show the "Continue" option & stores current selected
  // option
  bool continuable = forceShowContinue || false;
  MenuOption selectedOption =
      continuable ? MenuOption::Continue : MenuOption::NewGame;

  // Amount of options (for centering vertically)
  int optionsAmount = 2;
  if (continuable)
    ++optionsAmount;

  while (true)
  {
    // Clear the screen to update display
    PrintText(S_UTIL_CLS);
    PrintText(S_SYS_HELP_ARROWKEYS);

    // Window size
    winsize windowSize = GetWindowSize();

    // Center vertically
    PrintText("\033[");
    auto moveBy = itos((windowSize.ws_row / 2) - (optionsAmount / 2) - 1);
    PrintText(moveBy); // Line
    delete moveBy;
    PrintText(";");
    PrintText("0"); // Line
    PrintText("f");

    // Print out the options
    showMenuOption(S_SYS_MAINMENU_CONTINUE, windowSize,
                   selectedOption == MenuOption::Continue, continuable);
    showMenuOption(S_SYS_MAINMENU_NEWGAME, windowSize,
                   selectedOption == MenuOption::NewGame);
    showMenuOption(S_SYS_MAINMENU_QUIT, windowSize,
                   selectedOption == MenuOption::Quit);

    // Get arrow key presses, return current option if ENTER
    switch (_getch())
    {
    // Arrow key inputs are "ESC [" followed by "A" or "B"
    case '\033':
      if (_getch() == '[')
        switch (_getch())
        {
        // Up
        case 'A':
          if (((int)selectedOption - 1) != -1)
            selectedOption = (MenuOption)((int)selectedOption - 1);
          break;
        // Down
        case 'B':
          if (((int)selectedOption + 1) != (int)MenuOption::MenuOption_MAX)
            selectedOption = (MenuOption)((int)selectedOption + 1);
          break;
        }
      break;
    // ENTER
    case '\n':
      if (selectedOption != MenuOption::Continue || continuable)
        return selectedOption;
      break;
    }
  }
}

#define MAX_NAME_LENGTH 30
Game *MainMenu::NewGame()
{
  // Store name here
  char nameLength = 0;
  char name[MAX_NAME_LENGTH + 1] = {'\0'};
  int newChar;

  while (true)
  {
    // Clear the screen to update display
    PrintText(S_UTIL_CLS);
    PrintText(S_SYS_HELP_RESOLUTION);
    winsize windowSize = GetWindowSize();

    // Center vertically
    PrintText("\033[");
    auto moveBy = itos((windowSize.ws_row / 2) - (3 / 2) - 1);
    PrintText(moveBy); // Line
    delete moveBy;
    PrintText(";");
    PrintText("0"); // Line
    PrintText("f");

    // Show information and current text
    showMenuOption(S_SYS_MAINMENU_NAMEQUESTION, windowSize, false);
    PrintText("\n");
    printBlanked(name, MAX_NAME_LENGTH);
    PrintText("\n");
    showMenuOption(S_SYS_MENU_PRESSENTER, windowSize, false);

    // Get a new character
    newChar = _getch();

    // TODO: Show cursor area and cursor position changes, cursor should have a
    // white background

    // Make sure the character is text and is not over the max name length
    if (newChar >= 32 && newChar <= 126 && nameLength != MAX_NAME_LENGTH)
    {
      if (!(newChar == ' ' && name[nameLength - 1] == ' '))
        name[nameLength++] = newChar;
    }
    else
      switch (newChar)
      {
      // Backspace(??)
      case 127:
        if (nameLength != 0)
          name[--nameLength] = '\0';
        break;
      // ENTER
      case '\n':
        PrintText(S_UTIL_CLS);
        return new Game(name);
        break;
      // Should be arrow keys
      case '\033':
        _getch();
        _getch();
        break;
        // NOTE: Pressing Delete types "~"
      }
  }
}
