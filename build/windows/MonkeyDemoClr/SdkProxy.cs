using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monkey_clr;

namespace monkey_demo_clr
{
	class SdkProxy
	{
		private MonkeyEngineClr m_monkey_engine = MonkeyEngineClr.Instance;
		private VideoEngineClr m_video_engine = MonkeyEngineClr.Instance.VideoEngine;

		private static SdkProxy instance = new SdkProxy();
		public static SdkProxy Instance()
		{
			return instance;
		}

		public void Init()
		{
			EngineContextClr context = new EngineContextClr();
			context.event_handler = new EventHandlerClr();
			context.event_handler.common_event_handler = OnCommonEvent;
			
			ErrCodeClr result = m_monkey_engine.Init(context);
			if (result != ErrCodeClr.ERR_CODE_CLR_OK) {
				System.Console.WriteLine("Init failed, err = {0}", result);
			} else {
				System.Console.WriteLine("Init success.");
			}
		}

		public void PreviewLocalVideo(int dev_id, int wnd)
		{
			ErrCodeClr result = m_video_engine.PreviewLocalVideo(dev_id, wnd);
			if (result != ErrCodeClr.ERR_CODE_CLR_OK) {
				System.Console.WriteLine("Preview local video {0} failed, err = {1}", dev_id, result);
			}
		}

		public void OnCommonEvent(CommonEventClr event_type, ErrCodeClr err_code)
		{
			System.Console.WriteLine("OnCommonEvent: {0}", event_type);
		}
	}
}
