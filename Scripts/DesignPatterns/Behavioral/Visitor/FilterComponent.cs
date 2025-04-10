﻿// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public abstract class FilterComponent<Template1, Template2> where Template1 : class where Template2 : FilterVisitor<Template1, Template2>
    {
        protected FilterComponent() : base()
        {

        }

        public abstract bool CheckFilterComponentField(in Template1 filterComponentInput);

        public abstract void AcceptFilterComponent(in Template2 filterComponentVisitor);

        public IEnumerable<Template1> GetFilterComponentOutputCollection(IEnumerable<Template1> filterComponentInputCollection)
        {
            if (filterComponentInputCollection is null)
            {
                StringBuilder filterComponentStringBuilder = new();

                filterComponentStringBuilder.Append(value: $"[START]{nameof(FilterComponent<Template1, Template2>)}[START]");
                filterComponentStringBuilder.AppendLine(value: string.Empty);
                filterComponentStringBuilder.Append(value: $"There was an issue in '{nameof(FilterComponent<Template1, Template2>)}' class");
                filterComponentStringBuilder.AppendLine(value: string.Empty);
                filterComponentStringBuilder.Append(value: $"[END]{nameof(FilterComponent<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: filterComponentStringBuilder.ToString(), innerException: new Exception());
            }

            foreach (Template1 filterComponentInputElement in filterComponentInputCollection)
            {
                if (filterComponentInputElement is null)
                {
                    StringBuilder filterComponentStringBuilder = new();

                    filterComponentStringBuilder.Append(value: $"[START]{nameof(FilterComponent<Template1, Template2>)}[START]");
                    filterComponentStringBuilder.AppendLine(value: string.Empty);
                    filterComponentStringBuilder.Append(value: $"There was an issue in '{nameof(FilterComponent<Template1, Template2>)}' class");
                    filterComponentStringBuilder.AppendLine(value: string.Empty);
                    filterComponentStringBuilder.Append(value: $"[END]{nameof(FilterComponent<Template1, Template2>)}[END]");

                    throw new InvalidOperationException(message: filterComponentStringBuilder.ToString(), innerException: new Exception());
                }

                if (CheckFilterComponentField(filterComponentInput: filterComponentInputElement))
                {
                    yield return filterComponentInputElement;
                }
            }
        }

        public override bool Equals(object? uncastedFilterComponent)
        {
            StringBuilder filterComponentStringBuilder = new();

            filterComponentStringBuilder.Append(value: $"[START]{nameof(FilterComponent<Template1, Template2>)}[START]");
            filterComponentStringBuilder.AppendLine(value: string.Empty);
            filterComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterComponent<Template1, Template2>)}' class");
            filterComponentStringBuilder.AppendLine(value: string.Empty);
            filterComponentStringBuilder.Append(value: $"[END]{nameof(FilterComponent<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: filterComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder filterComponentStringBuilder = new();

            filterComponentStringBuilder.Append(value: $"[START]{nameof(FilterComponent<Template1, Template2>)}[START]");
            filterComponentStringBuilder.AppendLine(value: string.Empty);
            filterComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterComponent<Template1, Template2>)}' class");
            filterComponentStringBuilder.AppendLine(value: string.Empty);
            filterComponentStringBuilder.Append(value: $"[END]{nameof(FilterComponent<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: filterComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder filterComponentStringBuilder = new();

            filterComponentStringBuilder.Append(value: $"[START]{nameof(FilterComponent<Template1, Template2>)}[START]");
            filterComponentStringBuilder.AppendLine(value: string.Empty);
            filterComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(FilterComponent<Template1, Template2>)}' class");
            filterComponentStringBuilder.AppendLine(value: string.Empty);
            filterComponentStringBuilder.Append(value: $"[END]{nameof(FilterComponent<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: filterComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}