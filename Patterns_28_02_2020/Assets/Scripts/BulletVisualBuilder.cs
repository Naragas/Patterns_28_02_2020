using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class BulletVisualBuilder : BulletBilder
    {
        public BulletVisualBuilder(GameObject gameObject) : base(gameObject) {}

        public BulletVisualBuilder Name(string name)
        {
            _gameObject.name = name;
            return this;
        }

        public BulletVisualBuilder Sprite(Sprite sprite)
        {
            var component = GetOrAddComponent<SpriteRenderer>();
            component.sprite = sprite;
            return this;
        }
    }
}