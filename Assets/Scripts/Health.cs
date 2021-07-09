using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int mana = 50;
    [SerializeField] private int experience = 42;

    // Start is called before the first frame update
    void Start()
    {
        health -= 20;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health -= 20;
            if(health <= 0)
            {
                Debug.Log("Lol, you died. Press F to pay respect!");
            }
        }

        if(health <= 0 && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("RESPECT");
        }
    }
}

