using System.Collections.Generic;

namespace UICommon
{
    public class TabOptions
    {
        private readonly List<TabItem> _tabs = new List<TabItem>();

        public IReadOnlyCollection<TabItem> Tabs => _tabs.AsReadOnly();

        public void AddTab(string area, string name)
        {
            _tabs.Add(new TabItem()
            {
                Area = area,
                Name = name
            });
        }
    }
}
