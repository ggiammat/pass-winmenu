using System;
using System.Collections.Generic;
using PassWinmenu.WinApi;

namespace PassWinmenu.Notifications
{
	internal interface ISortingService
	{

		void Sort(List<string> list);

		void recordUsedFile(string s);
	}
}
