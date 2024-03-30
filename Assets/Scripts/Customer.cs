using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField]
    [Tooltip("A list of products. Make all your products here")]
    List<Product> products = new List<Product>();

    [Header("Debug")]
    public FlowerChanger flowerChanger;
    public PotChanger potChanger;

    [SerializeField]
    [Tooltip("The product image. Put image gameobject in here.")]
    Image productImg;

    int currentProduct;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRandomProduct();
    }

    // Update is called once per frame
    void Update()
    {
        currentProductUpdate();
    }

    public void Check()
    {
        if (flowerChanger.currentFlower == products[currentProduct].flowerSelection && potChanger.currentPot == products[currentProduct].potSelection)
        {
            GenerateRandomProduct();
        }
        else Debug.Log("Wrong Combination");
    }

    void currentProductUpdate()
    {
        if (currentProduct < 0)
            currentProduct = products.Count - 1;
        if (currentProduct >= products.Count)
            currentProduct = 0;
    }

    void GenerateRandomProduct()
    {
        currentProduct = UnityEngine.Random.Range(0, products.Count);
        productImg.sprite = products[currentProduct].sprite;
    }
}

[Serializable]
class Product
{
    [Header("Settings")]
    public Sprite sprite;
    public string name;

    [Header("Combenation")]
    public int flowerSelection;
    public int potSelection;
}
