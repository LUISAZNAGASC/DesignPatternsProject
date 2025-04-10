// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Visitor
{
    using System;
    using System.Text;

    public sealed class IdentityFilter<Template1, Template2> : FilterComponent<Template1, Template2> where Template1 : class where Template2 : FilterVisitor<Template1, Template2>
    {
        public FilterComponent<Template1, Template2> IdentityFilterUnary { get; }

        public IdentityFilter(in FilterComponent<Template1, Template2> identityFilterUnary) : base()
        {
            if (identityFilterUnary is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1, Template2>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            IdentityFilterUnary = identityFilterUnary;
        }

        public override bool CheckFilterComponentField(in Template1 identityFilterInput)
        {
            if (IdentityFilterUnary is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1, Template2>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (identityFilterInput is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1, Template2>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            return IdentityFilterUnary.CheckFilterComponentField(filterComponentInput: identityFilterInput);
        }

        public override void AcceptFilterComponent(in Template2 identityFilterVisitor)
        {
            if (identityFilterVisitor is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1, Template2>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            identityFilterVisitor.ExecuteFilterVisitorOperation(filterVisitorElement: this);
        }

        public override bool Equals(object? uncastedIdentityFilter)
        {
            StringBuilder identityFilterStringBuilder = new();

            identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(IdentityFilter<Template1, Template2>)}' class");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: identityFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder identityFilterStringBuilder = new();

            identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(IdentityFilter<Template1, Template2>)}' class");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: identityFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder identityFilterStringBuilder = new();

            identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1, Template2>)}[START]");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(IdentityFilter<Template1, Template2>)}' class");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1, Template2>)}[END]");

            throw new NotImplementedException(message: identityFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}