using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCodeFix : MonoBehaviour
{

    public int NumberIngredients;
    public string Ingredients;
    public GameObject Inventory;
    public Vector2 Inventorypos;

    int IngredientNumber;
    int InventoryNumber;
    Vector3 InventoryPPos;
    GameObject Player;
    PlayerMovement playertraits;

    // Start is called before the first frame update
    void Start()
    {
        Player = Instantiate(GameObject.Find("Hero"));
        Inventory = Instantiate(GameObject.Find("Inventory"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
