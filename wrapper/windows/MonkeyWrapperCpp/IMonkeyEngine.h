#pragma once
/*******************************************************************************
 * @file IMonkeyEngine.h 
 * @brief Monkey引擎头文件
 * @author Teck Zhou
 * @email 149159337@qq.com
 * @date 2020-09-19
 ******************************************************************************/

#include "String.h"
#include "Vector.h"

namespace monkey_cpp 
{

/**
 * @brief 错误码定义
 */
enum ErrCode
{
	ERR_CODE_OK = 0
};

/**
 * @brief 引擎回调事件类型
 */
enum EventType
{
	MONKEY_EVENT_UNKNOWN = 0
};

/**
 * @brief 实现此接口来处理引擎回调出来的事件
 */
struct IEventHandler
{
	/**
	 * @brief 通用事件回调
	 */
	virtual void OnCommonEvent(EventType et, ErrCode ec) = 0;
};

/**
 * @brief 引擎初始化所需上下文
 */
struct EngineContext
{
	IEventHandler* event_handler;
};

/**
 * @brief 引擎初始化所需上下文
 */
struct VideoDevice
{
	String dev_name;
	int dev_id;
};

/**
 * @brief 视频引擎，负责视频相关处理
 */
struct IVideoEngine
{
	virtual ErrCode GetVideoDevices(Vector<VideoDevice>& devices) = 0;

	/**
	 * @brief 显示远端视频流，不需要加入分组即可调用
	 * @param stream_id 流标识
	 * @param stream_token 接收流所需的令牌
	 */
	virtual ErrCode DisplayRemoteVideo(const String& stream_id, const String& stream_token) = 0;

	/**
	 * @brief 显示远端视频流，需要加入分组后才可以调用
	 * @param user_id 用户标识
	 * @param media_id 媒体标识
	 * @param hwnd 指定显示的窗口
	 */
	virtual ErrCode DisplayRemoteVideo(const String& user_id, const String& media_id, int hwnd) = 0;

	/**
	 * @brief 预览本地视频设备
	 * @param dev_id 视频设备编号，详见
	 * @param hwnd 指定显示的窗口
	 */
	virtual ErrCode PreviewLocalVideo(int camera_id, int hwnd) = 0;
};

/**
 * @brief 主引擎
 */
struct IMonkeyEngine
{
	/**
	 * @brief 初始化引擎
	 * @param 初始化上下文
	 */
	virtual ErrCode Init(const EngineContext& context) = 0;

	/**
	 * @brief 获取视频引擎
	 */
	virtual IVideoEngine& GetVideoEngine() = 0;
};

}
