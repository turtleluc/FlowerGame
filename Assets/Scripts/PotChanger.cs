using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotChanger : MonoBehaviour
{

    [Header("Settings")]

    [SerializeField]
    [Tooltip("A list of pots. Put Flower textures in here.")]
    List<Pot> pots;

    [SerializeField]
    [Tooltip("The pot image. Put image gameobject in here.")]
    Image potImg;

    [Header("Debug")]

    [SerializeField]
    public int currentPot = 0;

    void Start()
    {
        ChangeTexture();
    }

    void Update()
    {
        currentFlowerUpdate();
    }

    public void ButtonRight()
    {
        currentPot++;
        if (currentPot >= pots.Count)
            currentPot = 0;
        ChangeTexture();
    }

    public void ButtonLeft()
    {
        currentPot--;
        if (currentPot < 0)
            currentPot = pots.Count - 1;
        ChangeTexture();
    }

    void ChangeTexture()
    {
        potImg.sprite = pots[currentPot].sprite;
    }

    void currentFlowerUpdate()
    {
        if (currentPot < 0)
            currentPot = pots.Count - 1;
        if (currentPot >= pots.Count)
            currentPot = 0;
    }

    [Serializable]
    class Pot
    {
        public Sprite sprite;
        public string name;
    }
}
