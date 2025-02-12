using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    private TextMeshProUGUI _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = GetComponent<TextMeshProUGUI>();
        _score.text = "0";
    }

    public void UpdateScore(int score)
    {
        _score.text = score.ToString();
    }
}
