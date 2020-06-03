using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
// ReSharper disable All

namespace SortingSearchingAlgorithms
{
	[SuppressMessage("ReSharper", "StringCompareToIsCultureSpecific")]
	internal class Address : IComparable<Address>, IEquatable<Address>
	{
		public string Street { get; }

		public int Number { get; }

		public Address(int a)
		{
				// Used for reflection
		}

		public Address(string street, int number)
		{
			Street = street;
			Number = number;
		}

		public override string ToString()
		{
			return $"{Street}, {Number}";
		}

		public int CompareTo(Address other)
		{
			var compareResultStreet = this.Street.CompareTo(other.Street);
			if (compareResultStreet != 0)
				return compareResultStreet;

			return Number.CompareTo(other.Number);
		}

		public bool Equals(Address other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Street == other.Street && Number == other.Number;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Address) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Street != null ? Street.GetHashCode() : 0) * 397) ^ Number;
			}
		}
		
	}

	internal class CompareByStreetComparer : IComparer<Address>
	{
		public int Compare(Address a1, Address a2)
		{
			if (a1 != null && (a2 != null && (a2.Street != null && a1.Street != null)))
				if (a1.Street.CompareTo(a2.Street) > 0)
				{
					return 1;
				}
				
				else if (a1.Street.CompareTo(a2.Street) < 0)
				{
					return -1;
				}

			return 0;
		}
	}
}
