using System;

namespace TheSlum.Items
{
    public abstract class GameObject
    {
        protected GameObject(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}
