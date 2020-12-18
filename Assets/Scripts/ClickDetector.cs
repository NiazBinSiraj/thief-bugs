using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private GameController gc;
    

    void Start()
    { 
       
        gc = GameObject.Find("Game Controller").GetComponent<GameController>();
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        
        gc.IncreaseScore();
    }
}
