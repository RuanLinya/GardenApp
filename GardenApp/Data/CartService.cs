using System;
using System.Collections.Generic;
using System.Linq;

namespace GardenApp.Data
{

    public class CartService
    {
        private readonly List<CartItem> _items = new();
        public event Action? OnChange;


        public int ItemCount => _items.Sum(i => i.Quantity);


        public IReadOnlyList<CartItem> Items => _items.AsReadOnly();

        public void AddToCart(Product product)
        {
            var item = _items.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (item == null)
            {
                _items.Add(new CartItem { Product = product, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }
            NotifyStateChanged();
        }

        public void RemoveFromCart(Product product)
        {
            var item = _items.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (item != null)
            {
                _items.Remove(item);
                NotifyStateChanged();
            }
        }

        public void IncrementQuantity(Product product)
        {
            var item = _items.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (item != null)
            {
                item.Quantity++;
                NotifyStateChanged();
            }
        }

        public void DecrementQuantity(Product product)
        {
            var item = _items.FirstOrDefault(ci => ci.Product.Id == product.Id);
            if (item != null)
            {
                item.Quantity--;
                if (item.Quantity <= 0)
                {
                    _items.Remove(item);
                }
                NotifyStateChanged();
            }
        }

        public decimal GetSubtotal()
        {
            return _items.Sum(ci => ci.Product.Price * ci.Quantity);
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}