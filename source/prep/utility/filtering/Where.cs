using System;
using System.Collections.Generic;

namespace prep.utility.filtering
{
  public class Where<ItemToFilter>
  {
    public static MatchFactory<ItemToFilter, PropertyType> has_a<PropertyType>(
      PropertyAccessor<ItemToFilter, PropertyType> accessor)
    {
      return new MatchFactory<ItemToFilter, PropertyType>(accessor);
    }
  }

  public class MatchFactory<Item, PropertyType>
  {
    PropertyAccessor<Item, PropertyType> accessor;

    public MatchFactory(PropertyAccessor<Item, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<Item> equal_to(PropertyType value)
    {
      return equal_to_any(value);
    }

    public IMatchAn<Item> equal_to_any(params PropertyType[] values)
    {
      return new DynamicCondition<Item>(x => new List<PropertyType>(values).Contains(accessor(x)));
    }

    public IMatchAn<Item> not_equal_to(PropertyType value)
    {
      throw new NotImplementedException();
    }
  }
}