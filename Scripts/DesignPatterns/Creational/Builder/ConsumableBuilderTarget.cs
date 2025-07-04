﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public class ConsumableBuilderTarget<Template1> : ConsumableBuilderDamage<ConsumableBuilderTarget<Template1>> where Template1 : ConsumableBuilderTarget<Template1>
    {
        protected ConsumableBuilderTarget() : base()
        {

        }

        public override bool Equals(object? uncastedConsumableBuilderTarget)
        {
            StringBuilder consumableBuilderTargetStringBuilder = new();

            consumableBuilderTargetStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderTarget<Template1>)}[START]");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderTarget<Template1>)}' class");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderTarget<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderTargetStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderTargetStringBuilder = new();

            consumableBuilderTargetStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderTarget<Template1>)}[START]");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderTarget<Template1>)}' class");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderTarget<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderTargetStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderTargetStringBuilder = new();

            consumableBuilderTargetStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderTarget<Template1>)}[START]");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderTarget<Template1>)}' class");
            consumableBuilderTargetStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderTargetStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderTarget<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderTargetStringBuilder.ToString(), inner: new Exception());
        }
    }
}