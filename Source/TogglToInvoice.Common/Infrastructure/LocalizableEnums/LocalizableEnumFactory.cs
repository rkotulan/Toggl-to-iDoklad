// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocalizableEnumFactory.cs" company="Rudolf Kotulán">
//   Copyright © Rudolf Kotulán All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TogglToInvoice.Common.Infrastructure.LocalizableEnums
{
    using System;
    using System.Collections.Generic;
    using System.Resources;

    public class LocalizableEnumFactory : ILocalizableEnumFactory
    {
        private readonly ResourceManager resource;

        public LocalizableEnumFactory()
        {
            this.resource = new ResourceManager(typeof(Resources.Language));
        }

        public IList<LocalizableEnum<T>> CreateList<T>() where T : struct
        {
            var result = new List<LocalizableEnum<T>>();
            var enumItems = Enum.GetValues(typeof(T));

            foreach (var enumItem in enumItems)
            {
                var item = new LocalizableEnum<T>();
                item.Value = (T)enumItem;
                item.Text = this.GetEnumDescription<T>(enumItem);
                result.Add(item);
            }

            return result;
        }

        private string GetEnumDescription<T>(object enumItem)
        {
            var key = "{0}_{1}";
            key = string.Format(key, typeof(T).Name, enumItem);
            return this.resource.GetString(key);
        }
    }
}