using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDMenu : Menu 
{
    public Text Instruction; 
    public Text Score;
    bool _shouldShowInstructions = true;
    public bool ShouldShowInstructions
    {
        get { return _shouldShowInstructions; }
        set
        {
            _shouldShowInstructions = value; if (_shouldShowInstructions)
            {
                Instruction.gameObject.SetActive(true);
            }
        }
    }

    protected override void InitializeMenu()
    {
        base.InitializeMenu();

        ID = MenuStates.HUDMenu;

        if (MenuManager.Instance != null)
        {
            MenuManager.Instance.AddMenu(ID, this);
        }
        this.gameObject.SetActive(false);
    }
    public override void ShowMenu()
    {
        base.ShowMenu();
        Instruction.gameObject.SetActive(true);
        this.gameObject.SetActive(true);
        GameManager.OnScoreUpdate += GameManager_OnScoreUpdate;
    }

    void GameManager_OnScoreUpdate(int _sc0re)
    {
        Score.text = _sc0re.ToString();
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

    public void TapToPlayClicked()
    {
        Instruction.gameObject.SetActive(false);
        GameManager.Instance.PlayGame();
    }

    public void PauseButtonClicked()
    {
        MenuManager.Instance.CurrentMenuState = MenuStates.PauseMenu;
    }
}
