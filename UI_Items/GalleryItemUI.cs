using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GalleryItemUI : MonoBehaviour 
{
	
	public string filePath;
	public Texture2D thmbnail;
	public Text title;
	void Start()
	{
		title.text = System.IO.Path.GetFileName(filePath);
	}

	public void OnClicked()
	{
		DataManager.Instance.CurrentVideoPath = filePath;
		MenuManager.Instance.CurrentMenuState = MenuStates.PreviewMenu;
	}
}
