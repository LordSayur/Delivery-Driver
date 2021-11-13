using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;
    [SerializeField]
    private Vector3 playerPosition;

    private void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, playerPosition, Quaternion.identity);
    }
}
