#pragma once

#include "IMonkeyEngine.h"

namespace monkey_cpp
{

class VideoEngine : public IVideoEngine
{
public:
	static VideoEngine& GetInstance();

	virtual ErrCode GetVideoDevices(Vector<VideoDevice>& devices) override;

	virtual ErrCode DisplayRemoteVideo(
		const String& stream_id, 
		const String& stream_token) override;

	virtual ErrCode DisplayRemoteVideo(
		const String& userId, 
		const String& mediaId, 
		int hwnd) override;

	virtual ErrCode PreviewLocalVideo(int devId, int hwnd) override;
};

}