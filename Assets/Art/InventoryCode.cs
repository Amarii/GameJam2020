using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCode : MonoBehaviour
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
        NumberIngredients = 0;
        Ingredients = Instantiate(Player).GetComponent<PlayerMovement>().NewIngredient;
        IngredientNumber = Instantiate(Player).GetComponent<PlayerMovement>().IngredientNumber;
        Inventorypos = new Vector2(-3, -2);
        InventoryPPos = Player.GetComponent<PlayerMovement>().InventoryPlayerPos;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.X)) 
        {
            CreateInventory();
            //Destroy(Player);
        }
    }

    //Create new stuff
    void CreateInventory() //new inventory
    {
        if (InventoryNumber < 4)
        {
            Inventory.transform.position = InventoryPPos;
            Inventorypos = new Vector2(Inventory.transform.position.x + 2, Inventory.transform.position.y);
            InventoryNumber += 1;
        }
        print("Too many ingredients!");
    }

}
