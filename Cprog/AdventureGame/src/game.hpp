#ifndef _GAME_HPP
#define _GAME_HPP

#include "./utils.hpp"

#define MAP_SIZE 20
enum class MenuOption
{
  Continue,
  NewGame,
  Quit,
  MenuOption_MAX
};
enum class TerrainType
{
  Ocean,
  Plains,
  Forest,
  Snow,
  Desert,
  Mountains,
  Special
};
enum class GameState
{
  Map,
  Event,
  Battle,
  Town
};

class Terrain
{
public:
  Terrain();
  Terrain(TerrainType type, int x, int y);
  TerrainType type;
  bool hasDiscovered = false;
  bool hasVisited = false;
  int x;
  int y;
};

void GenerateMap(Terrain map[MAP_SIZE][MAP_SIZE], RandomGenerator *pRNG);

class Player
{
public:
  int x;
  int y;
  int health = 100;
};

class Game
{
public:
  Game(char *name);
  Game *Start();

  // External Functions(?)
  Player getPlayer();
  GameState getState();

  // The map
  Terrain (*pMap)[MAP_SIZE];

private:
  Player player;

  GameState state = GameState::Map; // The game should start at the map screen
  RandomGenerator *pRng;

  void UpdateFrame();
};

class MainMenu
{
public:
  static MenuOption Show(bool forceShowContinue = true);
  static Game *NewGame();
};

#endif