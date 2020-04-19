using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    private bool rorl;
    void Update()
    {
        rorl = true;
        if (Input.GetKey("right") == true){
            transform.position = new Vector3(transform.position.x+1,transform.position.y,transform.position.z+3);
            rorl = false;
        } if (Input.GetKey("left") == true){
            transform.position = new Vector3(transform.position.x-1,transform.position.y,transform.position.z+3);
            rorl = false;
        } if (rorl) {
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+3);
        }
        if (Input.GetKey("up")){
            transform.position = new Vector3(transform.position.x,transform.position.y+1,transform.position.z);
        }
    }
}
