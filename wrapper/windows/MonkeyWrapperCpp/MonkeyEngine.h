#pragma once

#include "IMonkeyEngine.h"

#include "VideoEngine.h"

namespace monkey_cpp 
{

class MonkeyEngine : public IMonkeyEngine
{
public:
	static MonkeyEngine& GetInstance();

	void Destroy();

	// IMonkeyEngine
	ErrCode Init(const EngineContext& context) override;

	virtual IVideoEngine& GetVideoEngine() override;

private:
	MonkeyEngine() {}

};

}
