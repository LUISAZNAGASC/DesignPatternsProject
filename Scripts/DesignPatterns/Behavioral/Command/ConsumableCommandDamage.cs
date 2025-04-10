// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Command
{
    using System;
    using System.Text;

    public sealed class ConsumableCommandDamage : CommandComponent<ConsumableComponent>
    {
        private ConsumableEffect ConsumableCommandDamageUndoValue { get; }

        private ConsumableEffect ConsumableCommandDamageRedoValue { get; }

        public ConsumableCommandDamage(in ConsumableComponent consumableCommandDamageReference, in ConsumableEffect consumableCommandDamageRedoValue) : base(commandComponentReference: consumableCommandDamageReference)
        {
            if (consumableCommandDamageReference is null)
            {
                StringBuilder consumableCommandDamageStringBuilder = new();

                consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDamage)}' class");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

                throw new InvalidOperationException(message: consumableCommandDamageStringBuilder.ToString(), innerException: new Exception());
            }

            ConsumableCommandDamageUndoValue = consumableCommandDamageReference.ConsumableComponentDamage;

            if (!Enum.IsDefined(value: consumableCommandDamageRedoValue))
            {
                ConsumableCommandDamageRedoValue = ConsumableEffect.ConsumableEffectUndefined;
            }
            else
            {
                ConsumableCommandDamageRedoValue = consumableCommandDamageRedoValue;
            }
        }

        public override void ExecuteCommandComponentUndoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandDamageStringBuilder = new();

                consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDamage)}' class");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

                throw new InvalidOperationException(message: consumableCommandDamageStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetConsumableComponentDamage(consumableComponentDamage: ConsumableCommandDamageUndoValue);
        }

        public override void ExecuteCommandComponentRedoOperation()
        {
            if (CommandComponentReference is null)
            {
                StringBuilder consumableCommandDamageStringBuilder = new();

                consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableCommandDamage)}' class");
                consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
                consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

                throw new InvalidOperationException(message: consumableCommandDamageStringBuilder.ToString(), innerException: new Exception());
            }

            CommandComponentReference.SetConsumableComponentDamage(consumableComponentDamage: ConsumableCommandDamageRedoValue);
        }

        public override bool Equals(object? uncastedConsumableCommandDamage)
        {
            StringBuilder consumableCommandDamageStringBuilder = new();

            consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDamage)}' class");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

            throw new NotImplementedException(message: consumableCommandDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableCommandDamageStringBuilder = new();

            consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDamage)}' class");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

            throw new NotImplementedException(message: consumableCommandDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableCommandDamageStringBuilder = new();

            consumableCommandDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableCommandDamage)}[START]");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableCommandDamage)}' class");
            consumableCommandDamageStringBuilder.AppendLine(value: string.Empty);
            consumableCommandDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableCommandDamage)}[END]");

            throw new NotImplementedException(message: consumableCommandDamageStringBuilder.ToString(), inner: new Exception());
        }
    }
}