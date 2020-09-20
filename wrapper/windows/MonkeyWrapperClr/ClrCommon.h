#pragma once

namespace monkey_clr
{

public enum class ErrCodeClr
{
	ERR_CODE_CLR_OK = 0
};

public enum class CommonEventClr
{
	COMMON_EVENT_CLR_LOGIN = 0
};

public delegate void CommonEventHandler(CommonEventClr event_type, ErrCodeClr err_code);

public ref struct EventHandlerClr
{
	CommonEventHandler^ common_event_handler;
};

public ref struct EngineContextClr
{
	EventHandlerClr^ event_handler;
};

public ref struct VideoDeivceClr
{
	System::String^	dev_name;
	System::Int32	dev_id;
};

typedef System::Collections::Generic::List<VideoDeivceClr^> VideDeviceListClr;

}
