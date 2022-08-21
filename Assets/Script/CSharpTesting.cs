using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CSharpTesting : MonoBehaviourPunCallbacks
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("g") & photonView.IsMine)
        {
            Debug.Log($"isMaster = {PhotonNetwork.IsMasterClient}");
        }
    }
}
