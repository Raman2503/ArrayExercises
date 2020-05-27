using System;
using System.Collections;
using System.Collections.Generic;

namespace SortArray
{
	internal class Address : IComparable<Address>, IEquatable<Address>
	{
		public string Street { get; set; }

		public int Number { get; set; }

		public Address (string street, int number)
		{
			Street = street;
			Number = number;
		}


		public int CompareTo(Address other)
		{
			// Am Bahnhof Westend 13, Rotherstraße 20
			var compareResultStreet = this.Street.CompareTo(other.Street);
			if (compareResultStreet != 0)
				return compareResultStreet;

			return Number.CompareTo(other.Number);
		}

		public bool Equals(Address other)
		{
			throw new NotImplementedException();
		}
	}

	internal class CompareByStreetComparer : IComparer<Address>
	{
		public int Compare(Address a1, Address a2)
		{
			var address1 = a1.Street;
			return 0;
		}
	}
}
