#pragma once

#include "CoreVideoEngine.h"
#include "CoreCommon.h"

namespace monkey_core 
{

class CoreEngine
{
public:
	static CoreEngine& GetInstance();

	CoreErrCode Init();

	CoreVideoEngine& GetVideoEngine();
};

}
