#pragma once

#include "ClrCommon.h"
#include "VideoEngineClr.h"

namespace monkey_clr
{

public ref class MonkeyEngineClr
{
public:
	static property MonkeyEngineClr^ Instance
	{
		MonkeyEngineClr^ get() { return %m_monkey_engine; }
	}

	property VideoEngineClr^ VideoEngine
	{
		VideoEngineClr^ get() { return %m_video_engine;  }
	}

	ErrCodeClr Init(EngineContextClr^ context);

private:
	static MonkeyEngineClr m_monkey_engine;
	VideoEngineClr m_video_engine;
};

}
