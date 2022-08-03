using IGroceryStore.Shared.Abstraction.Exceptions;

namespace IGroceryStore.Shops.Core.Exceptions;

public class ShopConsumerException : GroceryConsumerException
{
    public ShopConsumerException(bool shouldBeRetried, Guid correlationId, string message) 
        : base(shouldBeRetried, correlationId, message)
    {
    }
}