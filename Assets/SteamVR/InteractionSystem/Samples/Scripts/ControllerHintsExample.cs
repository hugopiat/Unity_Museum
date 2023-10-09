//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Demonstrates the use of the controller hint system
//
//=============================================================================

using UnityEngine;
using System.Collections;
using Valve.VR;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
    //-------------------------------------------------------------------------
    public class ControllerHintsExample : MonoBehaviour
    {
        public void MainMenuButton()
        {

            SceneManager.LoadScene("Temple");
        }

        public void QuitButton()
        {
            Application.Quit();
        }
    }
}
