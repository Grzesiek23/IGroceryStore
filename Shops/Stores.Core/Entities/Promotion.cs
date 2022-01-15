﻿using IGroceryStore.Stores.Core.Common;

namespace IGroceryStore.Stores.Core.Entities;

public abstract class Promotion
{
    public Guid Id { get; set; }
    public abstract string Name { get; set; }
    public abstract string Description { get; set; }
    public abstract Store Store { get; set; }
    public abstract DateRange DateRange { get; set; }
    public abstract bool CheckIfPromotionIsApplicable();
    public abstract double CalculateFinalPrice();

}

public class AmountPromotion : Promotion
{
    public double MinimumPurchaseAmount { get; set; }

    public override string Name { get; set; }
    public override string Description { get; set; }
    public override Store Store { get; set; }
    public override DateRange DateRange { get; set; } 

    public override bool CheckIfPromotionIsApplicable()
    {
        throw new NotImplementedException();
    }

    public override double CalculateFinalPrice()
    {
        throw new NotImplementedException();
    }
}

public class PercentagePromotion : Promotion
{
    public double Discount { get; set; }

    public override string Name { get; set; }
    public override string Description { get; set; }
    public override Store Store { get; set; }
    public override DateRange DateRange { get; set; }

    public override bool CheckIfPromotionIsApplicable()
    {
        throw new NotImplementedException();
    }

    public override double CalculateFinalPrice()
    {
        throw new NotImplementedException();
    }
}

public class AppPromotion : Promotion
{
    public override string Name { get; set; }
    public override string Description { get; set; }
    public override Store Store { get; set; }
    public override DateRange DateRange { get; set; }
    public override bool CheckIfPromotionIsApplicable()
    {
        throw new NotImplementedException();
    }

    public override double CalculateFinalPrice()
    {
        throw new NotImplementedException();
    }
}