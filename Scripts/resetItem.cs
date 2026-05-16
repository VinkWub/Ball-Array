using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetItem : MonoBehaviour
{
    public Item manager;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            manager.RandomItem(gameObject);
        }
        if(other.gameObject.CompareTag("Player"))
        {
            manager.RandomItem(gameObject);
        }
    }
}
