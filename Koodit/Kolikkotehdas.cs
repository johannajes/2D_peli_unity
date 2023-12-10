using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolikkotehdas : MonoBehaviour
{
    public static Kolikkotehdas instance;
    public GameObject kolikko = null;
    private float ajanlaskuri = 0f;
    public GameObject apukolikko;
    // Start is called before the first frame update
    private void Awake() {
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
        //kolikoiden luontiväli
        this.ajanlaskuri+= Time.deltaTime;
        //luodaan uusi kolikko, kun aikaa on kulunut tarpeeksi
        if (this.ajanlaskuri >=2.5f) {
            if(apukolikko!=null){
                Destroy(apukolikko);
            }
            apukolikko=Instantiate(this.kolikko, 
                new Vector3(Random.Range(-8f,8f),Random.Range(0f,3f),0f), 
                Quaternion.identity);
            this.ajanlaskuri=0;
        }
        
    }
}
