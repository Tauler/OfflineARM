﻿using OfflineARM.Business.Models.Businesses.Interfaces;
using OfflineARM.Business.Validators.Businesses.Interfaces;

namespace OfflineARM.Business.Validators.Businesses
{
    /// <summary>
    /// Валидатор Экспозиция
    /// </summary>
    public class ExpositionValidator : IExpositionValidator
    {
        #region IValidator

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public ValidationResult Validate(IExpositionModel element)
        {
            //if (string.IsNullOrEmpty(element.Name))
            //{
            //    return new ValidationResult(ValidatorResources.ExpositionValidator_NameIsNull);
            //}

            return new ValidationResult();
        }

        #endregion
    }
}