using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCode : MonoBehaviour
{
    public int NumberIngredients;
    string ingredientType;

    GameObject Player;
    GameObject Banana;
    GameObject Croissant;
    PlayerMovement playertraits;
    bool TakeItem;
    bool FindItem;
    string Item;

    Vector2 ItemPos;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Hero");
        Banana = GameObject.Find("Banana");
        Croissant = GameObject.Find("Croissant");

        NumberIngredients = 0;
    }

    void Update()
    {

        FindItem = Player.GetComponent<PlayerMovement>().FindItem;
        TakeItem = Player.GetComponent<PlayerMovement>().TakeItem;
        Item = Player.GetComponent<PlayerMovement>().Item;
        ItemPos = Player.GetComponent<PlayerMovement>().ItemPos;


        if (TakeItem == true) //X
        {

            print(NumberIngredients);
            if (NumberIngredients == 1)
            {
                ItemPos = new Vector2(-4.0f, -4.0f);
            }
            if(NumberIngredients == 2)
            {
                ItemPos = new Vector2(-2.5f, -4.0f);
            }
            
            GameObject Ingredient = GameObject.Find(Item);
            Ingredient.transform.position = new Vector3(ItemPos.x, ItemPos.y,-4);
            TakeItem = false;

        }

        if(FindItem == true) //Z
        {
            GameObject Ingredient = GameObject.Find(Item);
            Ingredient.transform.position = new Vector3(ItemPos.x, ItemPos.y, -4);
            FindItem = false;
            NumberIngredients += 1;

        }
    }

    
    

}
