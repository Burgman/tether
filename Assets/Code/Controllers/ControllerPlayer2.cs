using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using BaseElement;

public class ControllerPlayer2 : Character
{

    public float movementSpeed = 10.0f;
    public float rotationSpeed = 5.0f;

    public GameObject cameraDolling;

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
        if (this.GetCurrenElectricity() < 0)
        {
            return;
        }
        transform.Translate(dir * movementSpeed * Time.deltaTime);
        if (dir != Vector3.zero)
        {
            NotifyPositionDidChange();
        }

        this.ConsumeElectricityPerMove();
    }

    private void NotifyPositionDidChange()
    {
        if (cameraDolling)
        {
            var observer = cameraDolling.GetComponent<CameraController>();
            observer.PlayersPositionDidChange();
        }
    }
}
