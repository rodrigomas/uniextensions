﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;


namespace DifferentMethods.Extensions.Collections
{
    /// <summary>
    /// A UniqueList is like a normal List, but contains only unique items
    /// </summary>
    public class UniqueList<T> : List<T>
    {
        HashSet<T> itemSet = new HashSet<T>();

        public new void Add(T item)
        {
            if (!itemSet.Contains(item))
            {
                base.Add(item);
                itemSet.Add(item);
            }
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            itemSet.Remove(item);
        }

        public new bool Contains(T item)
        {
            return itemSet.Contains(item);
        }

        public new void Clear()
        {
            base.Clear();
            itemSet.Clear();
        }

    }
}