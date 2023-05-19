using System;

namespace LootSort
{
    /// <summary>
    /// It implements IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        /// <summary>
        /// Compare loot based on type, value, and description
        /// Compare loot type in alphabetical order
        /// Compare loot value from most valuable to least valuable
        /// Compare loot description in alphabetical order
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Loot other)
        {
            if (other == null)
                return 1;

            int typeComparison = Kind.ToString().CompareTo(other.Kind.ToString());
            if (typeComparison != 0)
                return typeComparison;

            int valueComparison = other.Value.CompareTo(Value);
            if (valueComparison != 0)
                return valueComparison;

            return String.Compare(Description, other.Description, StringComparison.Ordinal);
        }
        /// <summary>
        /// Combine hash codes of loot type, description, and value
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Kind.GetHashCode();
                hash = hash * 23 + Description.GetHashCode();
                hash = hash * 23 + Value.GetHashCode();
                return hash;
            }
        }
        
    }
}