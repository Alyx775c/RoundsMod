using UnityEngine;
using static RoundsMenu.Classes.Pages;

namespace RoundsMenu.Mods
{
    class PageHandler
    {
        public static Page currentPage = Page.Front;

        [System.Obsolete]
        public static void ChangePage(Page page)
        {
            string pageToLoad = page.ToString() + "Page";
            
            GameObject.Find("ModCanvas(Clone)/ModPanel/").SetActiveRecursively(true);

            foreach (Transform pageObject in GameObject.Find("ModCanvas(Clone)/ModPanel/").GetComponentInChildren<Transform>())
            {
                if (pageObject.name != pageToLoad)
                {
                    pageObject.gameObject.SetActive(false);
                }
            }
        }
    }
}
