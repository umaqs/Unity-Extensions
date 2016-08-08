using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    protected MenuStates ID;
    protected bool isActive;

    private bool _hidden;
    public bool Hidden
    {
        get { return _hidden; }
        set 
        { 
            _hidden = value;
            if (value)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }                 
    }

    private Vector2 _menuPosition;
    public Vector2 MenuPosition
    {
        get { return _menuPosition; }
        set { _menuPosition = value; }
    }

    protected virtual void InitializeMenu() { }
    public virtual void ShowMenu() { }
    public virtual void HideMenu() { }
    public virtual void MenuDisplayed() { }
    public virtual void UpdateValuesOnMenu() { }
    public virtual void BackButtonPressed() { }
    public virtual void Update() { }

    public virtual void ToggleVolume(bool value)
    {
        float val = (float)System.Convert.ToDouble(value);
        SoundsManager.Instance.SetMusicVolume(val);
        SoundsManager.Instance.SetSFXVolume(val);
    }


}
