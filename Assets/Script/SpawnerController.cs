using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private KeyCode _spawnKey;
    [SerializeField] private float _distance;
    [SerializeField] private float _speed;
    [SerializeField] private int _numberOfBallsMax = 3;
    private int _numberOfBalls;

    //private List<GameObject> Balls = new List<GameObject>();

    private float _originX;
    private float _originY;
    private float _originZ;
    public List<GameObject> BallsList;

    //private bool _spawnKeyPressed
    // Start is called before the first frame update
    void Start()
    {
        _numberOfBalls = _numberOfBallsMax;
        _originX = transform.position.x;
        _originY = transform.position.y;
        _originZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //float 
        transform.position = new Vector3(_originX, _originY, _originZ + Mathf.Sin(Time.time * _speed * 2 * MathF.PI) * _distance);
        if (Input.GetKeyDown(_spawnKey))
        {
            if (_numberOfBalls > 0)
            {
                GameObject inst = Instantiate(MainGame.MainScript.Ball, transform);
                BallsList.Add(inst);
                inst.transform.position = transform.position;
                //inst.GetComponent<Rigidbody>().AddForce();
                inst.transform.parent = null;
                _numberOfBalls--;
            }

            else
            {
                foreach (GameObject inst in BallsList)
                {
                    Destroy(inst);                  
                }

                MainGame.MainScript.UI.AddScore(-MainGame.MainScript.Score);
                BallsList.Clear();
                _numberOfBalls = _numberOfBallsMax;
            }
        }

    }
}
