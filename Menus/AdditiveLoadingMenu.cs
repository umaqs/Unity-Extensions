using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

 class AdditiveLoadingMenu  : MonoBehaviour
{
        public AdditiveLoadingScene additiveLoadingScript;
        public Slider progressBar;

        // Use this for initialization
        void Start()
        {
            if (progressBar == null)
            {
                Debug.LogError(" AdditiveLoadingMenu : ProgressBar is null");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (additiveLoadingScript != null && progressBar != null)
            {
                progressBar.value = additiveLoadingScript.LoadingProgress;
            }
        }
 }
