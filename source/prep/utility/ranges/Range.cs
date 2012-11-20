using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.utility.ranges
{
	public class Range<T> : IContainValues<T> where T : IComparable<T>
	{
		public bool IncludesStart { get; set; }
		public T StartOfRange { get; set; }
		public bool IncludesEnd { get; set; }
		public T EndOfRange { get; set; }

		public Range(T min, T max)
		{
			this.IncludesStart = true;
			this.StartOfRange = min;
			this.IncludesEnd = true;
			this.EndOfRange = max;
		}

		public bool contains(T item)
		{
			if((this.IncludesStart) && (this.IncludesEnd))
				return (item.CompareTo(this.StartOfRange) >= 0 && item.CompareTo(this.EndOfRange) <= 0);
			else if ((this.IncludesStart) && (!this.IncludesEnd))
				return (item.CompareTo(this.StartOfRange) >= 0 && item.CompareTo(this.EndOfRange) < 0);
			else if ((!this.IncludesStart) && (this.IncludesEnd))
				return (item.CompareTo(this.StartOfRange) > 0 && item.CompareTo(this.EndOfRange) <= 0);
			else
				return (item.CompareTo(this.StartOfRange) > 0 && item.CompareTo(this.EndOfRange) < 0);
			
		}
	}
}
