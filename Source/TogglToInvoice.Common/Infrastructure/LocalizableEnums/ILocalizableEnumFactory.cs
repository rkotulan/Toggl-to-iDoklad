// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocalizableEnumFactory.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure.LocalizableEnums
{
    using System.Collections.Generic;

    public interface ILocalizableEnumFactory
    {
        IList<LocalizableEnum<T>> CreateList<T>() where T : struct;
    }
}