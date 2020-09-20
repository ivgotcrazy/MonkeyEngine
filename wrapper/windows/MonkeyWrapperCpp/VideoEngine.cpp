#include "VideoEngine.h"

using namespace monkey_cpp;

VideoEngine& VideoEngine::GetInstance()
{
	static VideoEngine engine;
	return engine;
}

ErrCode VideoEngine::GetVideoDevices(Vector<VideoDevice>& devices)
{
	return ERR_CODE_OK;
}

ErrCode VideoEngine::DisplayRemoteVideo(const String& stream_id, const String& stream_token)
{
	return ERR_CODE_OK;
}

ErrCode VideoEngine::DisplayRemoteVideo(const String& user_id, const String& media_id, int hwnd)
{
	return ERR_CODE_OK;
}

ErrCode VideoEngine::PreviewLocalVideo(int dev_id, int hwnd)
{
	return ERR_CODE_OK;
}