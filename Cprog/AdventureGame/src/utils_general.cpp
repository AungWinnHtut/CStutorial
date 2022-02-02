#include "./utils.hpp"

char *itos(int integer)
{
  // If it's 0, return with 0
  if (integer == 0)
    return new char[1]{'0'};

  // Starting variables
  char str[10] = {'\0'};
  bool negative = false;

  // Make the number negative later
  if (integer < 0)
  {
    negative = true;
    integer = -integer;
  }

  // Add 48 (ASCII of 0) + the integer modded by 10 and then divide the integer
  // by 10, repeat until it reaches 0, will not run if the integer is already 0
  for (int i = 0; integer != 0; ++i)
  {
    str[i] = (48 + (integer % 10));
    integer = integer / 10;
  }

  // Add negative to the returning string if the integer is negative
  char *pReturnVal = new char[12]{'\0'};
  int j = 0;
  if (negative)
    pReturnVal[j++];

  // Reverse the string first before returning
  for (int i = 9; i != -1; --i)
  {
    if (str[i] != '\0')
      pReturnVal[j++] = str[i];
  }

  return pReturnVal;
}
