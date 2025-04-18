using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFollow : MonoBehaviour
{
    public GameObject Player;
    public GameObject Ghost;
    public float speed;

    void Update()
    {
        Ghost.transform.position = Vector3.MoveTowards(Ghost.transform.position, Player.transform.position, speed);
    }
}
