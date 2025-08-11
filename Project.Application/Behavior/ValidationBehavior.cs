﻿using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Project.Application.Messaging;

namespace Project.Application.Behavior
{
	public sealed class ValidationBehavior<TRequest, TResponse> :
		IPipelineBehavior<TRequest, TResponse>
		where TRequest : class, ICommand<TResponse>
	{

		readonly IEnumerable<IValidator<TRequest>> _validators;

		public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
		{
			_validators = validators;
		}

		public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			if (!_validators.Any())
			{
				return await next();
			}

			var context = new ValidationContext<TRequest>(request);

			var errorList = _validators.Select(x => x.Validate(context))
										.SelectMany(x => x.Errors)
										.Where(x => x != null)
										.GroupBy(
												 x => x.PropertyName,
												 x => x.ErrorMessage, (propertyName, errorMessage) => new
												 {
													 Key = propertyName,
													 Values = errorMessage.Distinct().ToArray()
												 }).ToDictionary(x => x.Key, x => x.Values[0]);

			if (errorList.Any())
			{
				var errors = errorList.Select(x => new ValidationFailure
				{
					PropertyName = x.Value,
					ErrorCode = x.Key
				});
				throw new ValidationException(errors);
			}

			return await next();
		}
	}
}
