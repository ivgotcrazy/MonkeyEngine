#pragma once

#include <cstdint>
#include <string>

namespace monkey_core
{

enum MsgType
{

};

class IDataSink;

struct IDataSource
{
	virtual void AddDataSink(IDataSink* data_sink) = 0;

	virtual void RemoveDataSink(IDataSink* data_sink) = 0;

	virtual void OnUpMsg(MsgType msg_type, const std::string& msg) = 0;
};

struct IDataSink
{
	virtual void SetDataSource(IDataSource* data_source) = 0;

	virtual void OnData(void* data, uint32_t data_len, void* user_data) = 0;

	virtual void OnDownMsg(MsgType msg_type, const std::string& msg) = 0;
};

struct IDataTransform : public IDataSource, public IDataSink {};

}