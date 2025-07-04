﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Command
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandWidth : CommandComponent<ConsumableComponent>
    {
        private ProductSize ConsumableCommandWidthUndoValue { get; }

        private ProductSize ConsumableCommandWidthRedoValue { get; }

        public ConsumableCommandWidth(in ConsumableComponent consumableCommandWidthReference, in ProductSize consumableCommandWidthRedoValue) : base(commandComponentReference: consumableCommandWidthReference)
        {
            if (consumableCommandWidthReference is null)
            {
                StringBuilder consumableCommandWidthStringBuilder = new();

                consumableCommandWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWidth)}[START]");
                consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWidthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandWidth)}' class");
                consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWidth)}[END]");

                throw new InvalidOperationException(message: consumableCommandWidthStringBuilder.ToString(), innerException: new Exception());
            }

            ConsumableCommandWidthUndoValue = consumableCommandWidthReference.ProductComponentWidth;

            if (!Enum.IsDefined(value: consumableCommandWidthRedoValue))
            {
                ConsumableCommandWidthRedoValue = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ConsumableCommandWidthRedoValue = consumableCommandWidthRedoValue;
            }
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandWidthStringBuilder = new();

                consumableCommandWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWidth)}[START]");
                consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWidthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandWidth)}' class");
                consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWidth)}[END]");

                throw new InvalidOperationException(message: consumableCommandWidthStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentWidth(productComponentWidth: ConsumableCommandWidthUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandWidthStringBuilder = new();

                consumableCommandWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWidth)}[START]");
                consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWidthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandWidth)}' class");
                consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWidth)}[END]");

                throw new InvalidOperationException(message: consumableCommandWidthStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentWidth(productComponentWidth: ConsumableCommandWidthRedoValue);
        }

        public override bool Equals(object? uncastedConsumableCommandWidth)
        {
            StringBuilder consumableCommandWidthStringBuilder = new();

            consumableCommandWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWidth)}[START]");
            consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandWidth)}' class");
            consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWidth)}[END]");

            throw new NotImplementedException(message: consumableCommandWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandWidthStringBuilder = new();

            consumableCommandWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWidth)}[START]");
            consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandWidth)}' class");
            consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWidth)}[END]");

            throw new NotImplementedException(message: consumableCommandWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandWidthStringBuilder = new();

            consumableCommandWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWidth)}[START]");
            consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandWidth)}' class");
            consumableCommandWidthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWidth)}[END]");

            throw new NotImplementedException(message: consumableCommandWidthStringBuilder.ToString(), inner: new Exception());
        }
    }
}