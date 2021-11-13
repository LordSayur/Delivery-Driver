using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    GameObject target;

    private void Start()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        foreach (var player in players)
        {
            if (PhotonView.Get(player).IsMine)
            {
                target = player;
                break;
            }
        }
    }

    void LateUpdate()
    {
        transform.position = target.transform.position + new Vector3(0, 0, -10);
    }
}
