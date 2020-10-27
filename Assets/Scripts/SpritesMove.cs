using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesMove : MonoBehaviour
{
    // Start is called before the first frame update
    //bool notHit; 
    // Update is called once per frame
    public Animator BabyMove;
    public Animator BiggerMe;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        /*
        notHit = true;
        if (other.gameObject.CompareTag("BiggerMe"))
        {    
            notHit = false;
        }
        */
    }

    void Update()
    {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                BabyMove.enabled = true;
                BiggerMe.enabled = true;
                GetComponent<Transform>().Translate(new Vector3(0.3f, 0, 0)); 
            }
            else
            {
                BabyMove.enabled = false;
                BiggerMe.enabled = false;
            }
    }
}
