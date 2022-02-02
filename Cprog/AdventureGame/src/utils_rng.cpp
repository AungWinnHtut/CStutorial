#include "./utils.hpp"

// Random number generation
RandomGenerator::RandomGenerator(int startingSeed)
{
  this->mStartSeed = startingSeed;
  this->mCurrentSeed = startingSeed;
}

// Just simple maths
int RandomGenerator::Update(bool positiveOnly)
{
  this->mCurrentSeed = 16807 * this->mCurrentSeed % 2147483647;
  return positiveOnly && mCurrentSeed < 0 ? -this->mCurrentSeed : this->mCurrentSeed;
}

int RandomGenerator::GetStartSeed() { return this->mStartSeed; }
int RandomGenerator::GetCurrentSeed() { return this->mCurrentSeed; }
int RandomGenerator::GetUpdateCount() { return this->mUpdateCount; }