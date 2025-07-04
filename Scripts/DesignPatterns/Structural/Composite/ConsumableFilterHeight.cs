﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Structural.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterHeight : FilterComponent<ConsumableComponent>
    {
        private ProductSize ConsumableFilterHeightField { get; }

        public ConsumableFilterHeight(in ProductSize consumableFilterHeightField) : base()
        {
            if (!Enum.IsDefined(value: consumableFilterHeightField))
            {
                ConsumableFilterHeightField = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ConsumableFilterHeightField = consumableFilterHeightField;
            }
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterHeightInput)
        {
            if (consumableFilterHeightInput is null)
            {
                StringBuilder consumableFilterHeightStringBuilder = new();

                consumableFilterHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHeight)}[START]");
                consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
                consumableFilterHeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterHeight)}' class");
                consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
                consumableFilterHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHeight)}[END]");

                throw new InvalidOperationException(message: consumableFilterHeightStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<ProductSize>.Default.Equals(x: ConsumableFilterHeightField, y: consumableFilterHeightInput.ProductComponentHeight);
        }

        public override bool Equals(object? uncastedConsumableFilterHeight)
        {
            StringBuilder consumableFilterHeightStringBuilder = new();

            consumableFilterHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHeight)}[START]");
            consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterHeight)}' class");
            consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHeight)}[END]");

            throw new NotImplementedException(message: consumableFilterHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterHeightStringBuilder = new();

            consumableFilterHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHeight)}[START]");
            consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterHeight)}' class");
            consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHeight)}[END]");

            throw new NotImplementedException(message: consumableFilterHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterHeightStringBuilder = new();

            consumableFilterHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHeight)}[START]");
            consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterHeight)}' class");
            consumableFilterHeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHeight)}[END]");

            throw new NotImplementedException(message: consumableFilterHeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}