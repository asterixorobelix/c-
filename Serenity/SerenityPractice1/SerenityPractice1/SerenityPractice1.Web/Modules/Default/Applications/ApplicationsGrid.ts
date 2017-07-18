
namespace SerenityPractice1.Default {
    
    @Serenity.Decorators.registerClass()
    export class ApplicationsGrid extends Serenity.EntityGrid<ApplicationsRow, any> {
        protected getColumnsKey() { return 'Default.Applications'; }
        protected getDialogType() { return ApplicationsDialog; }
        protected getIdProperty() { return ApplicationsRow.idProperty; }
        protected getLocalTextPrefix() { return ApplicationsRow.localTextPrefix; }
        protected getService() { return ApplicationsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}