using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spread : MonoBehaviour
{
   public Collider player;
   void OnTriggerEnter(Collider other)
    {
        if (other == player) {
            Application.LoadLevel("gameover");
        }
    }
}
