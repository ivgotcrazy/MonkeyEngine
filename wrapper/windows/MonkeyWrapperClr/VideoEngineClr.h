#pragma once

#include "ClrCommon.h"

namespace monkey_clr
{

public ref class VideoEngineClr
{
public:
	ErrCodeClr GetVideoDevices(VideDeviceListClr devices);

	ErrCodeClr DisplayRemoteVideo(
		const System::String^ stream_id,
		const System::String^ stream_token);

	ErrCodeClr DisplayRemoteVideo(
		const System::String^ user_id,
		const System::String^ media_id,
		System::Int32 hwnd);

	ErrCodeClr PreviewLocalVideo(System::Int32 dev_id, System::Int32 hwnd);
};

}