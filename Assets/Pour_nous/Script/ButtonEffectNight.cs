using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffectNight : MonoBehaviour
    {
        public Light sun;
        public GameObject gameObject;

        public Material material1;
        public Material material2;

        Color color_day;

        Vector3 Light_day = new Vector3(270, 0, 0);

        void Start()
        {
            color_day = new Color ( 100, 100, 100, 125);
        }
        public void OnButtonDown(Hand fromHand)
        {
            sun.transform.eulerAngles = Light_day;
            sun.color = Color.black;
            material1.SetFloat("_Metallic", 0.9f);
            material2.SetFloat("_Metallic", 0.9f);
            gameObject.SetActive(true);
        }
    }
}