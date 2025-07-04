﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class ConsumableFilterHealth : FilterComponent<ConsumableComponent, ConsumableFilterVisitor>
    {
        private ConsumableEffect ConsumableFilterHealthField { get; }

        public ConsumableFilterHealth(in ConsumableEffect consumableFilterHealthField) : base()
        {
            if (!Enum.IsDefined(value: consumableFilterHealthField))
            {
                ConsumableFilterHealthField = ConsumableEffect.ConsumableEffectUndefined;
            }
            else
            {
                ConsumableFilterHealthField = consumableFilterHealthField;
            }
        }

        public override bool CheckFilterComponentField(in ConsumableComponent consumableFilterHealthInput)
        {
            if (consumableFilterHealthInput is null)
            {
                StringBuilder consumableFilterHealthStringBuilder = new();

                consumableFilterHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHealth)}[START]");
                consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterHealthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterHealth)}' class");
                consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHealth)}[END]");

                throw new InvalidOperationException(message: consumableFilterHealthStringBuilder.ToString(), innerException: new Exception());
            }

            return EqualityComparer<ConsumableEffect>.Default.Equals(x: ConsumableFilterHealthField, y: consumableFilterHealthInput.ConsumableComponentHealth);
        }

        public override void AcceptFilterComponent(in ConsumableFilterVisitor consumableFilterHealthVisitor)
        {
            if (consumableFilterHealthVisitor is null)
            {
                StringBuilder consumableFilterHealthStringBuilder = new();

                consumableFilterHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHealth)}[START]");
                consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterHealthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterHealth)}' class");
                consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
                consumableFilterHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHealth)}[END]");

                throw new InvalidOperationException(message: consumableFilterHealthStringBuilder.ToString(), innerException: new Exception());
            }

            consumableFilterHealthVisitor.ExecuteFilterVisitorOperation(consumableFilterVisitorElement: this);
        }

        public override bool Equals(object? uncastedConsumableFilterHealth)
        {
            StringBuilder consumableFilterHealthStringBuilder = new();

            consumableFilterHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHealth)}[START]");
            consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterHealth)}' class");
            consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHealth)}[END]");

            throw new NotImplementedException(message: consumableFilterHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterHealthStringBuilder = new();

            consumableFilterHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHealth)}[START]");
            consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterHealth)}' class");
            consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHealth)}[END]");

            throw new NotImplementedException(message: consumableFilterHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterHealthStringBuilder = new();

            consumableFilterHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterHealth)}[START]");
            consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterHealth)}' class");
            consumableFilterHealthStringBuilder.AppendLine(value: string.Empty);
            consumableFilterHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterHealth)}[END]");

            throw new NotImplementedException(message: consumableFilterHealthStringBuilder.ToString(), inner: new Exception());
        }
    }
}