// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterWeight : FilterComponent<ConsumableComponent, ConsumableFilterVisitor>
    {
        private ProductWeight ConsumableFilterWeightField { get; }

        public ConsumableFilterWeight(in ProductWeight consumableFilterWeightField) : base()
        {
            if (!Enum.IsDefined(value: consumableFilterWeightField))
            {
                ConsumableFilterWeightField = ProductWeight.ProductWeightUndefined;
            }
            else
            {
                ConsumableFilterWeightField = consumableFilterWeightField;
            }
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterWeightInput)
        {
            if (consumableFilterWeightInput is null)
            {
                StringBuilder consumableFilterWeightStringBuilder = new();

                consumableFilterWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWeight)}[START]");
                consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
                consumableFilterWeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterWeight)}' class");
                consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
                consumableFilterWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWeight)}[END]");

                throw new InvalidOperationException(message: consumableFilterWeightStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<ProductWeight>.Default.Equals(x: ConsumableFilterWeightField, y: consumableFilterWeightInput.ProductComponentWeight);
        }

        public override void AcceptFilterComponent(in ConsumableFilterVisitor consumableFilterWeightVisitor)
        {
            if (consumableFilterWeightVisitor is null)
            {
                StringBuilder consumableFilterWeightStringBuilder = new();

                consumableFilterWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWeight)}[START]");
                consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
                consumableFilterWeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterWeight)}' class");
                consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
                consumableFilterWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWeight)}[END]");

                throw new InvalidOperationException(message: consumableFilterWeightStringBuilder.ToString(), innerException: new Exception());
            }

            consumableFilterWeightVisitor.ExecuteFilterVisitorOperation(consumableFilterVisitorElement: this);
        }

        public override bool Equals(object? uncastedConsumableFilterWeight)
        {
            StringBuilder consumableFilterWeightStringBuilder = new();

            consumableFilterWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWeight)}[START]");
            consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterWeight)}' class");
            consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWeight)}[END]");

            throw new NotImplementedException(message: consumableFilterWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterWeightStringBuilder = new();

            consumableFilterWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWeight)}[START]");
            consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterWeight)}' class");
            consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWeight)}[END]");

            throw new NotImplementedException(message: consumableFilterWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterWeightStringBuilder = new();

            consumableFilterWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterWeight)}[START]");
            consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterWeight)}' class");
            consumableFilterWeightStringBuilder.AppendLine(value: string.Empty);
            consumableFilterWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterWeight)}[END]");

            throw new NotImplementedException(message: consumableFilterWeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}