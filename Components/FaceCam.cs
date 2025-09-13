﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WrysersGoPro.ConfigManager;
using WrysersGoPro.Core;


namespace WrysersGoPro
{
    public class FaceCam : MonoBehaviour
    {
        public GameObject text;

        public void FaceCamToggle()
        {
            GoProConfig.camMode = 4;
            GoProManager.faceCam = true;
            GoProManager.followPlayer = false;
            GoProManager.thirdPerson = false;
        }

        void Start()
        {
            GetComponent<Button>().onClick.AddListener(FaceCamToggle);
        }
    }
}
