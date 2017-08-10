using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace BaseElement
{
    public enum ShipType : int { TypeOxygen, TypeElectricity };

    public class Character : MonoBehaviour
    {
        public GameObject gameManager;

        private float _maxElectricity = CharacterAttr.CHARACTER_MAX_ELECTRICITY;
        private float _maxOxygen = CharacterAttr.CHARACTER_MAX_OXYGEN;

        private float _electricityConsumePerMove = CharacterAttr.CHARACTER_ELECTRICITY_CONSUME_PER_MOVE;
        private float _oxygenConsumePerSecond = CharacterAttr.CHARACTER_OXYGEN_CONSUME_PER_SECOND;

        private float _currentElectricity;
        private float _currentOxygen;

        private bool _isTetheringWithElectricityShip;
        private bool _isTetheringWithOxygenShip;

        private ShipType _type;

        
        // Use this for initialization
        private void Start()
        {
            SetCurrentElectricity(_maxElectricity);
            SetCurrentOxygen(_maxOxygen);

        }

        private void Update()
        {
            if (!_isTetheringWithOxygenShip && _type != ShipType.TypeOxygen)
            {
                ConsumeOxygen();
            }
        }

        private void FixedUpdate()
        {

        }

        private void ConsumeOxygen()
        {
            _currentOxygen -= _oxygenConsumePerSecond * Time.deltaTime;
            if (_currentOxygen < 0)
            {
                NotifyOxygenRunOut();
            }
        }

        protected void ConsumeElectricityPerMove()
        {
            if (!_isTetheringWithElectricityShip && this._type != ShipType.TypeElectricity)
            {
                _currentElectricity -= _electricityConsumePerMove;
            }
        }

        private void TetherWithOxygenShip()
        {
            if (this._type == ShipType.TypeOxygen)
            {
                return;
            }

            _isTetheringWithOxygenShip = true;
            _currentOxygen = _maxOxygen;
        }

        private void TetherWithElectricityShip()
        {
            if (this._type == ShipType.TypeElectricity)
            {
                return;
            }

            _isTetheringWithElectricityShip = true;
            _currentElectricity = _maxElectricity;
        }

        protected float GetCurrenOxygen()
        {
            return this._currentOxygen;
        }

        protected float GetCurrenElectricity()
        {
            return this._currentElectricity;
        }

        private void SetCurrentElectricity(float e)
        {
            this._currentElectricity = e;
        }

        private void SetCurrentOxygen(float o)
        {
            this._currentOxygen = o;
        }

        private void NotifyOxygenRunOut()
        {
            if (gameManager)
            {
                var observer = gameManager.GetComponent<ScriptGameManager>();
                observer.HandlePlayerOxygenRunOut(this.gameObject);
            }
        }
    }

}