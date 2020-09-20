#pragma once

#include <string>
#include <vector>

namespace monkey_core {

enum CoreErrCode
{
	MONKEY_ERR_OK = 0
};

enum ColorSpace
{
	
};

struct VideoDeviceEntry
{
	std::string dev_name;
	int dev_id;
};

typedef std::vector<VideoDeviceEntry> VideoDeviceEntryList;

struct VideoCapParam
{
	int width;
	int height;
	int frame_rate;
	int color_space;
};

struct VideoEncParam
{
	int encoder_id;
	int width;
	int height;
	int frame_rate;
	int bit_rate;
	int bit_rate_control_mode;
};

struct VideoDataParam
{
	int width;
	int height;
	int data_type;
	char* data;
	int data_len;
};

}
