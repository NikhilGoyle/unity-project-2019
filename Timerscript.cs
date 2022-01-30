using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timerscript : MonoBehaviour
{

    public TextMeshProUGUI text;
    static public float timer;
    public float seconds;
    public float minutes;
    


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);
        text.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00");
        GameMaster.score = text;
    }

  
}
