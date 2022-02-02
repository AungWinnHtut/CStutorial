#ifndef _UTILS_HPP
#define _UTILS_HPP

#include <sys/ioctl.h>

// General
char *itos(int integer);

// Terminal
#ifndef _WIN32
int _getch();
#endif
winsize GetWindowSize();
void PrintText(char *text);
void PrintText(const char *text);

// RNG
class RandomGenerator
{
public:
  RandomGenerator(int startingSeed);

  /** Updates the current seed depending on itself and returns it */
  int Update(bool positiveOnly = false);

  int GetStartSeed();
  int GetCurrentSeed();
  int GetUpdateCount();

private:
  int mStartSeed;
  int mCurrentSeed;
  int mUpdateCount;
};

// Menu
void printMenuOption(const char *text, bool enabled = true);
void showMenuOption(char *text, winsize windowSize, bool selected,
                    bool enabled = true);
void showMenuOption(const char *text, winsize windowSize, bool selected,
                    bool enabled = true);
void printBlanked(char *text, int maxLength);

#endif