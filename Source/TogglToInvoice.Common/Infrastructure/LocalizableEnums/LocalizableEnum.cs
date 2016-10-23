// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocalizableEnum.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure.LocalizableEnums
{
    public class LocalizableEnum<T>
        where T : struct
    {
        public string Text { get; set; }

        public T Value { get; set; }
    }
}