using System.Collections.Generic;
using UnityEngine;

namespace _Script
{
    public class InputHandler : MonoBehaviour
    {

        public GameObject model;
        public float walkSpeed;
        public float runSpeed;
        private Animator _modelAnimator;
        private Command _runCommand;
        private Command _punchCommand;
        private Command _idleCommand;
        private Command _danceCommand;
        private Command _walkCommand;
        private bool _inReverse = false;
        private List<Command> _commandList;


        private void Start()
        {
            _modelAnimator = model.GetComponent<Animator>();
            _commandList = new List<Command>();
            _runCommand = new PerformRunning();
            _punchCommand = new PerformPunch();
            _idleCommand = new Idle();
            _danceCommand = new PerformDancing();
            _walkCommand = new PerformWalking();
        }

        private void Update()
        {
            TakeAction();
            Reverse();

        }

        private void Reverse()
        {
            if (!Input.GetKeyDown(KeyCode.R)) return;
            if (_inReverse != false) return;
            if (_commandList.Count < 0) return;
            _inReverse = true;
            var count = _commandList.Count - 1;
            for (var i = count ; i >= 0; i--)
            {
               _commandList[i].Revert(_modelAnimator);
               _commandList.RemoveAt(i);
            }

            _inReverse = false;
        }


        private void TakeAction()
        {
            if(_inReverse) return;

            if (Input.GetKeyDown(KeyCode.Space))
            {

                _runCommand.Execute(_modelAnimator);
                _commandList.Add(_runCommand);
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                _punchCommand.Execute(_modelAnimator);
                _commandList.Add(_punchCommand);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                _danceCommand.Execute(_modelAnimator);
                _commandList.Add(_danceCommand);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                _walkCommand.Execute(_modelAnimator);
                _commandList.Add(_walkCommand);
            }
        }
    }
}
