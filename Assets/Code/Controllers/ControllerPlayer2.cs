using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class ControllerPlayer2 : MonoBehaviour
{

    public float movementSpeed = 10.0f;
    public float rotationSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        this.DoMovement(InputUtils.DirectionPlayer2());

    }

    private void DoMovement(Vector3 dir)
    {

        transform.Translate(dir * movementSpeed * Time.deltaTime);

    }
}
