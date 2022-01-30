using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public static TextMeshProUGUI score;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
