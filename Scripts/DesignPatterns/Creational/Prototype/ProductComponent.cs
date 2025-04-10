// LAST UPDATED DATE : 10/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Prototype
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum ProductSize : uint
    {
        ProductSizeUndefined = 0, ProductSizeSmall = 1, ProductSizeMedium = 2, ProductSizeLarge = 3
    }

    public enum ProductWeight : uint
    {
        ProductWeightUndefined = 0, ProductWeightLight = 1, ProductWeightMedium = 2, ProductWeightHeavy = 3
    }

    public abstract class ProductComponent
    {
        public ProductSize ProductComponentWidth { get; private set; }

        public ProductSize ProductComponentHeight { get; private set; }

        public ProductSize ProductComponentDepth { get; private set; }

        public ProductWeight ProductComponentWeight { get; private set; }

        public ProductComponent() : base()
        {
            ProductComponentWidth = ProductSize.ProductSizeUndefined;

            ProductComponentHeight = ProductSize.ProductSizeUndefined;

            ProductComponentDepth = ProductSize.ProductSizeUndefined;

            ProductComponentWeight = ProductWeight.ProductWeightUndefined;
        }

        public ProductComponent(in ProductSize productComponentWidth, in ProductSize productComponentHeight, in ProductSize productComponentDepth, in ProductWeight productComponentWeight) : base()
        {
            if (!Enum.IsDefined(value: productComponentWidth))
            {
                ProductComponentWidth = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ProductComponentWidth = productComponentWidth;
            }

            if (!Enum.IsDefined(value: productComponentHeight))
            {
                ProductComponentHeight = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ProductComponentHeight = productComponentHeight;
            }

            if (!Enum.IsDefined(value: productComponentDepth))
            {
                ProductComponentDepth = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ProductComponentDepth = productComponentDepth;
            }

            if (!Enum.IsDefined(value: productComponentWeight))
            {
                ProductComponentWeight = ProductWeight.ProductWeightUndefined;
            }
            else
            {
                ProductComponentWeight = productComponentWeight;
            }
        }

        public void SetProductComponentWidth(in ProductSize productComponentWidth)
        {
            if (!Enum.IsDefined(value: productComponentWidth))
            {
                ProductComponentWidth = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ProductComponentWidth = productComponentWidth;
            }
        }

        public void SetProductComponentHeight(in ProductSize productComponentHeight)
        {
            if (!Enum.IsDefined(value: productComponentHeight))
            {
                ProductComponentHeight = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ProductComponentHeight = productComponentHeight;
            }
        }

        public void SetProductComponentDepth(in ProductSize productComponentDepth)
        {
            if (!Enum.IsDefined(value: productComponentDepth))
            {
                ProductComponentDepth = ProductSize.ProductSizeUndefined;
            }
            else
            {
                ProductComponentDepth = productComponentDepth;
            }
        }

        public void SetProductComponentWeight(in ProductWeight productComponentWeight)
        {
            if (!Enum.IsDefined(value: productComponentWeight))
            {
                ProductComponentWeight = ProductWeight.ProductWeightUndefined;
            }
            else
            {
                ProductComponentWeight = productComponentWeight;
            }
        }

        public override bool Equals(object? uncastedProductComponent)
        {
            if (ReferenceEquals(objA: this, objB: uncastedProductComponent))
            {
                return true;
            }

            if (uncastedProductComponent is null || uncastedProductComponent.GetType() != typeof(ProductComponent))
            {
                return false;
            }

            if (uncastedProductComponent is not ProductComponent castedProductComponent)
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentWidth, y: castedProductComponent.ProductComponentWidth))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentHeight, y: castedProductComponent.ProductComponentHeight))
            {
                return false;
            }

            if (!EqualityComparer<ProductSize>.Default.Equals(x: ProductComponentDepth, y: castedProductComponent.ProductComponentDepth))
            {
                return false;
            }

            if (!EqualityComparer<ProductWeight>.Default.Equals(x: ProductComponentWeight, y: castedProductComponent.ProductComponentWeight))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int ProductComponentHashCodeInitialPrime = 0B1001111;
            const int ProductComponentHashCodeMultiplierPrime = 0B1100001;

            int productComponentHashCode = ProductComponentHashCodeInitialPrime;

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentWidth);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentHeight);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentDepth);

            productComponentHashCode = HashCode.Combine(value1: ProductComponentHashCodeMultiplierPrime ^ productComponentHashCode, value2: ProductComponentWeight);

            return productComponentHashCode;
        }

        public override string ToString()
        {
            StringBuilder productComponentStringBuilder = new();

            productComponentStringBuilder.Append(value: $"[START]{nameof(ProductComponent)}[START]");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentWidth)}: {ProductComponentWidth}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentHeight)}: {ProductComponentHeight}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentDepth)}: {ProductComponentDepth}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"{nameof(ProductComponentWeight)}: {ProductComponentWeight}");
            productComponentStringBuilder.AppendLine(value: string.Empty);
            productComponentStringBuilder.Append(value: $"[END]{nameof(ProductComponent)}[END]");

            return productComponentStringBuilder.ToString();
        }
    }
}