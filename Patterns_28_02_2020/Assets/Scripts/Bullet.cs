using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class Bullet : Projectile
    {
        private float _lifeTime = 3f;
        public BulletPool BulletPool;

        public void OnEnable()
        {
            StartCoroutine(Return());
        }
       
        protected override void Move(float speed)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }

        private IEnumerator Return()
        {
            yield return new WaitForSeconds(_lifeTime);
            Destroy(gameObject);
            //BulletPool.returnBullet(this);
            
        }
    }
}