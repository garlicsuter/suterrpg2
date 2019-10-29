using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharInventory3 : MonoBehaviour
{
    //Declare Variables
    public int needItCount = 0;
    public GameObject crate;

    //When we collide with a trigger
    //if the other thing is tagged "needit"
    //then add 1 to our needItCount
    //and if needItCount is > x, crate.Setactive(false)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("needit"))
        {
            Debug.Log("you got an apple!");
            needItCount += 1;
            if(needItCount >= 2)
            {
                crate.SetActive(false);
            }
        }
    }
}
