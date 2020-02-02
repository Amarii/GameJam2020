using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int NumberIngredients;
    string Ingredients;

    // Start is called before the first frame update
    void Start()
    {
        NumberIngredients = 0;
        Ingredients = "";
    }

    void AddIngredient()
    {
        if(Input.GetKey(KeyCode.X))
        {
            Ingredients = Ingredients + gameObject.name + '\n';
        }
    }
 
}
