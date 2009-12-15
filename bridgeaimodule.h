#pragma once
#define BRIDGE_DEBUG
#include <BWAPI.h>
#include <BWTA.h>
#include <string>
#include <windows.h>
#include "FileLogger.h"
#include "monobridge.h"
#include <mono/jit/jit.h>
#include <mono/metadata/object.h>
#include <mono/metadata/environment.h>
#include <mono/metadata/assembly.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/mono-config.h>


class BridgeAIModule : public BWAPI::AIModule
{
	static HINSTANCE _libInst;
	static MonoDomain *domain;
	static MonoObject *botobject;
	static MonoMethod *initMethod;
	static MonoMethod *startMethod;
	static MonoMethod *endMethod;
	static MonoMethod *frameMethod;
	static MonoMethod *sendTextMethod;
	static MonoMethod *unitCreateMethod;
	static MonoMethod *unitDestroyMethod;
    static MonoMethod *unitMorphMethod;
	static MonoMethod *unitShowMethod;
	static MonoMethod *unitHideMethod;

private:
	static void initmono(std::wstring dlldir);
	static void setfunctionhooks();
public:
	static BWAPI::Unit *lastunitparam;
	static void init(std::wstring dllDirectory);
	static void destroy();
	BridgeAIModule();
	~BridgeAIModule();
	void onStart();
	void onEnd();
	void onFrame();
	bool onSendText(std::string text);
	void onUnitCreate(BWAPI::Unit* unit);
	void onUnitDestroy(BWAPI::Unit* unit);
	void onUnitMorph(BWAPI::Unit* unit);
	void onUnitShow(BWAPI::Unit* unit);
	void onUnitHide(BWAPI::Unit* unit);
};
