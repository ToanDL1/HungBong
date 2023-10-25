using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reactangle : MonoBehaviour
{
    public const float moveSpeed = 8;
    float xDirection;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Move Step" + moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        // Khi bấm nút sang trái thì nó trả về -1 còn bấm sang phải thì trả về 1.
        // Lay vi tri chieu ngang
        xDirection = Input.GetAxisRaw("Horizontal");

        float moveStep = moveSpeed * xDirection * Time.deltaTime;

        if (transform.position.x >= 5 || transform.position.x <= -5)
        {
            if (transform.position.x * xDirection > 0)
                return;
        }

        transform.position = transform.position + new Vector3(moveStep, 0, 0);


    }

}
