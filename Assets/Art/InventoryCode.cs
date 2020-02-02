using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCode : MonoBehaviour
{
    public int NumberIngredients;
    public string Ingredients;

    int IngredientNumber;
    int InventoryNumber;
    GameObject Player;
    GameObject Inventory;

    // Start is called before the first frame update
    void Start()
    {
        NumberIngredients = 0;
        Ingredients = "";
        Player = GameObject.Find("Hero");
        IngredientNumber = Player.GetComponent<PlayerMovement>().IngredientNumber;
        Inventory = GameObject.Find("Inventory");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.X)) 
        {
            CreateInventory();
        }
    }

    //Create new stuff
    void CreateInventory() //new inventory
    {
        if (InventoryNumber < 4)
        {
            Inventory = Instantiate(Inventory);
            Inventory.transform.position = new Vector3(Inventory.transform.position.x + 2, Inventory.transform.position.y, 2);
            InventoryNumber += 1;
        }
        print("Too many ingredients!");
    }

}
