namespace RevTech.Common
{
    public static class EntityValidations
    {
        public static class Manufacturer
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
            public const int MaxImageUrlLength = 2048;
        }

        public static class CarModel
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
            public const int MaxImageUrlLength = 2048;
        }

        public static class Engine
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 20;
        }
        public static class PerformancePart
        {
            public const int ModelMinLength = 3;
            public const int ModelMaxLength = 150;

            public const int ManufacturerMinLength = 5;
            public const int ManufacturerMaxLength = 40;

            public const int NameMaxLength = 30;
            public const int NameMinLength = 5;

            public const int MaxImageUrlLength = 2048;

            public const int DescriptionMaxLength = 250;
            public const int DescriptionMinLength = 5;
        }
    }
}