using pcs.Components.IAI;

namespace pcs.Components.Interfaces
{
    public interface ITickable
    {
        /// <summary>
        /// Performs on every tick. Tick - 0.1 of second (100 ms)
        /// </summary>
        /// <param name="stack">Ticked ItemStack</param>
        /// <param name="tickNumber">Tick number in second</param>
        void OnTick(ItemStack stack, byte tickNumber);

        /// <summary>
        /// Can this object tick async?
        /// </summary>
        /// <returns></returns>
        bool IsAsync();
    }
}
