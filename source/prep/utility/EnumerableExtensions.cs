﻿using System.Collections.Generic;

namespace prep.utility
{
  public static class EnumerableExtensions
  {
    public static  IEnumerable<T> one_at_a_time<T>(this IEnumerable<T> items)
    {
      foreach (var item in items) yield return item;
    }

    public static IEnumerable<Item> all_items_matching<Item>(this IEnumerable<Item> items,
      Condition<Item> condition)
    {
      foreach (var item in items)
        if (condition(item)) yield return item;
    }
  }
}