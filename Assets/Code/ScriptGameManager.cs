using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils;

public enum BuildMode : int { DEBUG, DEV, RELEASE };
public enum GameState : int { WAITING, INGAME, OVER};

public class ScriptGameManager : MonoBehaviour
{

    public Text textPlayer1;
    public Text textPlayer2;
    public Text textReadyToStart;

    //Check if player at position is ready
    bool _readyPlayer1 = false;
    bool _readyPlayer2 = false;

    int _numberOfPlayer = 0;

    //Game is ready when _numberOfPlayer reached min number
    bool _readyToStart = false;

    //For tracking game state
    public GameState _gameState = GameState.INGAME;

    //Build mode
    public BuildMode currentBuildMode = BuildMode.DEV;

    #region MonoBehaviour Callbacks

    private void Awake()
    {
        if (!textPlayer1)
        {
            LogHelper.LogError("Player 1 text not found");

        }

        if (!textPlayer2)
        {
            LogHelper.LogError("Player 2 text not found");

        }

        if (!textReadyToStart)
        {
            LogHelper.LogError("Ready to start text not found");

        }

        DontDestroyOnLoad(this);
    }

    private void FixedUpdate()
    {
        switch (_gameState)
        {
            case GameState.WAITING:
                this.ProcessPreStartInput();
                break;

            case GameState.INGAME:
                break;

            case GameState.OVER:
                break;

            default:
                break;
        }

    }

    #endregion

    #region Private Methods
    private void ProcessPreStartInput()
    {
        if (Input.GetKeyDown(MenuKeyCode.KEY_CODE_JOIN_1))
        {
            if (!_readyPlayer1)
            {
                _numberOfPlayer++;
                _readyPlayer1 = true;
                textPlayer1.text = GameConst.TEXT_READY_PLAYER_1;
            }
            else
            {
                _numberOfPlayer--;
                _readyPlayer1 = false;
                textPlayer1.text = GameConst.TEXT_NOTREADY_PLAYER_1;
            }

            this.NumberOfReadyPlayerDidChange();

        }

        if (Input.GetKeyDown(MenuKeyCode.KEY_CODE_JOIN_2))
        {
            if (!_readyPlayer2)
            {
                _numberOfPlayer++;
                _readyPlayer2 = true;
                textPlayer2.text = GameConst.TEXT_READY_PLAYER_2;
            }
            else
            {
                _numberOfPlayer--;
                _readyPlayer2 = false;
                textPlayer2.text = GameConst.TEXT_NOTREADY_PLAYER_2;
            }

            this.NumberOfReadyPlayerDidChange();
        }

        if (_readyToStart && Input.GetKeyDown(MenuKeyCode.KEY_CODE_START))
        {
            if (this.currentBuildMode == BuildMode.DEBUG)
            {
            }
            else if (this.currentBuildMode == BuildMode.DEV)
            {
                GameStateDidChange(GameState.INGAME);
                LevelUtils.StartLevel(GameScene.SCENE_PROTOTYPE);
            }
            else if (this.currentBuildMode == BuildMode.RELEASE)
            {
            }

        }


    }

    private void GameStateDidChange(GameState state)
    {
        _gameState = state;
    }

    private void NumberOfReadyPlayerDidChange()
    {
        _readyToStart = _numberOfPlayer >= GameConst.GAME_MIN_PLAYERS ? true : false;
        if (_readyToStart)
        {
            if (textReadyToStart.IsActive())
            {
                return;
            }
            textReadyToStart.gameObject.SetActive(true);
        }
        else
        {
            if (!textReadyToStart.IsActive())
            {
                return;
            }
            textReadyToStart.gameObject.SetActive(false);

        }
    }

    #endregion

    #region Public Methods

    public void HandlePlayerOxygenRunOut(GameObject o)
    {
        //TODO: handle deactive object
    }

    #endregion


}
