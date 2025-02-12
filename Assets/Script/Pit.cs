using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{
    public Collider Trigger;
    public int Points;

    void Awake()
    {
        Trigger = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        if (other.gameObject == MainGame.MainScript.Ball) 
        {

            MainGame.MainScript.UI.UpdateScore(Points);
        }
    }
}
