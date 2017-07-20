
namespace SerenityOdeToFood.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RestaurantsDialog extends Serenity.EntityDialog<RestaurantsRow, any> {
        protected getFormKey() { return RestaurantsForm.formKey; }
        protected getIdProperty() { return RestaurantsRow.idProperty; }
        protected getLocalTextPrefix() { return RestaurantsRow.localTextPrefix; }
        protected getNameProperty() { return RestaurantsRow.nameProperty; }
        protected getService() { return RestaurantsService.baseUrl; }

        protected form = new RestaurantsForm(this.idPrefix);

    }
}