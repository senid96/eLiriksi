using System;
using System.Collections.Generic;
using System.Text;

namespace lirksi.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Songs
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
