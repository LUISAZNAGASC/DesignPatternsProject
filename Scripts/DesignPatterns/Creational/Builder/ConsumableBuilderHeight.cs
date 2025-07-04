﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public class ConsumableBuilderHeight<Template1> : ConsumableBuilderWidth<ConsumableBuilderHeight<Template1>> where Template1 : ConsumableBuilderHeight<Template1>
    {
        protected ConsumableBuilderHeight() : base()
        {

        }

        public Template1 SetConsumableBuilderHeightInput(in ProductSize consumableBuilderHeightInput)
        {
            if (ConsumableBuilderSourceInstance is null)
            {
                StringBuilder consumableBuilderHeightStringBuilder = new();

                consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
                consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderHeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
                consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderHeightStringBuilder.ToString(), innerException: new Exception());
            }

            if (!Enum.IsDefined(value: consumableBuilderHeightInput))
            {
                ConsumableBuilderSourceInstance.SetProductComponentHeight(productComponentHeight: ProductSize.ProductSizeUndefined);
            }
            else
            {
                ConsumableBuilderSourceInstance.SetProductComponentHeight(productComponentHeight: consumableBuilderHeightInput);
            }

            return (Template1)this;
        }

        public override bool Equals(object? uncastedConsumableBuilderHeight)
        {
            StringBuilder consumableBuilderHeightStringBuilder = new();

            consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderHeightStringBuilder = new();

            consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderHeightStringBuilder = new();

            consumableBuilderHeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHeight<Template1>)}[START]");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHeight<Template1>)}' class");
            consumableBuilderHeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}