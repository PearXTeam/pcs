using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace pcs.Components
{
    public class Item
    {
        public static ObjectData Data = new ObjectData();

        /// <summary>
        /// The name of the Item
        /// </summary>
        /// <returns></returns>
        public virtual string Name()
        {
            return "Undefined";
        }

        /// <summary>
        /// The ID of the Item
        /// </summary>
        /// <returns></returns>
        public virtual string ID()
        {
            return "PCS_UndefinedItem";
        }

        /// <summary>
        /// The sub-ID of the Item. You can use this for Item colors and other stuff.
        /// </summary>
        /// <returns></returns>
        public virtual string SubID()
        {
            return "";
        }

        /// <summary>
        /// The 64x64 item's icon
        /// </summary>
        /// <returns></returns>
        public virtual Image Icon()
        {
            return PCSImages.MissingIcon;
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        /// <returns></returns>
        public virtual string Description()
        {
            return "";
        }

    }
}
