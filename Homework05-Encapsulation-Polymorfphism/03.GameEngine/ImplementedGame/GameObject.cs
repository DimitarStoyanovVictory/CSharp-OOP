using System.CodeDom;

namespace GameEngine
{
    public abstract class GameObject
    {
        public GameObject(string id)
        {
            this.Id = id;
        }
        public string Id { get; set; }
    }
}
