using ErrorOr;

namespace BuberBreakfast.ServiceErrors
{
    public static class Errors
    {
        public static class Breakfast
        {
            public static Error InvalidDescription => Error.Validation(
                code: "Breakfast.InvalidDescription",
                description: $"Breakfast Description must atleast be {Models.Breakfast.MinDescriptionLength} characters long and at most {Models.Breakfast.MaxDescriptionLength} characters long."
            );

            public static Error InvalidName => Error.Validation(
                code: "Breakfast.InvalidName",
                description: $"Breakfast Name must atleast be {Models.Breakfast.MinNameLength} characters long and at most {Models.Breakfast.MaxNameLength} characters long."
            );

            public static Error NotFound => Error.NotFound(
                code: "Breakfast.NotFound",
                description: "Breakfast Not found."
            );

        }
    }
}