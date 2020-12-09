﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mim.Core.Tests
{
	[TestClass]
	public class ValidationTests
	{
		[TestMethod]
		public void ValidateSchema_FromAssembly_NormalCall()
		{
			var res = Mim.Validation.ValidateSchema(typeof(Mim.V6301.POCD_IN150001UK06), Properties.Resources.POCD_EX150001UK06_05);

			Assert.IsTrue(res.Status);
		}

		[TestMethod]
		public void ValidateSchema_FromFolder_NormalCall()
		{
			var res = Mim.Validation.ValidateSchema(@"D:\Repo\MimDms\Mim.V6301\Schema", "POCD_IN150001UK06", Properties.Resources.POCD_EX150001UK06_05);

			Assert.IsTrue(res.Status);
		}

		[TestMethod]
		public void ValidateCda_WithSchemaName_NormalCall()
		{
			var res = Mim.Validation.ValidateCda(typeof(Mim.V6301.POCD_MT150001UK06ClinicalDocument).Assembly, "POCD_MT150001UK06", Properties.Resources.POCD_EX150001UK06_05);

			Assert.IsTrue(res.Status);
		}
	}
}