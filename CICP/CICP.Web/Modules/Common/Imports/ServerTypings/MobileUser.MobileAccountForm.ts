

namespace CICP.MobileUser {
    export class MobileAccountForm extends Serenity.PrefixedContext {
        static formKey = 'MobileUser.MobileAccount';
    }

    export interface MobileAccountForm {
        Name: Serenity.StringEditor;
        Tel: Serenity.StringEditor;
        Orderno: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor], ['Tel', () => Serenity.StringEditor], ['Idnumber', () => Serenity.StringEditor], ['Orderno', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MobileAccountForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}