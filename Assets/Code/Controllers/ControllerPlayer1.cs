using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using BaseElement;

public class ControllerPlayer1 : Character
{

    public float movementSpeed = 10.0f;
    public float rotationSpeed = 5.0f;

    public GameObject cameraDolling;

    private void FixedUpdate()
    {

        this.DoMovement(InputUtils.DirectionPlayer1());

    }

    private void DoMovement(Vector3 dir)
    {
        if (this.GetCurrenElectricity() < 0)
        {
            return;
        }
        this.transform.Translate(dir * movementSpeed * Time.deltaTime);

        if (dir != Vector3.zero)
        {
            NotifyPositionDidChange();
        }

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
