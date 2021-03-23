using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class BulletPool : IService
    {
        private readonly Stack<Bullet> _bullets = new Stack<Bullet>();
        private readonly GameObject _bulletPrefab;
        private readonly IProjectilesFactory _factory;
        private BulletData _bulletData; 

        public BulletPool(BulletData data)
        {
            _bulletData = data;
            _factory = new BulletFactory();
            
        }


        public void returnBullet(Bullet usedBullet)
        {
            _bullets.Push(usedBullet);
            usedBullet.gameObject.SetActive(false);
        }

        public Bullet receiveBullet()
        {
            Bullet _newBullet;
            if (_bullets.Count == 0 )
            {
                //_newBullet = Object.Instantiate(_bulletPrefab).AddComponent<Bullet>();
                _newBullet = (Bullet) _factory.Create(_bulletData);
            }
            else
            {
                _newBullet = _bullets.Pop();
            }
            
            _newBullet.gameObject.SetActive(true);
            
            return _newBullet;
        }
    }
}