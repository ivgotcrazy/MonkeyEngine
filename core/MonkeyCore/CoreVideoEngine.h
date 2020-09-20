#pragma once

#include "CoreCommon.h"

namespace monkey_core {

/**
 * @brief 视频引擎的实现
 */
class CoreVideoEngine
{
public:
	CoreErrCode GetVideoDeviceList(VideoDeviceEntryList& dev_list);

	CoreErrCode DisplayVideo(const std::string& user_id, int dev_id);

	CoreErrCode AddRawVideoDataListener(const std::string& user_id);

	CoreErrCode RemoveRawVideoDataListener(const std::string& user_id);

	CoreErrCode AddEncodedVideoDataListener(const std::string& user_id);

	CoreErrCode RemoveEncodedVideoDataListener(const std::string& user_id);
};

}
