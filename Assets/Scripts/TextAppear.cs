using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextAppear : MonoBehaviour
{
    public string PicDescripton;
    public GameObject Me;
    private void OnMouseEnter() //Makes Info box appear when mouse is on a poster
    {  
        InfoManager.Instance.TextLabel.GetComponentInChildren<TextMeshProUGUI>().text = PicDescripton;
        InfoManager.Instance.TextLabel.SetActive(true); 
    }

   
    
    private void OnMouseExit()
    {
        InfoManager.Instance.TextLabel.GetComponentInChildren<TextMeshProUGUI>().text = " ";
        InfoManager.Instance.TextLabel.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D Me)
    {
        InfoManager.Instance.TextLabel.GetComponentInChildren<TextMeshProUGUI>().text = PicDescripton;
        InfoManager.Instance.TextLabel.SetActive(true);
        Debug.Log("Scott hit");   
    }

    private void OnCollisionExit2D(Collision2D Me)
    {
        InfoManager.Instance.TextLabel.GetComponentInChildren<TextMeshProUGUI>().text = " ";
        InfoManager.Instance.TextLabel.SetActive(false);
    }
}