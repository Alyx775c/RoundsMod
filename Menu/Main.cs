using UnityEngine;
using System;
using Object = UnityEngine.Object;
using RoundsMenu.Classes;
using RoundsMenu.Mods;
using TMPro;
using UnityEngine.UI;
using System.IO;

namespace RoundsMenu.Menu
{
    public class MainModMenuHandler
    {
        public void AddMenu(AssetBundle uiAssetBundle)
        {
            GameObject Menu = uiAssetBundle.LoadAsset<GameObject>("ModCanvas");
            GameObject ButtonPrefab = uiAssetBundle.LoadAsset<GameObject>("Button");

            GameObject menuCanvas;

            try
            {
                menuCanvas = Object.Instantiate(Menu);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (Transform menuPanelCTransform in menuCanvas
                       .GetComponentInChildren<RectTransform>())
            {
                if (menuPanelCTransform.name == "ModPanel")
                {
                    foreach (Transform menuPageTransform in menuPanelCTransform
                               .GetComponentInChildren<RectTransform>())
                    {
                        GameObject menuPage = menuPageTransform.gameObject;

                        if (menuPage.name != "FrontPage")
                        {
                            menuPage.SetActive(false);
                        }
                    }
                }
            }


            foreach (ButtonInfo buttonInfo in Buttons.button)
            {
                GameObject buttonPrefab = Object.Instantiate(ButtonPrefab);
                RectTransform buttonTransform = buttonPrefab.GetComponent<RectTransform>();
                Button buttonObject = buttonPrefab.GetComponent<Button>();
                TextMeshProUGUI buttonText =
                  buttonPrefab.GetComponentInChildren<TextMeshProUGUI>();

                buttonTransform.SetParent(
                  GameObject.Find(Path.Combine("ModCanvas(Clone)/ModPanel/" + buttonInfo.page + "Page")).transform);

                buttonTransform.anchoredPosition = buttonInfo.anchorPoint;
                buttonTransform.sizeDelta = buttonInfo.size;
                buttonTransform.localPosition = buttonInfo.position;

                buttonObject.onClick.AddListener(() => buttonInfo.method());
                
                buttonText.text = buttonInfo.buttonText;
            }

        }
    }
}
