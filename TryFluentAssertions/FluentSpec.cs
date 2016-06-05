using System;
using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace TryFluentAssertions {
	public class FluentSpec {
		public FluentSpec() {
		}

		[Test]
		public void StartWith() {
			var actual = "ABCDEFG";
			actual.Should().StartWith("ABC");
		}

		[Test]
		public void HaveCount() {
			var x = new int[1, 2, 3];
			x.Should().HaveCount(6);
		}

		[Test]
		public void HaveLength() {
			var x = new int[1, 2, 3];
			x.Length.Should().Equals(3);
		}

		[Test]
		public void BeOfType() {
			var x = "Hello, world";
			x.Should().BeOfType<String>();
		}
	}
}

