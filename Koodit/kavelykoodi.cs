using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kavelykoodi : MonoBehaviour
{
    private int suunta=1;
    private float nopeus=1f;
    private float voima=400f;
    private bool ilmassa=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.suunta!=1)
        {
            this.GetComponent<Transform>().Rotate(0f,180f,0f);
            this.suunta=1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.suunta!=2)
        {
            this.GetComponent<Transform>().Rotate(0f,180f,0f);
            this.suunta=2;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && (!this.ilmassa))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up*this.voima);
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.suunta==1) {
            nopeus+=1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.suunta==2) {
            nopeus-=1;
        }
        this.GetComponent<Transform>().Translate(this.nopeus*Time.deltaTime,0f,0f);
        
    }
    
    private void onCollisionExit2D(Collision2D collision) {
        Debug.Log("ilmassa");
        this.ilmassa=true;
    }
    private void onCollisionEnter2D(Collision2D collision) {
        Debug.Log("maassa");
        this.ilmassa=false;
    }
    
}
