﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public class ConsumableBuilderWeight<Template1> : ConsumableBuilderDepth<ConsumableBuilderWeight<Template1>> where Template1 : ConsumableBuilderWeight<Template1>
    {
        protected ConsumableBuilderWeight() : base()
        {

        }

        public Template1 SetConsumableBuilderWeightInput(in ProductWeight consumableBuilderWeightInput)
        {
            if (ConsumableBuilderSourceInstance is null)
            {
                StringBuilder consumableBuilderWeightStringBuilder = new();

                consumableBuilderWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeight<Template1>)}[START]");
                consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderWeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderWeight<Template1>)}' class");
                consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeight<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderWeightStringBuilder.ToString(), innerException: new Exception());
            }

            if (!Enum.IsDefined(value: consumableBuilderWeightInput))
            {
                ConsumableBuilderSourceInstance.SetProductComponentWeight(productComponentWeight: ProductWeight.ProductWeightUndefined);
            }
            else
            {
                ConsumableBuilderSourceInstance.SetProductComponentWeight(productComponentWeight: consumableBuilderWeightInput);
            }

            return (Template1)this;
        }

        public override bool Equals(object? uncastedConsumableBuilderWeight)
        {
            StringBuilder consumableBuilderWeightStringBuilder = new();

            consumableBuilderWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeight<Template1>)}[START]");
            consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWeight<Template1>)}' class");
            consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderWeightStringBuilder = new();

            consumableBuilderWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeight<Template1>)}[START]");
            consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWeight<Template1>)}' class");
            consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderWeightStringBuilder = new();

            consumableBuilderWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWeight<Template1>)}[START]");
            consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWeight<Template1>)}' class");
            consumableBuilderWeightStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWeight<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}