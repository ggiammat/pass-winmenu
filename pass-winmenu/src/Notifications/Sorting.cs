using System;
using System.Collections.Generic;

namespace PassWinmenu.Notifications
{
    internal class Sorting : ISortingService
    {
        private string? lastUsedPassword;

		public void recordUsedFile(string s)
		{
            lastUsedPassword = s;
		}

        public void Sort(List<string> list)
        {
            if (lastUsedPassword != null && list.Remove(lastUsedPassword))
            {
                list.Sort(StringComparer.OrdinalIgnoreCase);
                list.Insert(0, lastUsedPassword);
            }
            else
            {
                list.Sort(StringComparer.OrdinalIgnoreCase);
            }
        }
        
        
    }
}
