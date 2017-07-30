using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Utils
{
    public class LevelUtils
    {

        public static void StartLevel(int level)
        { }

        public static void StartLevel(string level)
        {
            SceneManager.LoadScene(level);
        }

    }

}
