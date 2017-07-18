/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace PracticeHelp.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('PracticeHelp');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}