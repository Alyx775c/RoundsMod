using RoundsMenu.Classes;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Mods
{
    class Buttons
    {
        public static ButtonInfo[] button = [
            new (){
                anchorPoint = AnchorPoints.TopLeft,
                buttonText = "OP mods",
                isTogglable = false,
                method = () => PageHandler.ChangePage(Page.OP),
                page = Page.Front,
                position = new(-175f, 119.25f),
                size = new(100, 25),
                fontSize = 22
            }
        ];
    }
}
