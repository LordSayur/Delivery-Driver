using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Driver : MonoBehaviour
{
    [SerializeField] 
    float steerSpeed = 300f;
    [SerializeField] 
    float moveSpeed = 20f;
    [SerializeField]
    float slowSpeed = 15f;
    [SerializeField]
    float boostSpeed = 30f;

    PhotonView photonView;

    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
            float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

            transform.Rotate(0, 0, -steerAmount);
            transform.Translate(0, moveAmount, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Booster")
        {
            moveSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bumps")
        {
            moveSpeed = slowSpeed;
        }
    }
}
