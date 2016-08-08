using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverMenu : Menu 
{
    public Text Score;
    public Text BestScore;
    protected override void InitializeMenu()
    {
        base.InitializeMenu();

        ID = MenuStates.GameOverMenu;

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
        UpdateValuesOnMenu();
    }

    public override void HideMenu()
    {
        base.HideMenu();

        this.gameObject.SetActive(false);
    }

    public override void UpdateValuesOnMenu()
    {
        base.UpdateValuesOnMenu();
        Score.text = GameManager.Instance.Score.ToString();
        BestScore.text = GameDataManager.Instance.BestScore.ToString();
    }

    #region Button Events

    public void HomeClicked()
    {
        MenuManager.Instance.CurrentMenuState = MenuStates.MainMenu;
    }

    public void RestartButtonClicked()
    {
        MenuManager.Instance.CurrentMenuState = MenuStates.HUDMenu;
        GameManager.Instance.StartGame();
    }
    #endregion
}
