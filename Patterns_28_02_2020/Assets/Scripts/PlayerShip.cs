using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    internal class PlayerShip: IMove,IRotation,IShooting, IPlayerShipAbility
    {
        private readonly IMove _moveSystem;
        private readonly IRotation _rotationSystem;
        private readonly ShootingSystem _shootingSystem;
        private List<IAbility> _abilities;
        public PlayerState State;
        public Vector2 _moveDirection;

        public float Speed => _moveSystem.Speed;
        public void Move(Vector2 dir)
        {
            _moveSystem.Move(dir);
        }

        public PlayerShip(IMove moveSystem, IRotation rotationSystem, ShootingSystem shootingSystem, List<IAbility> abilities, PlayerState _state)
        {
            State = _state;
            _moveSystem = moveSystem;
            _rotationSystem = rotationSystem;
            _shootingSystem = shootingSystem;
            _abilities = abilities;
        }
        /*public void Move(float horizontal, float vertical)
        {
            _moveSystem.Move(horizontal,vertical);
        }*/



        public void Request()
        {
            State.Move(this);
        } 

        public void Rotation(Vector3 direction)
        {
            _rotationSystem.Rotation(direction);
        }

        public void Shoot()
        {
            _shootingSystem.Shoot();
        }

        public IAbility this[int index] => _abilities[index];

        public string this[AbilityType index] {
            get
            {
                var ability = _abilities.FirstOrDefault(a => a.AbilityType == index);
                return ability == null ? "No Ability" : ability.ToString();
            }
        }

        public int MaxDamage => _abilities.Select(a => a.Damage).Max();
        public IEnumerable<IAbility> GetAbility()
        {
            foreach (IAbility ability in _abilities)
            {
                for (int i = 0; i < _abilities.Count; i++)
                {
                    yield return _abilities[i];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _abilities.Count; i++)
            {
                yield return _abilities[i];
            }
        }
    }
}