using UnityEngine;

namespace DefaultNamespace
{
    internal class InputController : IExecute
    {
        
        private readonly PlayerShip _playerShip;
        private readonly GameController _gameController;

        public InputController(PlayerShip playerShip, GameController gameController)
        {
            _playerShip = playerShip;
            _gameController = gameController;
        }
        public void Execute()
        {
            if (Input.GetKeyDown(NameManager.SPACE))
            {
                
               _playerShip.Shoot();
            }
            //_playerShip.Move(Input.GetAxis(NameManager.HORIZONTAL),Input.GetAxis(NameManager.VERTICAL));
            if (Input.GetKeyDown(NameManager.A))
            {
                _playerShip.State = new MoveLeftState();
            }    
            if (Input.GetKeyDown(NameManager.D))
            {
                _playerShip.State = new MoveRightState();
            }
            if (Input.GetKeyDown(NameManager.S))
            {
                _playerShip.State = new IdleState();
            }
            if (Input.GetKeyDown(NameManager.X))
            {
                _gameController.changeScore(321312321312);
            }
            if (Input.GetKeyDown(NameManager.C))
            {
                _gameController.changeScore(3333);
            }
            if (Input.GetKeyDown(NameManager.V))
            {
                _gameController.changeScore(232);
            }
            _playerShip.Request();
        }
    }
}