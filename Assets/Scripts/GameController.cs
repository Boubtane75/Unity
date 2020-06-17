using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private float score;

    [SerializeField]

    private Text scroreLabel;
    // Start is called before the first frame update

    public static GameController instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(float value)
    {
        this.score = value;
        scroreLabel.text = this.score.ToString();
    }
}
