using UnityEngine;

namespace DefaultNamespace
{
    internal class BulletBilder
    {
        protected GameObject _gameObject;

        public BulletBilder() => _gameObject = new GameObject();
        protected BulletBilder(GameObject gameObject) => _gameObject = gameObject;
        
        public BulletVisualBuilder Visual => new BulletVisualBuilder(_gameObject);
        
        public BulletPhysicsBuilder Physics => new BulletPhysicsBuilder(_gameObject);
        
        public static implicit operator GameObject(BulletBilder builder)
        {
            return builder._gameObject;
        }
        
        protected T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}