using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject Baby, MSMe; //Add other me if needed

    // Start is called before the first frame update
    //bool wasHit;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("We hit!");
        Baby.SetActive(false);
        MSMe.SetActive(true);
     
    }
}
