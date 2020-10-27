using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    public GameObject TextLabel; //Makes a new instance of this script when called to another obj
    public static InfoManager Instance;
        void Start()
    {
        Instance = this;
    }
}
