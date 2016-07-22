namespace CICP.MobileUser {
    export class RongTuoForm extends Serenity.PrefixedContext {
        static formKey = 'MobileUser.RongTuo';

    }

    export interface RongTuoForm {
        Version: Serenity.StringEditor;
        UserId: Serenity.IntegerEditor;
        Username: Serenity.StringEditor;
        Idnumber: Serenity.StringEditor;
        RespCode: Serenity.StringEditor;
        RespDesc: Serenity.StringEditor;
        Msg: Serenity.StringEditor;
        Success: Serenity.StringEditor;
    }

    [['Version', () => Serenity.StringEditor], ['UserId', () => Serenity.IntegerEditor], ['Username', () => Serenity.StringEditor], ['Idnumber', () => Serenity.StringEditor], ['RespCode', () => Serenity.StringEditor], ['RespDesc', () => Serenity.StringEditor], ['Msg', () => Serenity.StringEditor], ['Success', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RongTuoForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

