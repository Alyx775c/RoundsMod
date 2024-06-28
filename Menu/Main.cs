using UnityEngine;
using System;
using Object = UnityEngine.Object;
using RoundsMenu.Classes;
using RoundsMenu.Mods;
using TMPro;
using UnityEngine.UI;
using BepInEx.Logging;

namespace RoundsMenu.Menu
{
    public class MainModMenuHandler
    {
        public void AddMenu(AssetBundle uiAssetBundle, ManualLogSource logger)
        {
            GameObject Menu = uiAssetBundle.LoadAsset<GameObject>("ModCanvas");
            GameObject ButtonPrefab = uiAssetBundle.LoadAsset<GameObject>("Button");

            GameObject menuCanvas;

            try
            {
                menuCanvas = Object.Instantiate(Menu);
                GameObject.DontDestroyOnLoad(menuCanvas);
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
                  GameObject.Find("ModCanvas(Clone)/ModPanel/" + buttonInfo.page + "Page").transform);

                Transform buttonParent = buttonTransform.parent.transform;

                buttonTransform.anchorMin = buttonInfo.anchorPoint;
                buttonTransform.anchorMax = buttonInfo.anchorPoint;

                buttonTransform.localScale = new(1, 1, 1);

                buttonTransform.localPosition = buttonInfo.position;
                buttonTransform.sizeDelta = buttonInfo.size;

                buttonObject.onClick.AddListener(() => buttonInfo.method());

                buttonText.text = buttonInfo.buttonText;
                buttonText.fontSize = buttonInfo.fontSize;
                buttonText.gameObject.GetComponent<RectTransform>().sizeDelta = buttonInfo.size;
            }

        }
    }
}
