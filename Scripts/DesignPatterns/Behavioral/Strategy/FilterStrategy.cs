// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class FilterStrategy<Template1> where Template1 : class
    {
        private FilterComponent<Template1> FilterStrategyCondition { get; set; }

        public FilterStrategy(in FilterComponent<Template1> filterStrategyCondition) : base()
        {
            if (filterStrategyCondition is null)
            {
                StringBuilder filterStrategyStringBuilder = new();

                filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"There was an issue in '{nameof(FilterStrategy<Template1>)}' class");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

                throw new InvalidOperationException(message: filterStrategyStringBuilder.ToString(), innerException: new Exception());
            }

            FilterStrategyCondition = filterStrategyCondition;
        }

        public void SetFilterStrategyCondition(in FilterComponent<Template1> filterStrategyCondition)
        {
            if (filterStrategyCondition is null)
            {
                StringBuilder filterStrategyStringBuilder = new();

                filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"There was an issue in '{nameof(FilterStrategy<Template1>)}' class");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

                throw new InvalidOperationException(message: filterStrategyStringBuilder.ToString(), innerException: new Exception());
            }

            FilterStrategyCondition = filterStrategyCondition;
        }

        public bool CheckFilterStrategyField(in Template1 filterStrategyInput)
        {
            if (FilterStrategyCondition is null)
            {
                StringBuilder filterStrategyStringBuilder = new();

                filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"There was an issue in '{nameof(FilterStrategy<Template1>)}' class");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

                throw new InvalidOperationException(message: filterStrategyStringBuilder.ToString(), innerException: new Exception());
            }

            if (filterStrategyInput is null)
            {
                StringBuilder filterStrategyStringBuilder = new();

                filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"There was an issue in '{nameof(FilterStrategy<Template1>)}' class");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

                throw new InvalidOperationException(message: filterStrategyStringBuilder.ToString(), innerException: new Exception());
            }

            return FilterStrategyCondition.CheckFilterComponentField(filterComponentInput: filterStrategyInput);
        }

        public IEnumerable<Template1> GetFilterStrategyOutputCollection(IEnumerable<Template1> filterStrategyInputCollection)
        {
            if (FilterStrategyCondition is null)
            {
                StringBuilder filterStrategyStringBuilder = new();

                filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"There was an issue in '{nameof(FilterStrategy<Template1>)}' class");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

                throw new InvalidOperationException(message: filterStrategyStringBuilder.ToString(), innerException: new Exception());
            }

            if (filterStrategyInputCollection is null)
            {
                StringBuilder filterStrategyStringBuilder = new();

                filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"There was an issue in '{nameof(FilterStrategy<Template1>)}' class");
                filterStrategyStringBuilder.AppendLine(value: string.Empty);
                filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

                throw new InvalidOperationException(message: filterStrategyStringBuilder.ToString(), innerException: new Exception());
            }

            return FilterStrategyCondition.GetFilterComponentOutputCollection(filterComponentInputCollection: filterStrategyInputCollection);
        }

        public override bool Equals(object? uncastedFilterStrategy)
        {
            StringBuilder filterStrategyStringBuilder = new();

            filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
            filterStrategyStringBuilder.AppendLine(value: string.Empty);
            filterStrategyStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterStrategy<Template1>)}' class");
            filterStrategyStringBuilder.AppendLine(value: string.Empty);
            filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

            throw new NotImplementedException(message: filterStrategyStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder filterStrategyStringBuilder = new();

            filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
            filterStrategyStringBuilder.AppendLine(value: string.Empty);
            filterStrategyStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterStrategy<Template1>)}' class");
            filterStrategyStringBuilder.AppendLine(value: string.Empty);
            filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

            throw new NotImplementedException(message: filterStrategyStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder filterStrategyStringBuilder = new();

            filterStrategyStringBuilder.Append(value: $"[START]{nameof(FilterStrategy<Template1>)}[START]");
            filterStrategyStringBuilder.AppendLine(value: string.Empty);
            filterStrategyStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterStrategy<Template1>)}' class");
            filterStrategyStringBuilder.AppendLine(value: string.Empty);
            filterStrategyStringBuilder.Append(value: $"[END]{nameof(FilterStrategy<Template1>)}[END]");

            throw new NotImplementedException(message: filterStrategyStringBuilder.ToString(), inner: new Exception());
        }
    }
}