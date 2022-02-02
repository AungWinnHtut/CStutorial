#include "./game.hpp"

#define OCEAN_SWEEP_DEPTH 1

#define LAND_POINT_DISTANCE 2
#define CORNER_LAND_LENGTH (((MAP_SIZE / 2) - 2) - LAND_POINT_DISTANCE)

#define CENTER_PULL_DEPTH 2
#define CENTER_LAND_LENGTH (((MAP_SIZE / 2) - 2))

void GenerateOceanCorners(Terrain *points, RandomGenerator *pRNG)
{
  // Place 4 points on one corner
  for (int i = 0; i < 4; ++i)
  {
    points[i].type = TerrainType::Ocean;
    int oceanPoint = (pRNG->Update(true) % ((OCEAN_SWEEP_DEPTH * 2) + 1));
    if (oceanPoint <= OCEAN_SWEEP_DEPTH)
    {
      points[i].x = oceanPoint;
      points[i].y = 0;
    }
    else
    {
      points[i].x = 0;
      points[i].y = (oceanPoint - OCEAN_SWEEP_DEPTH);
    }
  }

  // Mirror all the placed points to their corners

  // Top right
  points[1].x = (MAP_SIZE - 1 - points[1].x);

  // Bottom left
  points[2].y = (MAP_SIZE - 1 - points[2].y);

  // Bottom right
  points[3].x = (MAP_SIZE - 1 - points[3].x);
  points[3].y = (MAP_SIZE - 1 - points[3].y);
}

void GenerateLandCorners(Terrain *points, RandomGenerator *pRNG,
                         bool *placedBiomes)
{
  // Place 4 points on one corner
  for (int i = 4; i < 8; ++i)
  {
    // Retry if duplicate terrain type
    while (true)
    {
      points[i].type = (TerrainType)((pRNG->Update(true) % 5) + 1);
      if (!placedBiomes[(int)points[i].type])
        break;
    }
    placedBiomes[(int)points[i].type] = true;
    while (true)
    {
      points[i].x = (pRNG->Update(true) % CORNER_LAND_LENGTH);
      points[i].y = (pRNG->Update(true) % CORNER_LAND_LENGTH);
      if (points[i].x <= CENTER_LAND_LENGTH && points[i].y <= CENTER_LAND_LENGTH)
        break;
    }

    // Push them in
    points[i].x += LAND_POINT_DISTANCE;
    points[i].y += LAND_POINT_DISTANCE;
  }

  // Mirror all the placed points to their corners

  // Top right
  points[5].x = (MAP_SIZE - 1 - points[5].x);

  // Bottom left
  points[6].y = (MAP_SIZE - 1 - points[6].y);

  // Bott1om right
  points[7].x = (MAP_SIZE - 1 - points[7].x);
  points[7].y = (MAP_SIZE - 1 - points[7].y);
}

void GenerateMap(Terrain map[MAP_SIZE][MAP_SIZE], RandomGenerator *pRNG)
{
  Terrain points[9];
  bool placedBiomes[6] = {false};
  GenerateOceanCorners(points, pRNG);
  placedBiomes[0] = true;
  GenerateLandCorners(points, pRNG, placedBiomes);

  // Generate center
  for (int i = 1; i < 6; ++i)
  {
    if (!placedBiomes[i])
    {
      points[8].type = (TerrainType)i;
      break;
    }
  }
  points[8].x = (pRNG->Update(true) % (CENTER_LAND_LENGTH - CENTER_PULL_DEPTH));
  points[8].y = (pRNG->Update(true) % (CENTER_LAND_LENGTH - CENTER_PULL_DEPTH));

  // Center it
  int plusBy = (MAP_SIZE / 2) - (CENTER_LAND_LENGTH / 2);
  points[8].x += plusBy;
  points[8].y += plusBy;

  for (int y = 0; y < MAP_SIZE; ++y)
  {
    for (int x = 0; x < MAP_SIZE; ++x)
    {
      TerrainType nearest;
      int dist = __INT_MAX__;

      // Walk over each point
      for (int i = 0; i < 9; i++)
      {
        // Calculate the difference in x and y direction
        int xdiff = points[i].x - x;
        int ydiff = points[i].y - y;

        // Calculate euclidean distance, sqrt is not needed
        // because we only compare and do not need the real value
        int cdist = xdiff * xdiff + ydiff * ydiff;

        // Take the biome if the distance is smaller than the old distance
        if (cdist < dist)
        {
          nearest = points[i].type;
          dist = cdist;
        }
      }

      // Set the field to the nearest type
      map[x][y] = Terrain(nearest, x, y);
    }
  }

  // Set the borders to ocean
  for (int x = 0; x < MAP_SIZE; ++x)
  {
    map[x][0].type = TerrainType::Ocean;
    map[x][MAP_SIZE - 1].type = TerrainType::Ocean;
  }
  for (int y = 0; y < MAP_SIZE; ++y)
  {
    map[0][y].type = TerrainType::Ocean;
    map[MAP_SIZE - 1][y].type = TerrainType::Ocean;
  }

  // Mark points
  //for (int i = 0; i < 9; ++i)
  //  map[points[i].x][points[i].y].type = TerrainType::Special;
}

Terrain::Terrain() {}
Terrain::Terrain(TerrainType type, int x, int y)
{
  this->type = type;
  this->x = x;
  this->y = y;
}