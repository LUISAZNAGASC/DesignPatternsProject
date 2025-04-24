// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public class ConsumableBuilderWidth<Template1> : ConsumableBuilderSource<ConsumableBuilderWidth<Template1>> where Template1 : ConsumableBuilderWidth<Template1>
    {
        protected ConsumableBuilderWidth() : base()
        {

        }

        public Template1 SetConsumableBuilderWidthInput(in ProductSize consumableBuilderWidthInput)
        {
            if (ConsumableBuilderSourceInstance is null)
            {
                StringBuilder consumableBuilderWidthStringBuilder = new();

                consumableBuilderWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidth<Template1>)}[START]");
                consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderWidthStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableBuilderWidth<Template1>)}' class");
                consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
                consumableBuilderWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidth<Template1>)}[END]");

                throw new InvalidOperationException(message: consumableBuilderWidthStringBuilder.ToString(), innerException: new Exception());
            }

            if (!Enum.IsDefined(value: consumableBuilderWidthInput))
            {
                ConsumableBuilderSourceInstance.SetProductComponentWidth(productComponentWidth: ProductSize.ProductSizeUndefined);
            }
            else
            {
                ConsumableBuilderSourceInstance.SetProductComponentWidth(productComponentWidth: consumableBuilderWidthInput);
            }

            return (Template1)this;
        }

        public override bool Equals(object? uncastedConsumableBuilderWidth)
        {
            StringBuilder consumableBuilderWidthStringBuilder = new();

            consumableBuilderWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidth<Template1>)}[START]");
            consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWidth<Template1>)}' class");
            consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableBuilderWidthStringBuilder = new();

            consumableBuilderWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidth<Template1>)}[START]");
            consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWidth<Template1>)}' class");
            consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWidthStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableBuilderWidthStringBuilder = new();

            consumableBuilderWidthStringBuilder.Append(value: $"[START]{nameof(ConsumableBuilderWidth<Template1>)}[START]");
            consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableBuilderWidth<Template1>)}' class");
            consumableBuilderWidthStringBuilder.AppendLine(value: string.Empty);
            consumableBuilderWidthStringBuilder.Append(value: $"[END]{nameof(ConsumableBuilderWidth<Template1>)}[END]");

            throw new NotImplementedException(message: consumableBuilderWidthStringBuilder.ToString(), inner: new Exception());
        }
    }
}