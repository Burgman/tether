using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class SpacecraftController : MonoBehaviour
{

    private GameObject _mainPilot;
    private GameObject[] _coPilots;
    private int _numberOfCurrentCopilot = 0;

    // Use this for initialization
    void Start()
    {
        _coPilots = new GameObject[GameConst.PILOT_MAX];
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        bool isPilot = GameUtils.CheckIfObjectIsPlayerObject(other.gameObject);
        if (isPilot)
        {
            GameObject pilot = other.gameObject;
            this.HandlePilotOnBoard(ref pilot);
        }
    }

    private void HandlePilotOnBoard(ref GameObject pilot)
    {
        if (_numberOfCurrentCopilot >= GameConst.PILOT_MAX)
        {
            return;
        }



    }
}
