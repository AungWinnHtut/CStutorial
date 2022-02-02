#include "./texts.hpp"
#include "./utils.hpp"

#include <stdio.h>

// Helper function to print the text itself
void printMenuOption(const char *text, bool enabled)
{
  if (!enabled)
  {
    PrintText("\033[90m");
    PrintText(text);
    PrintText(S_ANSI_RESET);
  }
  else
    PrintText(text);
}

// Center text, show selected and other stuff, for menus
void showMenuOption(char *text, winsize windowSize, bool selected,
                    bool enabled)
{
  // Length of the text
  int strLength = 0;
  while (text[strLength] != '\0')
    ++strLength;

  // Center the text
  PrintText("\033[");
  auto moveBy =
      itos((windowSize.ws_col / 2) - (strLength / 2) - (selected ? 2 : 0));
  PrintText(moveBy); // Column
  delete moveBy;
  PrintText("C");

  // Print it out, show selection if selected
  if (selected)
  {
    PrintText(S_ANSI_BLINK);
    PrintText("> ");
    PrintText(S_ANSI_RESET);
    printMenuOption(text, enabled);
    PrintText(S_ANSI_BLINK);
    PrintText(" <");
    PrintText(S_ANSI_RESET);
  }
  else
    printMenuOption(text, enabled);
  PrintText("\n");
}
void showMenuOption(const char *text, winsize windowSize, bool selected, bool enabled)
{
  showMenuOption((char *)text, windowSize, selected, enabled);
}

// Prints out a blank, centered
void printBlanked(char *text, int maxLength)
{
  // Get cursor to position
  winsize windowSize = GetWindowSize();
  PrintText("\033[");
  auto moveBy = itos((windowSize.ws_col / 2) - (maxLength / 2));
  PrintText(moveBy); // Column
  PrintText("C");

  // Get length of the text
  int textLength = 0;
  for (; text[textLength]; ++textLength)
    ;

  // Print the text and return if it's already the max length
  if (textLength == maxLength)
  {
    PrintText(S_ANSI_UNDERLINE);
    PrintText(text);
    PrintText(S_ANSI_RESET);
    PrintText("\n");
    return;
  }

  // Create the blanked string
  char *blankedStr = new char[maxLength + 1];
  for (int i = 0; i < maxLength; ++i)
    blankedStr[i] = ' ';
  blankedStr[maxLength] = '\0';

  // Put the text into the blanked string
  int startLength = ((maxLength / 2) - (textLength / 2));
  for (int i = 0; i < textLength; ++i)
    blankedStr[i + startLength] = text[i];

  // Print blanked string
  PrintText(S_ANSI_UNDERLINE);
  PrintText(blankedStr);
  PrintText(S_ANSI_RESET);
  PrintText("\n");

  delete blankedStr;
}