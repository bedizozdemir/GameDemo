using GameDemo.Entity;

namespace GameDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {

        public virtual void Add(Player player);
        public void Delete(Player player);
        public void Update(Player player);
    }
}