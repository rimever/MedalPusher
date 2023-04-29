using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public static int Score = 100;

    // Update is called once per frame
    void Update()
    {
        text.text = $"Score:{Score}";
    }
}
