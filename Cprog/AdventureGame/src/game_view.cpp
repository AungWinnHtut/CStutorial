#include "game.hpp"


void PrintMapFrame(){

};
void Game::UpdateFrame()
{
  switch (this->state)
  {
  case GameState::Map:
    PrintMapFrame();
    break;

  default:
    break;
  }
}