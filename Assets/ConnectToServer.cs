using Photon.Pun;
using UnityEngine;

public class ConnectToServer : MonoBehaviour
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
}
