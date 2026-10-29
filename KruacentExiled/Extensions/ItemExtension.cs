using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups;
using Exiled.CustomItems.API.Features;
using KruacentExiled.CustomItems.API.Features;

namespace KruacentExiled.Extensions
{
    public static class ItemExtensions
    {
        /// <summary>
        /// Gets the identifier of an <see cref="Item"/>.
        /// Returns the KECustomItem name if registered, otherwise returns item type name.
        /// </summary>
        /// <param name="item">The targeted item</param>
        /// <returns>The KECustomItem name or vanilla item type string, or an empty string if null</returns>
        public static string GetName(this Item item)
        {
            if (item == null)
                return string.Empty;

            if(CustomItem.TryGet(item, out CustomItem customItem))
            {
                return customItem.Name;
            }

            return item.Type.ToString();
        }

        /// <summary>
        /// Gets the identifier of an <see cref="Pickup"/>.
        /// Returns the KECustomItem name if registered, otherwise returns pickup type name.
        /// </summary>
        /// <param name="pickup">The targeted pickup</param>
        /// <returns>The KECustomItem name or vanilla pickup type string, or an empty string if null</returns>
        public static string GetName(this Pickup pickup)
        {
            if (pickup == null)
                return string.Empty;

            if (CustomItem.TryGet(pickup, out CustomItem customItem))
            {
                return customItem.Name;
            }

            return pickup.Type.ToString();
        }
    }
}