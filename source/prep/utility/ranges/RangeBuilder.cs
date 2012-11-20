using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prep.utility.ranges
{
	public class RangeBuilder<T> where T : IComparable<T>
	{
		Range<T> _range;

		public RangeBuilder(T min, T max)
		{
			_range = new Range<T>(min, max);
		}

		public RangeBuilder<T> less_than_or_equal_to(T value)
		{
			_range.IncludesEnd = true;
			_range.EndOfRange = value;
			return (this);
		}

		public RangeBuilder<T> greater_than_or_equal_to(T value)
		{
			_range.IncludesStart = true;
			_range.StartOfRange = value;
			return (this);
		}

		public RangeBuilder<T> less_than(T value)
		{
			_range.IncludesEnd = false;
			_range.EndOfRange = value;
			return (this);
		}

		public RangeBuilder<T> greater_than(T value)
		{
			_range.IncludesStart = false;
			_range.StartOfRange = value;
			return (this);
		}

		public Range<T> range()
		{
			return (_range);
		}
	}
}
