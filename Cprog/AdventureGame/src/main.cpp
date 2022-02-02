#include "./game.hpp"
#include "./texts.hpp"
#include "./utils.hpp"

void PrintMap(Terrain map[MAP_SIZE][MAP_SIZE])
{
  // Print out the map
  for (int y = 0; y < MAP_SIZE; y++)
  {
    for (int x = 0; x < MAP_SIZE; x++)
    {
      PrintText("\033[");
      switch (map[x][y].type)
      {
      case TerrainType::Ocean:
        PrintText("104");
        break;
      case TerrainType::Plains:
        PrintText("46");
        break;
      case TerrainType::Forest:
        PrintText("42");
        break;
      case TerrainType::Desert:
        PrintText("103");
        break;
      case TerrainType::Snow:
        PrintText("106");
        break;
      case TerrainType::Mountains:
        PrintText("100");
        break;
      case TerrainType::Special:
        PrintText("41");
        break;
      }
      PrintText("m  ");
    }
    PrintText("\n");
  }
}

int main(int argc, char *argv[], char *envp[])
{
  // Clear the screen and hide cursor
  PrintText(S_UTIL_CLS);
  PrintText("\033[?25l");
  Game *game;

  // Main menu
  switch (MainMenu::Show(false))
  {
  case MenuOption::Continue:
    break;
  case MenuOption::NewGame:
    game = MainMenu::NewGame();
    if (argc > 1)
    {
      PrintMap(game->pMap);
      return 0;
    }
    game->Start();
    break;
  case MenuOption::Quit:
    PrintText(S_UTIL_CLS);
    PrintText("\033[?25h");
    return 0;
    break;
  default:
    break;
  };
  return 0;
}