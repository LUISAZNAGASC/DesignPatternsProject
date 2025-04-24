// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Structural.Composite
{
    using System;
    using System.Text;

    public sealed class IdentityFilter<Template1> : FilterComponent<Template1> where Template1 : class
    {
        public FilterComponent<Template1> IdentityFilterUnary { get; }

        public IdentityFilter(in FilterComponent<Template1> identityFilterUnary) : base()
        {
            if (identityFilterUnary is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            IdentityFilterUnary = identityFilterUnary;
        }

        public override bool CheckFilterComponentField(in Template1 identityFilterInput)
        {
            if (IdentityFilterUnary is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            if (identityFilterInput is null)
            {
                StringBuilder identityFilterStringBuilder = new();

                identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1>)}[START]");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"There was an issue in '{nameof(IdentityFilter<Template1>)}' class");
                identityFilterStringBuilder.AppendLine(value: string.Empty);
                identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1>)}[END]");

                throw new InvalidOperationException(message: identityFilterStringBuilder.ToString(), innerException: new Exception());
            }

            return IdentityFilterUnary.CheckFilterComponentField(filterComponentInput: identityFilterInput);
        }

        public override bool Equals(object? uncastedIdentityFilter)
        {
            StringBuilder identityFilterStringBuilder = new();

            identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1>)}[START]");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(IdentityFilter<Template1>)}' class");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1>)}[END]");

            throw new NotImplementedException(message: identityFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder identityFilterStringBuilder = new();

            identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1>)}[START]");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(IdentityFilter<Template1>)}' class");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1>)}[END]");

            throw new NotImplementedException(message: identityFilterStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder identityFilterStringBuilder = new();

            identityFilterStringBuilder.Append(value: $"[START]{nameof(IdentityFilter<Template1>)}[START]");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"Method not implemented in '{nameof(IdentityFilter<Template1>)}' class");
            identityFilterStringBuilder.AppendLine(value: string.Empty);
            identityFilterStringBuilder.Append(value: $"[END]{nameof(IdentityFilter<Template1>)}[END]");

            throw new NotImplementedException(message: identityFilterStringBuilder.ToString(), inner: new Exception());
        }
    }
}