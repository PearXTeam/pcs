using System;
using System.Drawing;
using System.Windows.Forms;
using pcs.Args;
using pcs.IAI;
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
        }

        public override string Tooltip(ItemStack stack)
        {
            return "" + "\n" + base.Tooltip(stack);
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
