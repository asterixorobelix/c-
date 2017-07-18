/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace SerenityPractice1.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('SerenityPractice1');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}