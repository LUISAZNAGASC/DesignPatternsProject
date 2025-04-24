// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public sealed class DisjunctionFilter<Template1, Template2> : FilterComponent<Template1, Template2> where Template1 : class where Template2 : FilterVisitor<Template1, Template2>
    {
        public FilterComponent<Template1, Template2> DisjunctionFilterLeft { get; }

        public FilterComponent<Template1, Template2> DisjunctionFilterRight { get; }

        public DisjunctionFilter(in FilterComponent<Template1, Template2> disjunctionFilterLeft, in FilterComponent<Template1, Template2> disjunctionFilterRight)
        {
            if (disjunctionFilterLeft is null || disjunctionFilterRight is null)
            {
                StringBuilder disjunctionFilterStringBuilder = new();

                disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: disjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            DisjunctionFilterLeft = disjunctionFilterLeft;

            DisjunctionFilterRight = disjunctionFilterRight;
        }

        public override bool CheckFilterComponentField(in Template1 disjunctionFilterInput)
        {
            if (DisjunctionFilterLeft is null || DisjunctionFilterRight is null)
            {
                StringBuilder disjunctionFilterStringBuilder = new();

                disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: disjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (disjunctionFilterInput is null)
            {
                StringBuilder disjunctionFilterStringBuilder = new();

                disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: disjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (DisjunctionFilterLeft.CheckFilterComponentField(filterComponentInput: disjunctionFilterInput))
            {
                return true;
            }

            if (DisjunctionFilterRight.CheckFilterComponentField(filterComponentInput: disjunctionFilterInput))
            {
                return true;
            }

            return false;
        }

        public override void AcceptFilterComponent(in Template2 disjunctionFilterVisitor)
        {
            if (disjunctionFilterVisitor is null)
            {
                StringBuilder disjunctionFilterStringBuilder = new();

                disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"There was an issue in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
                disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
                disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: disjunctionFilterStringBuilder.ToString(), innerException: new Exception());
            }

            disjunctionFilterVisitor.ExecuteFilterVisitorOperation(filterVisitorElement: this);
        }

        public override bool Equals(object? uncastedDisjunctionFilter)
        {
            StringBuilder disjunctionFilterStringBuilder = new();

            disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: disjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder disjunctionFilterStringBuilder = new();

            disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: disjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder disjunctionFilterStringBuilder = new();

            disjunctionFilterStringBuilder.Append(value: $"[START]{nameof(DisjunctionFilter<Template1, Template2>)}[START]");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(DisjunctionFilter<Template1, Template2>)}' class");
            disjunctionFilterStringBuilder.AppendLine(value: string.Empty);
            disjunctionFilterStringBuilder.Append(value: $"[END]{nameof(DisjunctionFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: disjunctionFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}