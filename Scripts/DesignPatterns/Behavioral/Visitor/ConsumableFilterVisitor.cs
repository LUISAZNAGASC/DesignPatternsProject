// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public sealed class ConsumableFilterVisitor : FilterVisitor<ConsumableComponent, ConsumableFilterVisitor>
    {
        public ConsumableFilterVisitor(in ConsumableComponent consumableFilterVisitorReference) : base(filterVisitorReference: consumableFilterVisitorReference)
        {
            if (consumableFilterVisitorReference is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }
        }

        public void ExecuteFilterVisitorOperation(in ConsumableFilterWidth consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (!consumableFilterVisitorElement.CheckFilterComponentField(consumableFilterWidthInput: FilterVisitorReference))
            {
                FilterVisitorExpression.Append(value: FilterVisitorNegativeExpression);
            }
            else
            {
                FilterVisitorExpression.Append(value: FilterVisitorPositiveExpression);
            }
        }

        public void ExecuteFilterVisitorOperation(in ConsumableFilterHeight consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (!consumableFilterVisitorElement.CheckFilterComponentField(consumableFilterHeightInput: FilterVisitorReference))
            {
                FilterVisitorExpression.Append(value: FilterVisitorNegativeExpression);
            }
            else
            {
                FilterVisitorExpression.Append(value: FilterVisitorPositiveExpression);
            }
        }

        public void ExecuteFilterVisitorOperation(in ConsumableFilterDepth consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (!consumableFilterVisitorElement.CheckFilterComponentField(consumableFilterDepthInput: FilterVisitorReference))
            {
                FilterVisitorExpression.Append(value: FilterVisitorNegativeExpression);
            }
            else
            {
                FilterVisitorExpression.Append(value: FilterVisitorPositiveExpression);
            }
        }

        public void ExecuteFilterVisitorOperation(in ConsumableFilterWeight consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (!consumableFilterVisitorElement.CheckFilterComponentField(consumableFilterWeightInput: FilterVisitorReference))
            {
                FilterVisitorExpression.Append(value: FilterVisitorNegativeExpression);
            }
            else
            {
                FilterVisitorExpression.Append(value: FilterVisitorPositiveExpression);
            }
        }

        public void ExecuteFilterVisitorOperation(in ConsumableFilterHealth consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (!consumableFilterVisitorElement.CheckFilterComponentField(consumableFilterHealthInput: FilterVisitorReference))
            {
                FilterVisitorExpression.Append(value: FilterVisitorNegativeExpression);
            }
            else
            {
                FilterVisitorExpression.Append(value: FilterVisitorPositiveExpression);
            }
        }

        public void ExecuteFilterVisitorOperation(in ConsumableFilterDamage consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (!consumableFilterVisitorElement.CheckFilterComponentField(consumableFilterDamageInput: FilterVisitorReference))
            {
                FilterVisitorExpression.Append(value: FilterVisitorNegativeExpression);
            }
            else
            {
                FilterVisitorExpression.Append(value: FilterVisitorPositiveExpression);
            }
        }

        public override void ExecuteFilterVisitorOperation(in FilterComponent<ConsumableComponent, ConsumableFilterVisitor> consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            consumableFilterVisitorElement.AcceptFilterComponent(filterComponentVisitor: this);
        }

        public override void ExecuteFilterVisitorOperation(in IdentityFilter<ConsumableComponent, ConsumableFilterVisitor> consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null || consumableFilterVisitorElement.IdentityFilterUnary is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            FilterVisitorExpression.Append(value: FilterVisitorIdentityExpression);

            consumableFilterVisitorElement.IdentityFilterUnary.AcceptFilterComponent(filterComponentVisitor: this);
        }

        public override void ExecuteFilterVisitorOperation(in NegationFilter<ConsumableComponent, ConsumableFilterVisitor> consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null || consumableFilterVisitorElement.NegationFilterUnary is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            FilterVisitorExpression.Append(value: FilterVisitorNegationExpression);

            consumableFilterVisitorElement.NegationFilterUnary.AcceptFilterComponent(filterComponentVisitor: this);
        }

        public override void ExecuteFilterVisitorOperation(in ConjunctionFilter<ConsumableComponent, ConsumableFilterVisitor> consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null || consumableFilterVisitorElement.ConjunctionFilterLeft is null || consumableFilterVisitorElement.ConjunctionFilterRight is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            FilterVisitorExpression.Append(value: FilterVisitorOpeningParenthesisExpression);

            consumableFilterVisitorElement.ConjunctionFilterLeft.AcceptFilterComponent(filterComponentVisitor: this);

            FilterVisitorExpression.Append(value: FilterVisitorConjunctionExpression);

            consumableFilterVisitorElement.ConjunctionFilterRight.AcceptFilterComponent(filterComponentVisitor: this);

            FilterVisitorExpression.Append(value: FilterVisitorClosingParenthesisExpression);
        }

        public override void ExecuteFilterVisitorOperation(in DisjunctionFilter<ConsumableComponent, ConsumableFilterVisitor> consumableFilterVisitorElement)
        {
            if (FilterVisitorReference is null || FilterVisitorExpression is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            if (consumableFilterVisitorElement is null || consumableFilterVisitorElement.DisjunctionFilterLeft is null || consumableFilterVisitorElement.DisjunctionFilterRight is null)
            {
                StringBuilder consumableFilterVisitorStringBuilder = new();

                consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(ConsumableFilterVisitor)}' class");
                consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
                consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

                throw new InvalidOperationException(message: consumableFilterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            FilterVisitorExpression.Append(value: FilterVisitorOpeningParenthesisExpression);

            consumableFilterVisitorElement.DisjunctionFilterLeft.AcceptFilterComponent(filterComponentVisitor: this);

            FilterVisitorExpression.Append(value: FilterVisitorDisjunctionExpression);

            consumableFilterVisitorElement.DisjunctionFilterRight.AcceptFilterComponent(filterComponentVisitor: this);

            FilterVisitorExpression.Append(value: FilterVisitorClosingParenthesisExpression);
        }

        public override bool Equals(object? uncastedConsumableFilterVisitor)
        {
            StringBuilder consumableFilterVisitorStringBuilder = new();

            consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
            consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
            consumableFilterVisitorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterVisitor)}' class");
            consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
            consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

            throw new NotImplementedException(message: consumableFilterVisitorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableFilterVisitorStringBuilder = new();

            consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
            consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
            consumableFilterVisitorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterVisitor)}' class");
            consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
            consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

            throw new NotImplementedException(message: consumableFilterVisitorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableFilterVisitorStringBuilder = new();

            consumableFilterVisitorStringBuilder.Append(value: $"[START]{nameof(ConsumableFilterVisitor)}[START]");
            consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
            consumableFilterVisitorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableFilterVisitor)}' class");
            consumableFilterVisitorStringBuilder.AppendLine(value: string.Empty);
            consumableFilterVisitorStringBuilder.Append(value: $"[END]{nameof(ConsumableFilterVisitor)}[END]");

            throw new NotImplementedException(message: consumableFilterVisitorStringBuilder.ToString(), inner: new Exception());
        }
    }
}