/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace SerenityOdeToFood.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('SerenityOdeToFood');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}