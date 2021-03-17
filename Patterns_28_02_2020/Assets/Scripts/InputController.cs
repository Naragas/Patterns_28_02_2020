using UnityEngine;

namespace DefaultNamespace
{
    public class InputController : IExecute
    {
        
        private readonly PlayerShip _playerShip;

        public InputController(PlayerShip playerShip)
        {
            _playerShip = playerShip;
        }
        public void Execute()
        {
            if (Input.GetKeyDown(NameManager.SPACE))
            {
                
               _playerShip.Shoot();
            }
            
            _playerShip.Move(Input.GetAxis(NameManager.HORIZONTAL),Input.GetAxis(NameManager.VERTICAL));
        }
    }
}