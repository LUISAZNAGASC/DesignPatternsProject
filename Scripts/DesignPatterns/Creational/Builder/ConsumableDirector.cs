﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Builder
{
    using System;
    using System.Text;

    public sealed class ConsumableDirector : ConsumableBuilderTarget<ConsumableDirector>
    {
        private ConsumableDirector() : base()
        {

        }

        public static ConsumableDirector NewConsumableDirectorInstance()
        {
            return new ConsumableDirector();
        }

        public override bool Equals(object? uncastedConsumableDirector)
        {
            StringBuilder consumableDirectorStringBuilder = new();

            consumableDirectorStringBuilder.Append(value: $"[START]{nameof(ConsumableDirector)}[START]");
            consumableDirectorStringBuilder.AppendLine(value: string.Empty);
            consumableDirectorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableDirector)}' class");
            consumableDirectorStringBuilder.AppendLine(value: string.Empty);
            consumableDirectorStringBuilder.Append(value: $"[END]{nameof(ConsumableDirector)}[END]");

            throw new NotImplementedException(message: consumableDirectorStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder consumableDirectorStringBuilder = new();

            consumableDirectorStringBuilder.Append(value: $"[START]{nameof(ConsumableDirector)}[START]");
            consumableDirectorStringBuilder.AppendLine(value: string.Empty);
            consumableDirectorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableDirector)}' class");
            consumableDirectorStringBuilder.AppendLine(value: string.Empty);
            consumableDirectorStringBuilder.Append(value: $"[END]{nameof(ConsumableDirector)}[END]");

            throw new NotImplementedException(message: consumableDirectorStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder consumableDirectorStringBuilder = new();

            consumableDirectorStringBuilder.Append(value: $"[START]{nameof(ConsumableDirector)}[START]");
            consumableDirectorStringBuilder.AppendLine(value: string.Empty);
            consumableDirectorStringBuilder.Append(value: $"Method not implemented in '{nameof(ConsumableDirector)}' class");
            consumableDirectorStringBuilder.AppendLine(value: string.Empty);
            consumableDirectorStringBuilder.Append(value: $"[END]{nameof(ConsumableDirector)}[END]");

            throw new NotImplementedException(message: consumableDirectorStringBuilder.ToString(), inner: new Exception());
        }
    }
}