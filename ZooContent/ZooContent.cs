﻿using System;
using System.Collections.Generic;

namespace Zoo
{
    /// <summary>
    /// Описывает Любое имущество Зоопарка
    /// </summary>
    public abstract class ZooContent : IZooContent
    {
        public ZooContent()
        {
        }

        protected ZooContent(string name, string from, float cost)
        {
            Name = name;
            From = from;
            Cost = cost;
        }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// От куда родом
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public float Cost { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ZooContent content &&
                   Name == content.Name &&
                   From == content.From &&
                   Cost == content.Cost;
        }

        public override int GetHashCode()
        {
            var hashCode = -1231080549;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Name} из {From} стоимостью: {Cost}";
        }
    }
}
