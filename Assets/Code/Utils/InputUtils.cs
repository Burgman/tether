using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class InputUtils
    {
        private static float HorizontalPlayer1()
        {
            return Input.GetAxis(InputName.AXIS_HORIZONTAL_1);
        }

        private static float VerticalPlayer1()
        {
            return Input.GetAxis(InputName.AXIS_VERTICAL_1);
        }

        public static Vector3 DirectionPlayer1()
        {
            return new Vector3(HorizontalPlayer1(), 0, VerticalPlayer1());
        }

        private static float HorizontalPlayer2()
        {
            return Input.GetAxis(InputName.AXIS_HORIZONTAL_2);
        }

        private static float VerticalPlayer2()
        {
            return Input.GetAxis(InputName.AXIS_VERTICAL_2);
        }

        public static Vector3 DirectionPlayer2()
        {
            return new Vector3(HorizontalPlayer2(), 0, VerticalPlayer2());
        }



    }
}
