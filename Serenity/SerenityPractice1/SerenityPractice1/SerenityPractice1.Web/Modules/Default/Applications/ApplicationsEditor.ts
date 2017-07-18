
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SerenityPractice1.Default {
    
    @Serenity.Decorators.registerClass()
    export class ApplicationsEditor extends Common.GridEditorBase<ApplicationsRow> {
        protected getColumnsKey() { return 'Default.Applications'; }
        protected getDialogType() { return ApplicationsEditorDialog; }
                protected getLocalTextPrefix() { return ApplicationsRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}