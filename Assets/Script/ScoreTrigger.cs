using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public int Points;
    private TextMeshPro _pointsText;
    private Collider _trigger;


    void Awake()
    {
        _pointsText = GetComponentInChildren<TextMeshPro>();
        _trigger = GetComponent<Collider>();
    }

    private void Start()
    {
        _pointsText.text = Points.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject);
        //if (other.gameObject == MainGame.MainScript.Ball) 
        //{

        //    
        //}
        MainGame.MainScript.UI.AddScore(Points);
    }
}
