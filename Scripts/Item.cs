using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject[] itemArray;
    Rigidbody2D gameRigid;
    // Start is called before the first frame update
    void Start()
    {
        
        gameRigid = GetComponent<Rigidbody2D>();
        for(int i = 0; i < itemArray.Length; i++)
        {
           RandomItem(itemArray[i]); 
        }
        
    }
    public void RandomItem(GameObject item)
    {
            Rigidbody2D rb = item.GetComponent<Rigidbody2D>();

            float x = Random.Range(-8f, 8f);
            float y = Random.Range(8f, 13f);

            rb.velocity = Vector2.zero;
            // rb.angularVelocity = 0f;
            item.transform.position = new Vector2(x, y);
        }
    }
   
