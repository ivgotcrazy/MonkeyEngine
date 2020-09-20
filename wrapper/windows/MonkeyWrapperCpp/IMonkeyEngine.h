#pragma once
/*******************************************************************************
 * @file IMonkeyEngine.h 
 * @brief Monkey����ͷ�ļ�
 * @author Teck Zhou
 * @email 149159337@qq.com
 * @date 2020-09-19
 ******************************************************************************/

#include "String.h"
#include "Vector.h"

namespace monkey_cpp 
{

/**
 * @brief �����붨��
 */
enum ErrCode
{
	ERR_CODE_OK = 0
};

/**
 * @brief ����ص��¼�����
 */
enum EventType
{
	MONKEY_EVENT_UNKNOWN = 0
};

/**
 * @brief ʵ�ִ˽ӿ�����������ص��������¼�
 */
struct IEventHandler
{
	/**
	 * @brief ͨ���¼��ص�
	 */
	virtual void OnCommonEvent(EventType et, ErrCode ec) = 0;
};

/**
 * @brief �����ʼ������������
 */
struct EngineContext
{
	IEventHandler* event_handler;
};

/**
 * @brief �����ʼ������������
 */
struct VideoDevice
{
	String dev_name;
	int dev_id;
};

/**
 * @brief ��Ƶ���棬������Ƶ��ش���
 */
struct IVideoEngine
{
	virtual ErrCode GetVideoDevices(Vector<VideoDevice>& devices) = 0;

	/**
	 * @brief ��ʾԶ����Ƶ��������Ҫ������鼴�ɵ���
	 * @param stream_id ����ʶ
	 * @param stream_token ���������������
	 */
	virtual ErrCode DisplayRemoteVideo(const String& stream_id, const String& stream_token) = 0;

	/**
	 * @brief ��ʾԶ����Ƶ������Ҫ��������ſ��Ե���
	 * @param user_id �û���ʶ
	 * @param media_id ý���ʶ
	 * @param hwnd ָ����ʾ�Ĵ���
	 */
	virtual ErrCode DisplayRemoteVideo(const String& user_id, const String& media_id, int hwnd) = 0;

	/**
	 * @brief Ԥ��������Ƶ�豸
	 * @param dev_id ��Ƶ�豸��ţ����
	 * @param hwnd ָ����ʾ�Ĵ���
	 */
	virtual ErrCode PreviewLocalVideo(int camera_id, int hwnd) = 0;
};

/**
 * @brief ������
 */
struct IMonkeyEngine
{
	/**
	 * @brief ��ʼ������
	 * @param ��ʼ��������
	 */
	virtual ErrCode Init(const EngineContext& context) = 0;

	/**
	 * @brief ��ȡ��Ƶ����
	 */
	virtual IVideoEngine& GetVideoEngine() = 0;
};

}
