namespace CICP.MobileUser {
    export class ResultForm extends Serenity.PrefixedContext {
        static formKey = 'MobileUser.Result';

    }

    export interface ResultForm {
        UserId: Serenity.IntegerEditor;
        Username: Serenity.StringEditor;
        Idnumber: Serenity.StringEditor;
        Data: Serenity.StringEditor;
        Msg: Serenity.StringEditor;
        Success: Serenity.StringEditor;
    }

    [['UserId', () => Serenity.IntegerEditor], ['Username', () => Serenity.StringEditor], ['Idnumber', () => Serenity.StringEditor], ['Data', () => Serenity.StringEditor], ['Msg', () => Serenity.StringEditor], ['Success', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(ResultForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

