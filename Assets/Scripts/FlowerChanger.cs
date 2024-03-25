using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerChanger : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField]
    [Tooltip("A list of flowers. Put Flower textures in here.")]
    List<Flower> flowers;

    [SerializeField]
    [Tooltip("The flower image. Put image gameobject in here.")]
    Image flowerImg;

    [Header("Debug")]
    [SerializeField]
    public int currentFlower = 0;

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
        currentFlower++;
        if (currentFlower >= flowers.Count)
            currentFlower = 0;
        ChangeTexture();
    }

    public void ButtonLeft()
    {
        currentFlower--;
        if (currentFlower < 0)
            currentFlower = flowers.Count - 1;
        ChangeTexture();
    }

    void ChangeTexture()
    {
        flowerImg.sprite = flowers[currentFlower].sprite;
    }

    void currentFlowerUpdate()
    {
        if (currentFlower < 0)
            currentFlower = flowers.Count - 1;
        if (currentFlower >= flowers.Count)
            currentFlower = 0;
    }

    [Serializable]
    class Flower
    {
        public Sprite sprite;
        public string name;
    }
}
