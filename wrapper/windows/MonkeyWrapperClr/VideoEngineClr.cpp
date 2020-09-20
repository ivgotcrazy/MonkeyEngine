#include "VideoEngineClr.h"

using namespace monkey_clr;

ErrCodeClr VideoEngineClr::GetVideoDevices(VideDeviceListClr devices)
{
	return ErrCodeClr::ERR_CODE_CLR_OK;
}

ErrCodeClr VideoEngineClr::DisplayRemoteVideo(
	const System::String^ stream_id,
	const System::String^ stream_token)
{
	return ErrCodeClr::ERR_CODE_CLR_OK;
}

ErrCodeClr VideoEngineClr::DisplayRemoteVideo(
	const System::String^ user_id,
	const System::String^ media_id,
	System::Int32 hwnd)
{
	return ErrCodeClr::ERR_CODE_CLR_OK;
}

ErrCodeClr VideoEngineClr::PreviewLocalVideo(System::Int32 dev_id, System::Int32 hwnd)
{
	return ErrCodeClr::ERR_CODE_CLR_OK;
}