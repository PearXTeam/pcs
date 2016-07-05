using System.Text;
using System.Windows.Forms;
using pcs.Args;
using pcs.Core;
using pcs.IAI;
using pcs.Init;
using pcs.Player;

namespace pcs.Items
{
    public class ItemFood : Item
    {
        private int _RestoreFood;
        private int _RestoreMood;
        private int _RestoreSleep;
        private int _RestoreHealth;

        public ItemFood() { }
        public ItemFood(FoodItemArgs args)
        {
            SetRestoreFood(args.RestoreFood);
            SetRestoreMood(args.RestoreMood);
            SetRestoreSleep(args.RestoreSleep);
            SetRestoreHealth(args.RestoreHealth);
            Prepare(args);
            UseEvent += OnUseEvent;
        }

        private void OnUseEvent(object sender, MouseButtons mouseButtons, ref ItemStack stack)
        {
            Stats.Food += RestoreFood(stack);
            Stats.Mood += RestoreMood(stack);
            Stats.Sleep += RestoreSleep(stack);
            Stats.Health += RestoreHealth(stack);
            PCS.PlaySound(PCSSounds.Eating);
            stack.StackCount--;
        }

        public override string Tooltip(ItemStack stack)
        {
            StringBuilder sb = new StringBuilder();

            int rfood = RestoreFood(stack);
            int rmood = RestoreMood(stack);
            int rsleep = RestoreSleep(stack);
            int rhealth = RestoreHealth(stack);

            string s = base.Tooltip(stack);
            if (!string.IsNullOrEmpty(s))
                sb.AppendLine(s);

            if (rfood != 0)
            {
                string pm = rfood > 0 ? "+" : "-";
                sb.AppendLine(pm + rfood + "🍗");
            }

            if (rmood != 0)
            {
                string pm = rmood > 0 ? "+" : "-";
                sb.AppendLine(pm + rmood + "☺");
            }

            if (rsleep != 0)
            {
                string pm = rsleep > 0 ? "+" : "-";
                sb.AppendLine(pm + rsleep + "💤");
            }

            if (rhealth != 0)
            {
                string pm = rhealth > 0 ? "+" : "-";
                sb.AppendLine(pm + rhealth + "➕");
            }
            return sb.ToString();
        }

        public int RestoreFood(ItemStack stack)
        {
            return _RestoreFood;
        }

        public int RestoreMood(ItemStack stack)
        {
            return _RestoreMood;
        }

        public int RestoreSleep(ItemStack stack)
        {
            return _RestoreSleep;
        }

        public int RestoreHealth(ItemStack stack)
        {
            return _RestoreHealth;
        }

        public virtual void SetRestoreFood(int i) { _RestoreFood = i; }
        public virtual void SetRestoreMood(int i) { _RestoreMood = i; }
        public virtual void SetRestoreSleep(int i) { _RestoreSleep = i; }
        public virtual void SetRestoreHealth(int i) { _RestoreHealth = i; }
    }
}
