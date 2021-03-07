using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class followPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;

    void LateUpdate()
    {
        if (Player != null)
            transform.position = Player.position + Offset;
    }
}
