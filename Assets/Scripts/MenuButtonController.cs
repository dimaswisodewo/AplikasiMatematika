using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public void OnMenu1ButtonClicked()
    {
        SceneLoader.instance.menuName = Config.menuName1;
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnMenu2ButtonClicked()
    {
        SceneLoader.instance.menuName = Config.menuName2;
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnMenu3ButtonClicked()
    {
        SceneLoader.instance.menuName = Config.menuName3;
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnMenu4ButtonClicked()
    {
        SceneLoader.instance.menuName = Config.menuName4;
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnMenu5ButtonClicked()
    {
        SceneLoader.instance.menuName = Config.menuName5;
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnMenu6ButtonClicked()
    {
        SceneLoader.instance.menuName = Config.menuName6;
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnSubMenu1ButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.VIDEO);
    }

    public void OnSubMenu2ButtonClicked()
    {
        switch (SceneLoader.instance.menuName)
        {
            case Config.menuName1:
                SceneLoader.instance.LoadScene(SCENE.MATERI1_1);
                break;

            case Config.menuName2:
                SceneLoader.instance.LoadScene(SCENE.MATERI2_1);
                break;

            case Config.menuName3:
                SceneLoader.instance.LoadScene(SCENE.MATERI3_1);
                break;

            case Config.menuName4:
                SceneLoader.instance.LoadScene(SCENE.MATERI4_1);
                break;

        }
    }

    public void OnSubMenu3ButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.ASOSIASI);
    }

    public void OnSubMenu4ButtonClicked()
    {
        //SceneLoader.instance.LoadScene(SCENE.SOAL_LATIHAN);
    }

    public void OnBackToMenuButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MENU);
    }

    public void OnBackToSubMenuButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.SUBMENU);
    }

    public void OnNextButtonClicked()
    {
        string sceneName = SceneLoader.instance.sceneName;

        switch (sceneName)
        {
            case Config.materi1_1Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI1_2);
                break;

            case Config.materi1_2Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI1_3);
                break;

            case Config.materi1_3Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI1_4);
                break;

            case Config.materi2_1Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI2_2);
                break;

            case Config.materi2_2Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI2_3);
                break;

            case Config.materi3_1Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI3_2);
                break;

            case Config.materi3_2Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI3_3);
                break;

            case Config.materi4_1Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI4_2);
                break;

            case Config.materi4_2Scene:
                SceneLoader.instance.LoadScene(SCENE.MATERI4_3);
                break;

            default:
                SceneLoader.instance.LoadScene(SCENE.SUBMENU);
                break;
        }
    }
}
