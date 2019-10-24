using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharInventory : MonoBehaviour
{
    private int appleCount = 0;
    public GameObject blockBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "apple")
        {
            appleCount += 1;
            Debug.Log("ya got an apple" + appleCount);
            if(appleCount > 1)
            {
                blockBox.SetActive(false);
            }

        }
    }
}
