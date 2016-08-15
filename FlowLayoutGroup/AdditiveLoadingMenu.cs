using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

 class AdditiveLoadingMenu  : MonoBehaviour
{

	public SceneLoader sceneLoader;
    public Slider progressBar;

	void Start()
    {
        if (progressBar == null)
        {
            Debug.LogError(" AdditiveLoadingMenu : ProgressBar is null");
        }
    }


    void Update()
    {
		if (progressBar != null && sceneLoader != null)
        {
			progressBar.value = sceneLoader.loader.progress;
        }

    }
 }
