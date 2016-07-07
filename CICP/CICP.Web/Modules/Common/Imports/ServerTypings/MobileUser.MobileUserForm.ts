namespace CICP.MobileUser {
    export class MobileUserForm extends Serenity.PrefixedContext {
        static formKey = 'MobileUser.MobileUser';

    }

    export interface MobileUserForm {
        Username: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
    }

    [['Username', () => Serenity.StringEditor], ['Password', () => Serenity.PasswordEditor], ['PasswordConfirm', () => Serenity.PasswordEditor]].forEach(x => Object.defineProperty(MobileUserForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

