#include "CoreVideoEngine.h"

using namespace monkey_core;

CoreErrCode CoreVideoEngine::GetVideoDeviceList(VideoDeviceEntryList& dev_list)
{
	return MONKEY_ERR_OK;
}

CoreErrCode CoreVideoEngine::DisplayVideo(const std::string& user_id, int dev_id)
{
	return MONKEY_ERR_OK;
}

CoreErrCode CoreVideoEngine::AddRawVideoDataListener(const std::string& user_id)
{
	return MONKEY_ERR_OK;
}

CoreErrCode CoreVideoEngine::RemoveRawVideoDataListener(const std::string& user_id)
{
	return MONKEY_ERR_OK;
}

CoreErrCode CoreVideoEngine::AddEncodedVideoDataListener(const std::string& user_id)
{
	return MONKEY_ERR_OK;
}

CoreErrCode CoreVideoEngine::RemoveEncodedVideoDataListener(const std::string& user_id)
{
	return MONKEY_ERR_OK;
}