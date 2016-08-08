using System;
using UnityEngine;                                                                                              
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Popup  : MonoBehaviour
{
    protected Popups ID;
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
                HidePopup();
            }
            else
            {
                ShowPopup();
            }
        }
    }

    private Vector2 _PopupPosition;
    public Vector2 PopupPosition
    {
        get { return _PopupPosition; }
        set { _PopupPosition = value; }
    }

    protected virtual void InitializePopup() { }
    public virtual void ShowPopup() { }
    public virtual void HidePopup() { }
    public virtual void PopupDisplayed() { }
    public virtual void UpdateValuesOnPopup() { }
    public virtual void BackButtonPressed() { }
}
