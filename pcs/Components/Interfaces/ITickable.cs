using pcs.Components.IAI;

namespace pcs.Components.Interfaces
{
    public interface ITickable
    {
        /// <summary>
        /// Performs on every tick. Tick - 0.1 of second (100 ms)
        /// </summary>
        /// <param name="stack">Ticked ItemStack</param>
        /// <param name="ticksCount">Current Tick's number</param>
        void OnTick(ItemStack stack, byte ticksCount);
    }
}
