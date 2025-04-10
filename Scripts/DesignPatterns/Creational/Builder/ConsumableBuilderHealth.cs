// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public class ConsumableBuilderHealth<Template1> : ConsumableBuilderWeight<ConsumableBuilderHealth<Template1>> where Template1 : ConsumableBuilderHealth<Template1>
    {
        protected ConsumableBuilderHealth() : base()
        {

        }

        public Template1 SetConsumableBuilderHealthInput(in ConsumableEffect consumableBuilderHealthInput)
        {
            if (ConsumableBuilderSourceInstance is null)
            {
                StringBuilder consumableBuilderHealthStringBuilder = new();

                consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
                consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderHealthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
                consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderHealthStringBuilder.ToString(), innerException: new Exception());
            }

            if (!Enum.IsDefined(value: consumableBuilderHealthInput))
            {
                ConsumableBuilderSourceInstance.SetConsumableComponentHealth(consumableComponentHealth: ConsumableEffect.ConsumableEffectUndefined);
            }
            else
            {
                ConsumableBuilderSourceInstance.SetConsumableComponentHealth(consumableComponentHealth: consumableBuilderHealthInput);
            }

            return (Template1)this;
        }

        public override bool Equals(object? uncastedConsumableBuilderHealth)
        {
            StringBuilder consumableBuilderHealthStringBuilder = new();

            consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderHealthStringBuilder = new();

            consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderHealthStringBuilder = new();

            consumableBuilderHealthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderHealth<Template1>)}[START]");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderHealth<Template1>)}' class");
            consumableBuilderHealthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderHealthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderHealth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderHealthStringBuilder.ToString(), inner: new Exception());
        }
    }
}