using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMove : MonoBehaviourPunCallbacks
{
    private float speed = 0.05f;
    
    void Update()
    {
        if (photonView.IsMine){
            Vector2 position = transform.position;

            if(Input.GetKey("w"))
            {
                position.y += speed;
            }
            if(Input.GetKey("s"))
            {
                position.y -= speed;
            }
            if(Input.GetKey("d"))
            {
                position.x += speed;
            }
            if(Input.GetKey("a"))
            {
                position.x -= speed;
            }

            transform.position = position;
        }
    }
}
