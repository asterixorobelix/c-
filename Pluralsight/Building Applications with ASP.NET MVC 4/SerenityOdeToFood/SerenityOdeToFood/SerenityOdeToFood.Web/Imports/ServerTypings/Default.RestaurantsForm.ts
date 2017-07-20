

namespace SerenityOdeToFood.Default {
    export class RestaurantsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Restaurants';
    }

    export interface RestaurantsForm {
        City: Serenity.StringEditor;
        Country: Serenity.StringEditor;
        RestaurantName: Serenity.StringEditor;
    }

    [['City', () => Serenity.StringEditor], ['Country', () => Serenity.StringEditor], ['RestaurantName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RestaurantsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}