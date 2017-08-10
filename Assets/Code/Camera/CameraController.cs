using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class CameraController : MonoBehaviour
{

    public float maxThreshold = 3.0f;
    public float minThreshold = 1.0f;

    private GameObject[] _players;

    private static CameraController instance;

    // Use this for initialization
    void Start()
    {
        _players = GameObject.FindGameObjectsWithTag(GameConst.TAG_PLAYER);
        //_mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //ChangeFieldOfView();
    }

    private void ChangeFieldOfView()
    {
        float maxDistance = GameUtils.GetMaxDistanceBetweenPlayers(_players);
        Debug.Log(maxDistance);

        if (maxDistance > maxThreshold)
        {
            Vector3 oldPos = this.transform.position;
            float newY = oldPos.y + maxDistance - maxThreshold;
            if (newY > GameConst.CAMERA_Y_MAX)
            {
                newY = GameConst.CAMERA_Y_MAX;
            }
            this.transform.position = new Vector3(oldPos.x, Mathf.Lerp(oldPos.y, newY, (oldPos.y + newY) / 2), oldPos.z);
        }

        if (maxDistance < minThreshold)
        {
            Vector3 oldPos = this.transform.position;
            float newY = oldPos.y - (minThreshold - maxDistance);
            if (newY < GameConst.CAMERA_Y_MIN)
            {
                newY = GameConst.CAMERA_Y_MIN;
            }
            this.transform.position = new Vector3(oldPos.x, Mathf.Lerp(oldPos.y, newY, (oldPos.y + newY) / 2), oldPos.z);
        }


    }

    public void PlayersPositionDidChange()
    {
        ChangeFieldOfView();
    }
}

