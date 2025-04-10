// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Iterator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class IteratorComponent<Template1> where Template1 : class
    {
        private NodeComponent<Template1> IteratorComponentRoot { get; }

        public IteratorComponent(in NodeComponent<Template1> iteratorComponentRoot) : base()
        {
            if (iteratorComponentRoot is null)
            {
                StringBuilder iteratorComponentStringBuilder = new();

                iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
                iteratorComponentStringBuilder.AppendLine(value: string.Empty);
                iteratorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(IteratorComponent<Template1>)}' class");
                iteratorComponentStringBuilder.AppendLine(value: string.Empty);
                iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: iteratorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            IteratorComponentRoot = iteratorComponentRoot;
        }

        public IEnumerable<NodeComponent<Template1>> GetIteratorComponentPreOrderCollection()
        {
            static IEnumerable<NodeComponent<Template1>> GetIteratorComponentPreOrderCollection(NodeComponent<Template1> iteratorComponentCurrent)
            {
                if (iteratorComponentCurrent is null)
                {
                    yield break;
                }

                yield return iteratorComponentCurrent;

                if (iteratorComponentCurrent.NodeComponentLeft is not null)
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPreOrderCollection(iteratorComponentCurrent: iteratorComponentCurrent.NodeComponentLeft))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                if (iteratorComponentCurrent.NodeComponentRight is not null)
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPreOrderCollection(iteratorComponentCurrent: iteratorComponentCurrent.NodeComponentRight))
                    {
                        yield return iteratorComponentChild;
                    }
                }
            }

            if (IteratorComponentRoot is null)
            {
                yield break;
            }

            foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPreOrderCollection(iteratorComponentCurrent: IteratorComponentRoot))
            {
                yield return iteratorComponentChild;
            }
        }

        public IEnumerable<NodeComponent<Template1>> GetIteratorComponentInOrderCollection()
        {
            static IEnumerable<NodeComponent<Template1>> GetIteratorComponentInOrderCollection(NodeComponent<Template1> iteratorComponentCurrent)
            {
                if (iteratorComponentCurrent is null)
                {
                    yield break;
                }

                if (iteratorComponentCurrent.NodeComponentLeft is not null)
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentInOrderCollection(iteratorComponentCurrent: iteratorComponentCurrent.NodeComponentLeft))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                yield return iteratorComponentCurrent;

                if (iteratorComponentCurrent.NodeComponentRight is not null)
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentInOrderCollection(iteratorComponentCurrent: iteratorComponentCurrent.NodeComponentRight))
                    {
                        yield return iteratorComponentChild;
                    }
                }
            }

            if (IteratorComponentRoot is null)
            {
                yield break;
            }

            foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentInOrderCollection(iteratorComponentCurrent: IteratorComponentRoot))
            {
                yield return iteratorComponentChild;
            }
        }

        public IEnumerable<NodeComponent<Template1>> GetIteratorComponentPostOrderCollection()
        {
            static IEnumerable<NodeComponent<Template1>> GetIteratorComponentPostOrderCollection(NodeComponent<Template1> iteratorComponentCurrent)
            {
                if (iteratorComponentCurrent is null)
                {
                    yield break;
                }

                if (iteratorComponentCurrent.NodeComponentLeft is not null)
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPostOrderCollection(iteratorComponentCurrent: iteratorComponentCurrent.NodeComponentLeft))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                if (iteratorComponentCurrent.NodeComponentRight is not null)
                {
                    foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPostOrderCollection(iteratorComponentCurrent: iteratorComponentCurrent.NodeComponentRight))
                    {
                        yield return iteratorComponentChild;
                    }
                }

                yield return iteratorComponentCurrent;
            }

            if (IteratorComponentRoot is null)
            {
                yield break;
            }

            foreach (NodeComponent<Template1> iteratorComponentChild in GetIteratorComponentPostOrderCollection(iteratorComponentCurrent: IteratorComponentRoot))
            {
                yield return iteratorComponentChild;
            }
        }

        public override bool Equals(object? uncastedIteratorComponent)
        {
            StringBuilder iteratorComponentStringBuilder = new();

            iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(IteratorComponent<Template1>)}' class");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: iteratorComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder iteratorComponentStringBuilder = new();

            iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(IteratorComponent<Template1>)}' class");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: iteratorComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder iteratorComponentStringBuilder = new();

            iteratorComponentStringBuilder.Append(value: $"[START]{nameof(IteratorComponent<Template1>)}[START]");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(IteratorComponent<Template1>)}' class");
            iteratorComponentStringBuilder.AppendLine(value: string.Empty);
            iteratorComponentStringBuilder.Append(value: $"[END]{nameof(IteratorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: iteratorComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}