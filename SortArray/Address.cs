using System;
using System.Collections.Generic;

namespace SortArray
{
	internal class Address : IComparable<Address>, IEquatable<Address>
	{
		public string Street { get; set; }

		public int Number { get; set; }

		public Address(string street, int number)
		{
			Street = street;
			Number = number;
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
			if (this.Street == other.Street)
			{
				return true;
			}

			else
			{
				return false;
			}
		}
	}

	internal class CompareByStreetComparer : IComparer<Address>
	{
		public int Compare(Address a1, Address a2)
		{
			if (a2.Street != null && a1.Street != null)
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
