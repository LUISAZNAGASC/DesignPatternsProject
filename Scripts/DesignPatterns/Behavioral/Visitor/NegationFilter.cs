// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public sealed class NegationFilter<Template1, Template2> : FilterComponent<Template1, Template2> where Template1 : class where Template2 : FilterVisitor<Template1, Template2>
    {
        public FilterComponent<Template1, Template2> NegationFilterUnary { get; }

        public NegationFilter(in FilterComponent<Template1, Template2> negationFilterUnary) : base()
        {
            if (negationFilterUnary is null)
            {
                StringBuilder negationFilterStringBuilder = new();

                negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"There was an issue in '{nameof(NegationFilter<Template1, Template2>)}' class");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: negationFilterStringBuilder.ToString(), innerException: new Exception());
            }

            NegationFilterUnary = negationFilterUnary;
        }

        public override bool CheckFilterComponentField(in Template1 negationFilterInput)
        {
            if (NegationFilterUnary is null)
            {
                StringBuilder negationFilterStringBuilder = new();

                negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"There was an issue in '{nameof(NegationFilter<Template1, Template2>)}' class");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: negationFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (negationFilterInput is null)
            {
                StringBuilder negationFilterStringBuilder = new();

                negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"There was an issue in '{nameof(NegationFilter<Template1, Template2>)}' class");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: negationFilterStringBuilder.ToString(), innerException: new Exception());
            }

            return !NegationFilterUnary.CheckFilterComponentField(filterComponentInput: negationFilterInput);
        }

        public override void AcceptFilterComponent(in Template2 negationFilterVisitor)
        {
            if (negationFilterVisitor is null)
            {
                StringBuilder negationFilterStringBuilder = new();

                negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"There was an issue in '{nameof(NegationFilter<Template1, Template2>)}' class");
                negationFilterStringBuilder.AppendLine(value: string.Empty);
                negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: negationFilterStringBuilder.ToString(), innerException: new Exception());
            }

            negationFilterVisitor.ExecuteFilterVisitorOperation(filterVisitorElement: this);
        }

        public override bool Equals(object? uncastedNegationFilter)
        {
            StringBuilder negationFilterStringBuilder = new();

            negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(NegationFilter<Template1, Template2>)}' class");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: negationFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder negationFilterStringBuilder = new();

            negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(NegationFilter<Template1, Template2>)}' class");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: negationFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder negationFilterStringBuilder = new();

            negationFilterStringBuilder.Append(value: $"[START]{nameof(NegationFilter<Template1, Template2>)}[START]");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(NegationFilter<Template1, Template2>)}' class");
            negationFilterStringBuilder.AppendLine(value: string.Empty);
            negationFilterStringBuilder.Append(value: $"[END]{nameof(NegationFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: negationFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}