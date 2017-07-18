
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace SerenityPractice1.Default {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ApplicationsEditorDialog extends Common.GridEditorDialog<ApplicationsRow> {
        protected getFormKey() { return ApplicationsForm.formKey; }
                protected getLocalTextPrefix() { return ApplicationsRow.localTextPrefix; }
        protected getNameProperty() { return ApplicationsRow.nameProperty; }
        protected form = new ApplicationsForm(this.idPrefix);
    }
}