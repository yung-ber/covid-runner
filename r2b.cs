using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r2b : MonoBehaviour
{
    public Collider player;
    void OnTriggerEnter(Collider other)
    {
        if (other == player){
            Application.LoadLevel("SampleScene");
        }
    }
}
