
namespace SerenityOdeToFood.Default {
    export interface RestaurantsRow {
        RestaurantId?: string;
        City?: string;
        Country?: string;
        RestaurantName?: string;
    }

    export namespace RestaurantsRow {
        export const idProperty = 'RestaurantId';
        export const nameProperty = 'City';
        export const localTextPrefix = 'Default.Restaurants';

        export namespace Fields {
            export declare const RestaurantId;
            export declare const City;
            export declare const Country;
            export declare const RestaurantName;
        }

        ['RestaurantId', 'City', 'Country', 'RestaurantName'].forEach(x => (<any>Fields)[x] = x);
    }
}

