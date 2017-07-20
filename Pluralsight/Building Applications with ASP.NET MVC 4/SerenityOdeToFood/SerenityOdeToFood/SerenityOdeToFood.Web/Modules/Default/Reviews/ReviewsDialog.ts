
namespace SerenityOdeToFood.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ReviewsDialog extends Serenity.EntityDialog<ReviewsRow, any> {
        protected getFormKey() { return ReviewsForm.formKey; }
        protected getIdProperty() { return ReviewsRow.idProperty; }
        protected getLocalTextPrefix() { return ReviewsRow.localTextPrefix; }
        protected getNameProperty() { return ReviewsRow.nameProperty; }
        protected getService() { return ReviewsService.baseUrl; }

        protected form = new ReviewsForm(this.idPrefix);

    }
}