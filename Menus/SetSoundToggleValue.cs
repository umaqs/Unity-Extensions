using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class SetSoundToggleValue : MonoBehaviour 
{
    void OnEnable()
    {
        GetComponent<Toggle>().isOn = SoundsManager.Instance.soundEffectsVolume == 1;
    }
}
