
namespace SerenityOdeToFood.Default {
    
    @Serenity.Decorators.registerClass()
    export class ReviewsGrid extends Serenity.EntityGrid<ReviewsRow, any> {
        protected getColumnsKey() { return 'Default.Reviews'; }
        protected getDialogType() { return ReviewsDialog; }
        protected getIdProperty() { return ReviewsRow.idProperty; }
        protected getLocalTextPrefix() { return ReviewsRow.localTextPrefix; }
        protected getService() { return ReviewsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}