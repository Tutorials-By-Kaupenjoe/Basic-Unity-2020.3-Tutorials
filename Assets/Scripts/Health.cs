using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int mana = 50;
    [SerializeField] private int experience = 0;

    // Start is called before the first frame update
    void Start()
    {
        health -= 20;
    }

    // Update is called once per frame
    void Update()
    {
        experience += 1;
    }
}
