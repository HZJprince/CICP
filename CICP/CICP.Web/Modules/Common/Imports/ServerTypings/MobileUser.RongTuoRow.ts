
namespace CICP.MobileUser {
    export interface RongTuoRow {
        Version?: string;
        UserId?: number;
        Username?: string;
        Idnumber?: string;
        RespCode?: string;
        RespDesc?: string;
        Msg?: string;
        Success?: string;
        IdnumberName?: string;
        IdnumberTel?: string;
        IdnumberOrderno?: string;
    }

    export namespace RongTuoRow {
        export const idProperty = 'Version';
        export const nameProperty = 'Version';
        export const localTextPrefix = 'MobileUser.RongTuo';

        export namespace Fields {
            export declare const Version;
            export declare const UserId;
            export declare const Username;
            export declare const Idnumber;
            export declare const RespCode;
            export declare const RespDesc;
            export declare const Msg;
            export declare const Success;
            export declare const IdnumberName: string;
            export declare const IdnumberTel: string;
            export declare const IdnumberOrderno: string;
        }

        ['Version', 'UserId', 'Username', 'Idnumber', 'RespCode', 'RespDesc', 'Msg', 'Success', 'IdnumberName', 'IdnumberTel', 'IdnumberOrderno'].forEach(x => (<any>Fields)[x] = x);
    }
}

