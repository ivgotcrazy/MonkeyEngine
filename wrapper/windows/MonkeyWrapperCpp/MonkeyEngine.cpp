#include "MonkeyEngine.h"

using namespace monkey_cpp;

MonkeyEngine& MonkeyEngine::GetInstance()
{
	static MonkeyEngine engine;
	return engine;
}

void MonkeyEngine::Destroy()
{

}

ErrCode MonkeyEngine::Init(const EngineContext& context)
{

	return ERR_CODE_OK;
}

IVideoEngine& MonkeyEngine::GetVideoEngine()
{
	return VideoEngine::GetInstance();
}