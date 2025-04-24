// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public abstract class FilterVisitor<Template1, Template2> where Template1 : class where Template2 : FilterVisitor<Template1, Template2>
    {
        protected Template1 FilterVisitorReference { get; }

        protected StringBuilder FilterVisitorExpression { get; }

        protected const string FilterVisitorNegativeExpression = "--";
        protected const string FilterVisitorPositiveExpression = "++";
        protected const string FilterVisitorIdentityExpression = "==";
        protected const string FilterVisitorNegationExpression = "!=";
        protected const string FilterVisitorConjunctionExpression = "&&";
        protected const string FilterVisitorDisjunctionExpression = "||";
        protected const string FilterVisitorOpeningParenthesisExpression = "[(";
        protected const string FilterVisitorClosingParenthesisExpression = ")]";

        protected FilterVisitor(in Template1 filterVisitorReference) : base()
        {
            if (filterVisitorReference is null)
            {
                StringBuilder filterVisitorStringBuilder = new();

                filterVisitorStringBuilder.Append(value: $"[START]{nameof(FilterVisitor<Template1, Template2>)}[START]");
                filterVisitorStringBuilder.AppendLine(value: string.Empty);
                filterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(FilterVisitor<Template1, Template2>)}' class");
                filterVisitorStringBuilder.AppendLine(value: string.Empty);
                filterVisitorStringBuilder.Append(value: $"[END]{nameof(FilterVisitor<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: filterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            FilterVisitorReference = filterVisitorReference;

            FilterVisitorExpression = new StringBuilder();
        }

        public string GetFilterVisitorExpression()
        {
            if (FilterVisitorExpression is null)
            {
                StringBuilder filterVisitorStringBuilder = new();

                filterVisitorStringBuilder.Append(value: $"[START]{nameof(FilterVisitor<Template1, Template2>)}[START]");
                filterVisitorStringBuilder.AppendLine(value: string.Empty);
                filterVisitorStringBuilder.Append(value: $"There was an issue in '{nameof(FilterVisitor<Template1, Template2>)}' class");
                filterVisitorStringBuilder.AppendLine(value: string.Empty);
                filterVisitorStringBuilder.Append(value: $"[END]{nameof(FilterVisitor<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: filterVisitorStringBuilder.ToString(), innerException: new Exception());
            }

            return FilterVisitorExpression.ToString();
        }

        public abstract void ExecuteFilterVisitorOperation(in FilterComponent<Template1, Template2> filterVisitorElement);

        public abstract void ExecuteFilterVisitorOperation(in IdentityFilter<Template1, Template2> filterVisitorElement);

        public abstract void ExecuteFilterVisitorOperation(in NegationFilter<Template1, Template2> filterVisitorElement);

        public abstract void ExecuteFilterVisitorOperation(in ConjunctionFilter<Template1, Template2> filterVisitorElement);

        public abstract void ExecuteFilterVisitorOperation(in DisjunctionFilter<Template1, Template2> filterVisitorElement);

        public override bool Equals(object? uncastedFilterVisitor)
        {
            StringBuilder filterVisitorStringBuilder = new();

            filterVisitorStringBuilder.Append(value: $"[START]{nameof(FilterVisitor<Template1, Template2>)}[START]");
            filterVisitorStringBuilder.AppendLine(value: string.Empty);
            filterVisitorStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterVisitor<Template1, Template2>)}' class");
            filterVisitorStringBuilder.AppendLine(value: string.Empty);
            filterVisitorStringBuilder.Append(value: $"[END]{nameof(FilterVisitor<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: filterVisitorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder filterVisitorStringBuilder = new();

            filterVisitorStringBuilder.Append(value: $"[START]{nameof(FilterVisitor<Template1, Template2>)}[START]");
            filterVisitorStringBuilder.AppendLine(value: string.Empty);
            filterVisitorStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterVisitor<Template1, Template2>)}' class");
            filterVisitorStringBuilder.AppendLine(value: string.Empty);
            filterVisitorStringBuilder.Append(value: $"[END]{nameof(FilterVisitor<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: filterVisitorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder filterVisitorStringBuilder = new();

            filterVisitorStringBuilder.Append(value: $"[START]{nameof(FilterVisitor<Template1, Template2>)}[START]");
            filterVisitorStringBuilder.AppendLine(value: string.Empty);
            filterVisitorStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterVisitor<Template1, Template2>)}' class");
            filterVisitorStringBuilder.AppendLine(value: string.Empty);
            filterVisitorStringBuilder.Append(value: $"[END]{nameof(FilterVisitor<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: filterVisitorStringBuilder.ToString(), inner: new Exception());
        }
    }
}