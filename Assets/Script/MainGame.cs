using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public static MainGame MainScript;
    public UI UI;
    public GameObject Ball;
    public int Score;

    
    // Start is called before the first frame update
    void Awake()
    {
        MainScript = this;
    }

}
