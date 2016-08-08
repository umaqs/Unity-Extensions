using UnityEngine;
using System.Collections;

public class OptionMenu : Menu 
{

    protected override void InitializeMenu()
    {
        base.InitializeMenu();

        ID = MenuStates.OptionsMenu;

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

}
