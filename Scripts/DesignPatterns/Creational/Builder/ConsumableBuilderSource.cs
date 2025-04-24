// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public abstract class ConsumableBuilderSource<Template1> where Template1 : ConsumableBuilderSource<Template1>
    {
        protected ConsumableComponent ConsumableBuilderSourceInstance { get; }

        protected ConsumableBuilderSource() : base()
        {
            ConsumableBuilderSourceInstance = new ConsumableComponent();
        }

        public ConsumableComponent GetConsumableBuilderSourceInstance()
        {
            if (ConsumableBuilderSourceInstance is null)
            {
                StringBuilder consumableBuilderSourceStringBuilder = new();

                consumableBuilderSourceStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderSource<Template1>)}[START]");
                consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderSourceStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderSource<Template1>)}' class");
                consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderSourceStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderSource<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderSourceStringBuilder.ToString(), innerException: new Exception());
            }

            return ConsumableBuilderSourceInstance;
        }

        public override bool Equals(object? uncastedConsumableBuilderSource)
        {
            StringBuilder consumableBuilderSourceStringBuilder = new();

            consumableBuilderSourceStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderSource<Template1>)}[START]");
            consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderSourceStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderSource<Template1>)}' class");
            consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderSourceStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderSource<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderSourceStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderSourceStringBuilder = new();

            consumableBuilderSourceStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderSource<Template1>)}[START]");
            consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderSourceStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderSource<Template1>)}' class");
            consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderSourceStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderSource<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderSourceStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderSourceStringBuilder = new();

            consumableBuilderSourceStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderSource<Template1>)}[START]");
            consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderSourceStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderSource<Template1>)}' class");
            consumableBuilderSourceStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderSourceStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderSource<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderSourceStringBuilder.ToString(), inner: new Exception());
        }
    }
}