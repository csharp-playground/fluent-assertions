using System;
using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace TryFluentAssertions {
	public class FluentSpec {
		public FluentSpec() {
		}

		[Test]
		public void BeAfter() {
			DateTime.Now.Should().BeAfter(1.February(2000));
			new DateTime(2222, 1, 1).Should().HaveDay(1).And.HaveMonth(1).And.HaveYear(2222);
		}

		[Test]
		public void BeGreaterThan() {
			(100).Should().BeGreaterThan(50);
		}

		[Test]
		public void Match() {
			"wk@gmail.com".Should().Match("*@*");
		}

		[Test]
		public void NotNull() {
			"".Should().NotBeNull();

			string x = null;
			x.Should().BeNull();
		}

		[Test]
		public void BeFalse() {
			var x = false;
			x.Should().BeFalse();
			(!x).Should().BeTrue();
		}

		[Test]
		public void NotHaveValue() {
			DateTime? date = null;
			date.Should().NotHaveValue();

			date = DateTime.Now;
			date.Should().HaveValue();
		}

		[Test]
		public void NotBe() {
			var x = 100;
			x.Should().NotBe(101);
		}

		[Test]
		public void Be() {
			var x = 100;
			x.Should().Be(100);
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

