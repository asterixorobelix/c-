
namespace SerenityPractice1.Default {
    export interface ApplicationsRow {
        ApplicationId?: string;
        ApplicationName?: string;
    }

    export namespace ApplicationsRow {
        export const idProperty = 'ApplicationId';
        export const nameProperty = 'ApplicationName';
        export const localTextPrefix = 'Default.Applications';

        export namespace Fields {
            export declare const ApplicationId;
            export declare const ApplicationName;
        }

        ['ApplicationId', 'ApplicationName'].forEach(x => (<any>Fields)[x] = x);
    }
}

