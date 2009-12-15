#include "BridgeAIModule.h"

//It is easier for mono to get the parameter from us then for us to give it to mono, so we store it here.
BWAPI::Unit *BridgeAIModule::lastunitparam;

//and this helps mono get it. Swig will generate the interface for us.
BWAPI::Unit * monobridgeutil::getLastUnitParam()
{
	//return last unit parameter to an AI function
	return BridgeAIModule::lastunitparam;
}

//borrowed :) from JNI Java proxy bot (thanks cretz)
std::string wstr_to_str(std::wstring str)
{
	size_t returned;
	char* ascii = new char[str.length() + 1];
	wcstombs_s(&returned, ascii, str.length() + 1, str.c_str(), _TRUNCATE);
	return ascii;
}

std::wstring str_to_wstr(std::string str)
{
	size_t returned;
	wchar_t* ret = new wchar_t[str.length() + 1];
	mbstowcs_s(&returned, ret, str.length() + 1, str.c_str(), _TRUNCATE);
	return ret;
}

Util::FileLogger *fl; //our logfile

//Runs a method with no parameters on an object
void runmethod_noparams(MonoMethod *method,MonoObject *obj) {
	mono_runtime_invoke (method, obj, NULL, NULL);
}

//finds a method matching a signature in class
MonoMethod *MethodFromKlass(const char *Signature,MonoClass *klass) 
{
	MonoMethodDesc* mdesc;
	MonoMethod *method;
	//find our method
	mdesc = mono_method_desc_new (Signature, FALSE);
	method = NULL;
	method = mono_method_desc_search_in_class (mdesc, klass);
	mono_method_desc_free (mdesc); //needs to be free
	if (!method) {
		fl->logDetailed((std::string(Signature) + " not found").c_str());
		return NULL;
	} else {
		fl->logDetailed((std::string(Signature) + " found").c_str());
		return method;
	}
}

//Setup Calls into the Runtime
void BridgeAIModule::setfunctionhooks() 
{
	fl->logDetailed("hooking BotBase functions");
	
	MonoClass *klass;
	MonoDomain *domain;

	//using our object, get the other values we need
	klass = mono_object_get_class (BridgeAIModule::botobject);
	domain = mono_object_get_domain (BridgeAIModule::botobject);
	
	BridgeAIModule::startMethod = MethodFromKlass(":onStart()",klass);
	BridgeAIModule::endMethod = MethodFromKlass(":onEnd()",klass);
	BridgeAIModule::frameMethod = MethodFromKlass(":onFrame()",klass);
	BridgeAIModule::sendTextMethod = MethodFromKlass(":onSendText(string)",klass);
	BridgeAIModule::unitCreateMethod = MethodFromKlass(":onUnitCreate()",klass);
	BridgeAIModule::unitDestroyMethod = MethodFromKlass(":onUnitDestroy()",klass);
	BridgeAIModule::unitMorphMethod = MethodFromKlass(":onUnitMorph()",klass);
	BridgeAIModule::unitShowMethod = MethodFromKlass(":onUnitShow()",klass);
	BridgeAIModule::unitHideMethod = MethodFromKlass(":onUnitHide()",klass);
}


MonoDomain *BridgeAIModule::domain;
MonoObject *BridgeAIModule::botobject;
MonoMethod *BridgeAIModule::initMethod;
MonoMethod *BridgeAIModule::startMethod;
MonoMethod *BridgeAIModule::endMethod;
MonoMethod *BridgeAIModule::frameMethod;
MonoMethod *BridgeAIModule::sendTextMethod;
MonoMethod *BridgeAIModule::unitCreateMethod;
MonoMethod *BridgeAIModule::unitDestroyMethod;
MonoMethod *BridgeAIModule::unitMorphMethod;
MonoMethod *BridgeAIModule::unitShowMethod;
MonoMethod *BridgeAIModule::unitHideMethod;

void BridgeAIModule::initmono(std::wstring dlldir)
{
  MonoDomain * domain;
  MonoAssembly * botassembly;
  MonoImage * botimage;
  MonoClass *klass;
  
  //help windows find our dlls
  SetDllDirectory(dlldir.c_str());
  SetDllDirectory((dlldir + str_to_wstr("mono\\")).c_str());
  fl->logDetailed(wstr_to_str((dlldir + str_to_wstr("mono\\"))).c_str());
  mono_config_parse (NULL);
  fl->logDetailed("Mono Config Parsed");
  mono_set_dirs(wstr_to_str(dlldir + str_to_wstr("mono\\lib")).c_str(), wstr_to_str(dlldir+str_to_wstr("mono\\etc")).c_str()); 
  fl->logDetailed("Lib Directory Set");
  std::string file = wstr_to_str((dlldir+str_to_wstr("bot\\monobridgeai.dll")));
  domain = mono_jit_init_version(file.c_str(),"v2.0.50727");
  BridgeAIModule::domain = domain; //store for cleanup
  fl->logDetailed("Mono Jit Init Complete");

  //load our assembly
  botassembly = mono_domain_assembly_open (domain,file.c_str());
  if (!botassembly) {
	 fl->logDetailed("Assembly load fail");
  }
  fl->logDetailed("Bridge Assembly loaded");
  botimage = mono_assembly_get_image(botassembly);
  klass = NULL;
  klass = mono_class_from_name (botimage, "MonoBridgeAI", "StarcraftBotProxy");
  if (!klass) {
	  fl->logDetailed("StarcraftBotProxy class Not Found in MonoBridgeAI");
  }
  
  //create the Bot Loader
  //allocate space and save it for later
  fl->logDetailed("Creating Bot Object - Memory Alloc");
  BridgeAIModule::botobject = mono_object_new (domain, klass);
  //default constructor;
  fl->logDetailed("Creating Bot Object - Constructor");
  mono_runtime_object_init (BridgeAIModule::botobject);
  setfunctionhooks();
  fl->logDetailed("Mono Init Complete");   
}

void BridgeAIModule::init(std::wstring dllDirectory)
{
	//logging is good. Util.lib Borrowed from BWAPI (thank you)
	fl = new Util::FileLogger(wstr_to_str(dllDirectory)+"..\\logs\\Monoailog.log",Util::LogLevel::MicroDetailed,true);
#ifdef BRIDGE_DEBUG
	BWAPI::Broodwar->printf("Initializing bridge...");
#endif
	fl->logDetailed("Init Mono Bridge");
	initmono(dllDirectory);
	BWAPI::Broodwar->printf("Mono Running OK. Functions Loaded OK.");
}

void BridgeAIModule::destroy()
{
	if (BridgeAIModule::domain != NULL) {
		mono_jit_cleanup(BridgeAIModule::domain);
	}
}

BridgeAIModule::BridgeAIModule()
{

}

BridgeAIModule::~BridgeAIModule()
{
	delete fl;
}

void BridgeAIModule::onStart() 
{
	fl->logDetailed("Game started: ");
	runmethod_noparams(BridgeAIModule::startMethod,BridgeAIModule::botobject);
}

void BridgeAIModule::onEnd()
{
	runmethod_noparams(BridgeAIModule::endMethod,BridgeAIModule::botobject);	
}

void BridgeAIModule::onFrame()
{
	runmethod_noparams(BridgeAIModule::frameMethod,BridgeAIModule::botobject);
}

bool BridgeAIModule::onSendText(std::string text)
{
	//This one needs a string. So create a mono string
	MonoString *str = mono_string_new(BridgeAIModule::domain,text.c_str());
	//add it to the args array
	gpointer args[1];
	args[0] = str;
	//run and get result
	MonoObject *result = mono_runtime_invoke(BridgeAIModule::sendTextMethod,BridgeAIModule::botobject,args,NULL);
	//value types are returned boxed. Unbox for use.
	bool bresult = *(bool *)mono_object_unbox(result);
	return bresult;
}

//unit functions below store the unit parameter for access by the runtime bot.
void BridgeAIModule::onUnitCreate(BWAPI::Unit *unit)
{ 
	BridgeAIModule::lastunitparam = unit;
	runmethod_noparams(BridgeAIModule::unitCreateMethod,BridgeAIModule::botobject);
}

void BridgeAIModule::onUnitDestroy(BWAPI::Unit *unit)
{
	BridgeAIModule::lastunitparam = unit;
	runmethod_noparams(BridgeAIModule::unitDestroyMethod,BridgeAIModule::botobject);
}

void BridgeAIModule::onUnitMorph(BWAPI::Unit *unit)
{
	BridgeAIModule::lastunitparam = unit;
	runmethod_noparams(BridgeAIModule::unitMorphMethod,BridgeAIModule::botobject);
}

void BridgeAIModule::onUnitShow(BWAPI::Unit *unit)
{
	BridgeAIModule::lastunitparam = unit;
	runmethod_noparams(BridgeAIModule::unitShowMethod,BridgeAIModule::botobject);
}

void BridgeAIModule::onUnitHide(BWAPI::Unit *unit)
{
	BridgeAIModule::lastunitparam = unit;
	runmethod_noparams(BridgeAIModule::unitHideMethod,BridgeAIModule::botobject);
}