using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCode : MonoBehaviour
{
    public int NumberIngredients;
    string ingredientType;
    Vector2 Inventorypos;

    GameObject Player;
    PlayerMovement playertraits;
    bool TakeItem;
    bool FindItem;
    string Item;
    double index;

    public GameObject[] Ingredients;
    Vector2 ItemPos;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Hero");

        NumberIngredients = 0;
        Inventorypos = new Vector2(-4, -4);
        index = 1;
    }

    void Update()
    {

        FindItem = Player.GetComponent<PlayerMovement>().FindItem;
        TakeItem = Player.GetComponent<PlayerMovement>().TakeItem;
        Item = Player.GetComponent<PlayerMovement>().Item;
        ItemPos = Player.GetComponent<PlayerMovement>().ItemPos;


        if (TakeItem == true) //X
        {
            
            Inventorypos = new Vector2(-3, -1);
            print(Inventorypos);
            GameObject.Find(name).transform.position = new Vector3(Inventorypos.x, Inventorypos.y,-4);
            TakeItem = false;

        }

        if(FindItem == true) //Z
        {
            GameObject.Find(Item).transform.position = new Vector3(ItemPos.x, ItemPos.y, -4);
            FindItem = false;

        }
    }

    
    

}
