﻿using System;
using Ninject;

namespace FluentValidation.Ninject
{
	public class NinjectValidatorFactory : ValidatorFactoryBase
	{
		public NinjectValidatorFactory(IKernel kernel)
		{
			Kernel = kernel;
		}

		public IKernel Kernel { get; set; }

		public override IValidator CreateInstance(Type validatorType)
		{
			return Kernel.Get(validatorType) as IValidator;
		}
	}
}
