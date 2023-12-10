using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pisteet : MonoBehaviour
{
    public static pisteet instance;
    int piste = 0;
    public Text pisteteksti;
    // Start is called before the first frame update
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        pisteteksti.text = piste.ToString() + " PISTETTÄ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddPoint() {
        piste += 1;
        pisteteksti.text = piste.ToString() + " PISTETTÄ";
    }
}
