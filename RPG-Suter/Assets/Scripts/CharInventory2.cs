using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharInventory2 : MonoBehaviour
{
    public int needItCount = 0;
    public GameObject crate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when player collides with objects tagged "needit",
        // then change a variable to +1.
        // if that +1 makes the total 2, turn of crate.

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("needit"))
        {
            needItCount += 1;
            Debug.Log("you have an apple.");
            if(needItCount >= 2)
            {
                crate.SetActive(false);
            }
        }
    }

}
