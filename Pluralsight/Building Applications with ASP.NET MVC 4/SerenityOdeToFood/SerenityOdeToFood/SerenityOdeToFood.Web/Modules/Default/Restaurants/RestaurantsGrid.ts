
namespace SerenityOdeToFood.Default {
    
    @Serenity.Decorators.registerClass()
    export class RestaurantsGrid extends Serenity.EntityGrid<RestaurantsRow, any> {
        protected getColumnsKey() { return 'Default.Restaurants'; }
        protected getDialogType() { return RestaurantsDialog; }
        protected getIdProperty() { return RestaurantsRow.idProperty; }
        protected getLocalTextPrefix() { return RestaurantsRow.localTextPrefix; }
        protected getService() { return RestaurantsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}