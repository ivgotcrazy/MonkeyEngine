#include "CoreEngine.h"

using namespace monkey_core;

CoreEngine& CoreEngine::GetInstance()
{
	static CoreEngine engine;
	return engine;
}

CoreErrCode CoreEngine::Init()
{
	return MONKEY_ERR_OK;
}

CoreVideoEngine& CoreEngine::GetVideoEngine()
{
	static CoreVideoEngine video_engine;
	return video_engine;
}