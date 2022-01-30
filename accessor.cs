using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class accessor : MonoBehaviour
{

    public TextMeshProUGUI text;
    static public float timer;
  



    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        text.text = GameMaster.score.text;
        GameMaster.score = text;
    }


}
