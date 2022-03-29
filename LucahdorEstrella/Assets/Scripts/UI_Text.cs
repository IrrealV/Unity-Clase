using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Text : MonoBehaviour
{
    public TextMeshProUGUI content;
    private float count;
    // Start is called before the first frame update
    void Start()
    {
        content.text = "Texto de ejemplo";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
