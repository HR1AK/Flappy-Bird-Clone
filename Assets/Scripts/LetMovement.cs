using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class LetMovement: MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        //transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

}
