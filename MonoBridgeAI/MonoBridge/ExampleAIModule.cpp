#include "ExampleAIModule.h"
using namespace BWAPI;

bool analyzed;
bool analysis_just_finished;
BWTA::Region* home;
BWTA::Region* enemy_base;

void ExampleAIModule::onStart()
{
	Broodwar->sendText("Loaded MonoBridge!");
	Mono::Manager::GetInstance()->onStart();
}

void ExampleAIModule::onEnd(bool isWinner)
{
	Mono::Manager::GetInstance()->onEnd(isWinner);
}

void ExampleAIModule::onFrame()
{
	Mono::Manager::GetInstance()->onFrame();
}

void ExampleAIModule::onSendText(std::string text)
{
	Mono::Manager::GetInstance()->onSendText(text);
}

void ExampleAIModule::onReceiveText(BWAPI::Player* player, std::string text)
{
	Mono::Manager::GetInstance()->onReceiveText(player,text);
}

void ExampleAIModule::onPlayerLeft(BWAPI::Player* player)
{
	Mono::Manager::GetInstance()->onPlayerLeft(player);
}

void ExampleAIModule::onNukeDetect(BWAPI::Position target)
{
	Mono::Manager::GetInstance()->onNukeDetect(&target);
}

void ExampleAIModule::onUnitDiscover(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitDiscover(unit);
}

void ExampleAIModule::onUnitEvade(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitEvade(unit);
}

void ExampleAIModule::onUnitShow(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitShow(unit);
}

void ExampleAIModule::onUnitHide(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitHide(unit);
}

void ExampleAIModule::onUnitCreate(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitCreate(unit);
}

void ExampleAIModule::onUnitDestroy(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitDestroy(unit);
}

void ExampleAIModule::onUnitMorph(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitMorph(unit);
}

void ExampleAIModule::onUnitRenegade(BWAPI::Unit* unit)
{
	Mono::Manager::GetInstance()->onUnitRenegade(unit);
}

void ExampleAIModule::onSaveGame(std::string gameName)
{
	Mono::Manager::GetInstance()->onSaveGame(gameName);
}