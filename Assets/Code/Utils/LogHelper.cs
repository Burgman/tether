using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class LogHelper
    {
        public static void LogError(string error) {
            string log = "<color=red><b>Fatal error: </b></color>" + error;
            Debug.Log(log);
        }


    }

}
