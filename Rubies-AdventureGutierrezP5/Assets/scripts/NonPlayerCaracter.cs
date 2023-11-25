using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCaracter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDispaly;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        timerDispaly = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerDispaly >= 0)
        {
            timerDispaly -= Time.deltaTime;
            if(timerDispaly < 0)
            {
                dialogBox.SetActive(false);
            }
        }
        
    }

    public void DisplayDialog()
    {
        timerDispaly = displayTime;
        dialogBox.SetActive(true);
    }
}
