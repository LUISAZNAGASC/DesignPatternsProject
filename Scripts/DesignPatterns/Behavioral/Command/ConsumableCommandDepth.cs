// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Command
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandDepth : CommandComponent<ConsumableComponent>
    {
        private ProductSize ConsumableCommandDepthUndoValue { get; }

        private ProductSize ConsumableCommandDepthRedoValue { get; }

        public ConsumableCommandDepth(in ConsumableComponent consumableCommandDepthReference, in ProductSize consumableCommandDepthRedoValue) : base(commandComponentReference: consumableCommandDepthReference)
        {
            if (consumableCommandDepthReference is null)
            {
                StringBuilder consumableCommandDepthStringBuilder = new();

                consumableCommandDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDepth)}[START]");
                consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDepthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDepth)}' class");
                consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDepth)}[END]");

                throw new InvalidOperationException(message: consumableCommandDepthStringBuilder.ToString(), innerException: new Exception());
            }

            ConsumableCommandDepthUndoValue = consumableCommandDepthReference.ProductComponentDepth;

            if (!Enum.IsDefined(value: consumableCommandDepthRedoValue))
            {
                ConsumableCommandDepthRedoValue = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ConsumableCommandDepthRedoValue = consumableCommandDepthRedoValue;
            }
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandDepthStringBuilder = new();

                consumableCommandDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDepth)}[START]");
                consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDepthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDepth)}' class");
                consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDepth)}[END]");

                throw new InvalidOperationException(message: consumableCommandDepthStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentDepth(productComponentDepth: ConsumableCommandDepthUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandDepthStringBuilder = new();

                consumableCommandDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDepth)}[START]");
                consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDepthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDepth)}' class");
                consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDepth)}[END]");

                throw new InvalidOperationException(message: consumableCommandDepthStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetProductComponentDepth(productComponentDepth: ConsumableCommandDepthRedoValue);
        }

        public override bool Equals(object? uncastedConsumableCommandDepth)
        {
            StringBuilder consumableCommandDepthStringBuilder = new();

            consumableCommandDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDepth)}[START]");
            consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDepth)}' class");
            consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDepth)}[END]");

            throw new NotImplementedException(message: consumableCommandDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandDepthStringBuilder = new();

            consumableCommandDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDepth)}[START]");
            consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDepth)}' class");
            consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDepth)}[END]");

            throw new NotImplementedException(message: consumableCommandDepthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandDepthStringBuilder = new();

            consumableCommandDepthStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDepth)}[START]");
            consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDepthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDepth)}' class");
            consumableCommandDepthStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDepthStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDepth)}[END]");

            throw new NotImplementedException(message: consumableCommandDepthStringBuilder.ToString(), inner: new Exception());
        }
    }
}