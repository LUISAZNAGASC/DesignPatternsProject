﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Command
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandWeight : CommandComponent<ConsumableComponent>
    {
        private ProductWeight ConsumableCommandWeightUndoValue { get; }

        private ProductWeight ConsumableCommandWeightRedoValue { get; }

        public ConsumableCommandWeight(in ConsumableComponent consumableCommandWeightReference, in ProductWeight consumableCommandWeightRedoValue) : base(commandComponentReference: consumableCommandWeightReference)
        {
            if (consumableCommandWeightReference is null)
            {
                StringBuilder consumableCommandWeightStringBuilder = new();

                consumableCommandWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWeight)}[START]");
                consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandWeight)}' class");
                consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWeight)}[END]");

                throw new InvalidOperationException(message: consumableCommandWeightStringBuilder.ToString(), innerException: new Exception());
            }

            ConsumableCommandWeightUndoValue = consumableCommandWeightReference.ProductComponentWeight;

            if (!Enum.IsDefined(value: consumableCommandWeightRedoValue))
            {
                ConsumableCommandWeightRedoValue = ProductWeight.ProductWeightUndefined;
            }
            else
            {
                ConsumableCommandWeightRedoValue = consumableCommandWeightRedoValue;
            }
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandWeightStringBuilder = new();

                consumableCommandWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWeight)}[START]");
                consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandWeight)}' class");
                consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWeight)}[END]");

                throw new InvalidOperationException(message: consumableCommandWeightStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentWeight(productComponentWeight: ConsumableCommandWeightUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandWeightStringBuilder = new();

                consumableCommandWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWeight)}[START]");
                consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWeightStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandWeight)}' class");
                consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
                consumableCommandWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWeight)}[END]");

                throw new InvalidOperationException(message: consumableCommandWeightStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentWeight(productComponentWeight: ConsumableCommandWeightRedoValue);
        }

        public override bool Equals(object? uncastedConsumableCommandWeight)
        {
            StringBuilder consumableCommandWeightStringBuilder = new();

            consumableCommandWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWeight)}[START]");
            consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandWeight)}' class");
            consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWeight)}[END]");

            throw new NotImplementedException(message: consumableCommandWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandWeightStringBuilder = new();

            consumableCommandWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWeight)}[START]");
            consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandWeight)}' class");
            consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWeight)}[END]");

            throw new NotImplementedException(message: consumableCommandWeightStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandWeightStringBuilder = new();

            consumableCommandWeightStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandWeight)}[START]");
            consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWeightStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandWeight)}' class");
            consumableCommandWeightStringBuilder.AppendLine(value: string.Empty);
            consumableCommandWeightStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandWeight)}[END]");

            throw new NotImplementedException(message: consumableCommandWeightStringBuilder.ToString(), inner: new Exception());
        }
    }
}