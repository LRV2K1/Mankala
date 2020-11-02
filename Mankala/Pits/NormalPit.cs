
namespace Mankala.Pits
{
    public class NormalPit : Pit
    {
        public NormalPit opposite;

        public NormalPit(int stones)
            : base(stones) { }

        public int takeStones()
        {
            int s = stones;
            stones = 0;
            return s;
        }
    }
}
