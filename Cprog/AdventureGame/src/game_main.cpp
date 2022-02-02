#include "./game.hpp"

Game::Game(char *name)
{
  // Random Number Generator
  int seed = 0;
  for (int i = 0; name[i]; ++i)
    seed += name[i];
  pRng = new RandomGenerator(seed ? seed : (long)new int[1]);

  // Map
  pMap = new Terrain[MAP_SIZE][MAP_SIZE];
  GenerateMap(pMap, pRng);

  // Player starting location
  bool foundLocation = false;
  for (int y = 1; !foundLocation && y < MAP_SIZE; ++y)
    for (int x = 1; !foundLocation && x < MAP_SIZE; ++x)
      if (pMap[x][y].type != TerrainType::Ocean)
      {
        foundLocation = true;
        this->player.x = x;
        this->player.y = y;
      }
}

Game *Game::Start()
{
  UpdateFrame();
  return this;
}