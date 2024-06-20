using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerDisMObj : MonoBehaviour
{

    public GameObject movingObject;
    void Start()
    {
        movingObject.SetActive(false);
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            movingObject.SetActive(true);
        }
    }


}
