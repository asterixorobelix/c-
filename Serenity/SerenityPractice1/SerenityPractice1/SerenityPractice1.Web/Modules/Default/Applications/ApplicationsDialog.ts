
namespace SerenityPractice1.Default {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ApplicationsDialog extends Serenity.EntityDialog<ApplicationsRow, any> {
        protected getFormKey() { return ApplicationsForm.formKey; }
        protected getIdProperty() { return ApplicationsRow.idProperty; }
        protected getLocalTextPrefix() { return ApplicationsRow.localTextPrefix; }
        protected getNameProperty() { return ApplicationsRow.nameProperty; }
        protected getService() { return ApplicationsService.baseUrl; }

        protected form = new ApplicationsForm(this.idPrefix);

    }
}