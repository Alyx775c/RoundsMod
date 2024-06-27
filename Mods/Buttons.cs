using RoundsMenu.Classes;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Mods
{
    class Buttons
    {
        public static ButtonInfo[] button = [
            new (){
                buttonText = "OP mods",
                isTogglable = false,
                method = () => PageHandler.ChangePage(Page.OP),
                page = Page.Front,
                position = new(-94.3f, 114.6f),
                size = new(80, 25),
            }
        ];
    }
}
