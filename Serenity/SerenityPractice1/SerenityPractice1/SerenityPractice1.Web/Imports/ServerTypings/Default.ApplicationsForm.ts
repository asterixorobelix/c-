

namespace SerenityPractice1.Default {
    export class ApplicationsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Applications';
    }

    export interface ApplicationsForm {
        ApplicationName: Serenity.StringEditor;
    }

    [['ApplicationName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(ApplicationsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}