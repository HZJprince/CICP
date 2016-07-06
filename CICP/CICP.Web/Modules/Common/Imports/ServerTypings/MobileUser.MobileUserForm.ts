namespace CICP.MobileUser {
    export class MobileUserForm extends Serenity.PrefixedContext {
        static formKey = 'MobileUser.MobileUser';

    }

    export interface MobileUserForm {
        Password: Serenity.StringEditor;
    }

    [['Password', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MobileUserForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

