using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [SerializeField] private int score = 0;
    [SerializeField] private Text scoreValue = null;

    private void Start()
    {
        scoreValue.text = score.ToString();
    }

    public void AddScore(int add)
    {
        score += add;
        scoreValue.text = score.ToString();
    }

   

}
