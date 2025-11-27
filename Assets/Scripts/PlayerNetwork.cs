using UnityEngine;
using Photon.Pun;

public class PlayerNetwork : MonoBehaviourPunCallbacks
{
    public float speed = 5f;

    void Update()
    {
        if (!photonView.IsMine) return;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }
}