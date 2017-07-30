using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class GameUtils
    {
        public static float GetMaxDistanceBetweenPlayers(GameObject[] players) {
            float max = 0;
            Vector3 root = players[0].transform.position;
            for (int i = 1; i < players.Length; i++) {
                Vector3 other = players[i].transform.position;
                float distance = (other - root).magnitude;
                if ( distance > max) {
                    max = distance;
                }
            }
            return max;
        }

    }
}

