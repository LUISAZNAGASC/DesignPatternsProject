﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public class ConsumableBuilderDamage<Template1> : ConsumableBuilderHealth<ConsumableBuilderDamage<Template1>> where Template1 : ConsumableBuilderDamage<Template1>
    {
        protected ConsumableBuilderDamage() : base()
        {

        }

        public Template1 SetConsumableBuilderDamageInput(in ConsumableEffect consumableBuilderDamageInput)
        {
            if (ConsumableBuilderSourceInstance is null)
            {
                StringBuilder consumableBuilderDamageStringBuilder = new();

                consumableBuilderDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamage<Template1>)}[START]");
                consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderDamageStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderDamage<Template1>)}' class");
                consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamage<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderDamageStringBuilder.ToString(), innerException: new Exception());
            }

            if (!Enum.IsDefined(value: consumableBuilderDamageInput))
            {
                ConsumableBuilderSourceInstance.SetConsumableComponentDamage(consumableComponentDamage: ConsumableEffect.ConsumableEffectUndefined);
            }
            else
            {
                ConsumableBuilderSourceInstance.SetConsumableComponentDamage(consumableComponentDamage: consumableBuilderDamageInput);
            }

            return (Template1)this;
        }

        public override bool Equals(object? uncastedConsumableBuilderDamage)
        {
            StringBuilder consumableBuilderDamageStringBuilder = new();

            consumableBuilderDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamage<Template1>)}[START]");
            consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDamage<Template1>)}' class");
            consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamage<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderDamageStringBuilder = new();

            consumableBuilderDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamage<Template1>)}[START]");
            consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDamage<Template1>)}' class");
            consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamage<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDamageStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderDamageStringBuilder = new();

            consumableBuilderDamageStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderDamage<Template1>)}[START]");
            consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderDamage<Template1>)}' class");
            consumableBuilderDamageStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderDamageStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderDamage<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderDamageStringBuilder.ToString(), inner: new Exception());
        }
    }
}