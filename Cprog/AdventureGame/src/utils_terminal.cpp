#include "utils.hpp"

#include <stdio.h>
#include <sys/ioctl.h>

// _getch() doesn't exist on UNIX systems
#ifdef _WIN32
#include <conio.h>
#else
#include <termios.h>
#include <unistd.h>
int _getch(void)
{
  struct termios oldattr, newattr;
  int ch;
  tcgetattr(STDIN_FILENO, &oldattr);
  newattr = oldattr;
  newattr.c_lflag &= ~(ICANON | ECHO);
  tcsetattr(STDIN_FILENO, TCSANOW, &newattr);
  ch = getchar();
  tcsetattr(STDIN_FILENO, TCSANOW, &oldattr);
  return ch;
}
#endif

// Size of the terminal
winsize GetWindowSize()
{
  struct winsize size;
  ioctl(0, TIOCGWINSZ, &size);
  return size;
}

// Replacement for printf()
void PrintText(char *text)
{
  for (int i = 0; text[i]; ++i)
    putchar(text[i]);
}
void PrintText(const char *text)
{
  PrintText((char *)text);
}