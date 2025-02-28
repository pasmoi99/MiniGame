using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pit : MonoBehaviour
{
    public int Points;
    private TextMeshPro m_TextMeshPro;
    private Collider Trigger;


    void Awake()
    {
        Trigger = GetComponent<Collider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        //if (other.gameObject == MainGame.MainScript.Ball) 
        //{

        //    
        //}
        MainGame.MainScript.UI.UpdateScore(Points);
    }
}
