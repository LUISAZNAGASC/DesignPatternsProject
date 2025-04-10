// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public sealed class ConjunctionFilter<Template1, Template2> : FilterComponent<Template1, Template2> where Template1 : class where Template2 : FilterVisitor<Template1, Template2>
    {
        public FilterComponent<Template1, Template2> ConjunctionFilterLeft { get; }

        public FilterComponent<Template1, Template2> ConjunctionFilterRight { get; }

        public ConjunctionFilter(in FilterComponent<Template1, Template2> conjunctionFilterLeft, in FilterComponent<Template1, Template2> conjunctionFilterRight) : base()
        {
            if (conjunctionFilterLeft is null || conjunctionFilterRight is null)
            {
                StringBuilder conjunctionFilterStringBuilder = new();

                conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: conjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            ConjunctionFilterLeft = conjunctionFilterLeft;

            ConjunctionFilterRight = conjunctionFilterRight;
        }

        public override bool CheckFilterComponentField(in Template1 conjunctionFilterInput)
        {
            if (ConjunctionFilterLeft is null || ConjunctionFilterRight is null)
            {
                StringBuilder conjunctionFilterStringBuilder = new();

                conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: conjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (conjunctionFilterInput is null)
            {
                StringBuilder conjunctionFilterStringBuilder = new();

                conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: conjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (!ConjunctionFilterLeft.CheckFilterComponentField(filterComponentInput: conjunctionFilterInput))
            {
                return false;
            }

            if (!ConjunctionFilterRight.CheckFilterComponentField(filterComponentInput: conjunctionFilterInput))
            {
                return false;
            }

            return true;
        }

        public override void AcceptFilterComponent(in Template2 conjunctionFilterVisitor)
        {
            if (conjunctionFilterVisitor is null)
            {
                StringBuilder conjunctionFilterStringBuilder = new();

                conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
                conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: conjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            conjunctionFilterVisitor.ExecuteFilterVisitorOperation(filterVisitorElement: this);
        }

        public override bool Equals(object? uncastedConjunctionFilter)
        {
            StringBuilder conjunctionFilterStringBuilder = new();

            conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: conjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder conjunctionFilterStringBuilder = new();

            conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: conjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder conjunctionFilterStringBuilder = new();

            conjunctionFilterStringBuilder.Append(value: $"[START]{nameof(ConjunctionFilter<Template1, Template2>)}[START]");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(ConjunctionFilter<Template1, Template2>)}' class");
            conjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            conjunctionFilterStringBuilder.Append(value: $"[END]{nameof(ConjunctionFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: conjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}