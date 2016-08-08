using UnityEngine;
using System.Collections;

public class MainMenu : Menu 
{
    protected override void InitializeMenu()
    {
        base.InitializeMenu();

        ID = MenuStates.MainMenu;

        if (MenuManager.Instance != null)
        {
            MenuManager.Instance.AddMenu(ID, this);
        }

        this.gameObject.SetActive(false);
    }
    public override void ShowMenu()
    {
        base.ShowMenu();

        this.gameObject.SetActive(true);
    }

    public override void HideMenu()
    {
        base.HideMenu();

        this.gameObject.SetActive(false);
    }

    public override void UpdateValuesOnMenu()
    {
        base.UpdateValuesOnMenu();
    }


    #region Button Events

    public void PlayButtonClicked()
    {
        //Debug.Log("MainMenu : PlayButtonClicked");
        MenuManager.Instance.CurrentMenuState = MenuStates.HUDMenu;
        GameManager.Instance.StartGame();
    }

    public void ResumeFromSavePoint()
    {
        //SoundsManager.Instance.PlayMenuSoundEffects(SoundsManager.LevelSoundsEnum.ButtonClick);

        //GameManager.Instance.followCamRef.SetCameraView(CameraSettings.CameraView.CutScene);
        //GameManager.Instance.ResumeFromSavePoint();
    }

    public void SettingsClicked()
    {

        ////        Debug.Log("MainMenu : OptionsButtonClicked");
        //SoundsManager.Instance.PlayMenuSoundEffects(SoundsManager.LevelSoundsEnum.ButtonClick);
        MenuManager.Instance.CurrentMenuState = MenuStates.OptionsMenu;
    }



    #endregion
}
