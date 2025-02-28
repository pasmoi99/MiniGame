using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private KeyCode _spawnKey;
    //[SerializeField] private float _offset;
    //private bool _spawnKeyPressed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_spawnKey))
        {
            GameObject inst = Instantiate(MainGame.MainScript.Ball, transform);
            inst.transform.position = transform.position;
        } 
    }
}
