
namespace SerenityOdeToFood.Default {
    export interface ReviewsRow {
        ReviewId?: string;
        ReviewText?: string;
        Rating?: number;
        RestaurantId?: string;
        RestaurantCity?: string;
        RestaurantCountry?: string;
        RestaurantRestaurantName?: string;
    }

    export namespace ReviewsRow {
        export const idProperty = 'ReviewId';
        export const nameProperty = 'ReviewText';
        export const localTextPrefix = 'Default.Reviews';

        export namespace Fields {
            export declare const ReviewId;
            export declare const ReviewText;
            export declare const Rating;
            export declare const RestaurantId;
            export declare const RestaurantCity: string;
            export declare const RestaurantCountry: string;
            export declare const RestaurantRestaurantName: string;
        }

        ['ReviewId', 'ReviewText', 'Rating', 'RestaurantId', 'RestaurantCity', 'RestaurantCountry', 'RestaurantRestaurantName'].forEach(x => (<any>Fields)[x] = x);
    }
}

