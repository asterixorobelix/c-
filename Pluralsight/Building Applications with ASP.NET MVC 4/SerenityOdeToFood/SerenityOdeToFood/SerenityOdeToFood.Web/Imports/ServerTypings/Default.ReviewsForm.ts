

namespace SerenityOdeToFood.Default {
    export class ReviewsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Reviews';
    }

    export interface ReviewsForm {
        ReviewText: Serenity.StringEditor;
        Rating: Serenity.IntegerEditor;
        RestaurantId: Serenity.StringEditor;
    }

    [['ReviewText', () => Serenity.StringEditor], ['Rating', () => Serenity.IntegerEditor], ['RestaurantId', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(ReviewsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}