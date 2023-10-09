using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonEffectDay : MonoBehaviour
    {
        public Light sun;
        public GameObject gameObject;

        public Material material1;
        public Material material2;

        Color color_night;

        Vector3 Light_day = new Vector3(90, 0, 0);

        void Start()
        {
            color_night = new Color(220, 168, 112, 125);
        }
        public void OnButtonDown(Hand fromHand)
        {
            sun.transform.eulerAngles = Light_day;
            sun.color = Color.white;
            material1.SetFloat("_Metallic", 0.05f);
            material2.SetFloat("_Metallic", 0.05f);
            gameObject.SetActive(false);
        }
    }
}