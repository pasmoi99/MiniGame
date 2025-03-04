using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private KeyCode _spawnKey;
    [SerializeField] private float _distance;
    [SerializeField] private int _maxNumberOfBalls;

    //private List<GameObject> Balls = new List<GameObject>();

    private float _offsetX;
    private float _offsetY;
    private float _offsetZ;
    
    //private bool _spawnKeyPressed
    // Start is called before the first frame update
    void Start()
    {
        _offsetX = transform.position.x;
        _offsetY = transform.position.y;
        _offsetZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_spawnKey) && _maxNumberOfBalls>0)
        {
            GameObject inst = Instantiate(MainGame.MainScript.Ball, transform);
            MainGame.MainScript.BallsList.Add(inst);
            inst.transform.position = transform.position;
            _maxNumberOfBalls--;
        }
        if (Input.GetKeyDown(_spawnKey) && _maxNumberOfBalls <= 0)
        {
            MainGame.MainScript.BallsList.Clear();
        }
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(_offsetX, _offsetY, _offsetZ + Mathf.Sin(Time.time) * _distance * Time.deltaTime);
    }
}
