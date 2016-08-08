using UnityEngine;
using System.Collections;

public class PauseMenu : Menu 
{            
    protected override void InitializeMenu()
    {
        base.InitializeMenu();

        ID = MenuStates.PauseMenu;

        if (MenuManager.Instance != null)
        {
            MenuManager.Instance.AddMenu(ID, this);
        }

        this.gameObject.SetActive(false);
    }
    public override void ShowMenu()
    {
        GameManager.Instance.PauseGame();
        base.ShowMenu();

        this.gameObject.SetActive(true);
    }

    public override void HideMenu()
    {
        base.HideMenu();
        GameManager.Instance.UnpauseGame();
        this.gameObject.SetActive(false);
    }

    public void ResumeClicked()
    {
        MenuManager.Instance.CurrentMenuState = MenuStates.HUDMenu;
    }

}
