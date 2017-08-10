using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{

    public class Const
    {

    }

    public class MenuKeyCode
    {
        public const KeyCode KEY_CODE_JOIN_1 = KeyCode.A;
        public const KeyCode KEY_CODE_JOIN_2 = KeyCode.RightShift;
        public const KeyCode KEY_CODE_START = KeyCode.Space;
    }

    public class GameConst
    {
        public const int GAME_MIN_PLAYERS = 2;

        public const string TEXT_READY_PLAYER_1 = "Player 1 is ready";
        public const string TEXT_READY_PLAYER_2 = "Player 2 is ready";

        public const string TEXT_NOTREADY_PLAYER_1 = "Press A to join";
        public const string TEXT_NOTREADY_PLAYER_2 = "Press LSHIFT to join";

        public const string TAG_PLAYER = "Player";

        public const float CAMERA_Y_MAX = 6;
        public const float CAMERA_Y_MIN = 0;

        public const int PILOT_MAX = 4;

    }

    public class CharacterAttr
    {
        public const float CHARACTER_MAX_OXYGEN = 10;
        public const float CHARACTER_MAX_ELECTRICITY = 20;

        public const float CHARACTER_OXYGEN_CONSUME_PER_SECOND = 1;
        public const float CHARACTER_ELECTRICITY_CONSUME_PER_MOVE = 1;
    }

    public class GameState
    {
        public const string STATE_WAITING = "waiting";
        public const string STATE_INGAME = "ingame";
        public const string STATE_OVER = "gameover";
    }

    public class GameScene
    {
        public const string SCENE_PROTOTYPE = "levelprototype";
    }

    public class InputName
    {
        public const string AXIS_HORIZONTAL_1 = "Horizontal_P1";
        public const string AXIS_HORIZONTAL_2 = "Horizontal_P2";
        public const string AXIS_VERTICAL_1 = "Vertical_P1";
        public const string AXIS_VERTICAL_2 = "Vertical_P2";
        public const string BUTTON_INTERACT_1 = "Interact_P1";
        public const string BUTTON_INTERACT_2 = "Interact_P2";

    }

}
