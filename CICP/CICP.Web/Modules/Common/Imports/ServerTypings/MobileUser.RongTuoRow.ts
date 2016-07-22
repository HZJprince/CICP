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
            export declare const Version: string;
            export declare const UserId: string;
            export declare const Username: string;
            export declare const Idnumber: string;
            export declare const RespCode: string;
            export declare const RespDesc: string;
            export declare const Msg: string;
            export declare const Success: string;
            export declare const IdnumberName: string;
            export declare const IdnumberTel: string;
            export declare const IdnumberOrderno: string;
        }

        ['Version', 'UserId', 'Username', 'Idnumber', 'RespCode', 'RespDesc', 'Msg', 'Success', 'IdnumberName', 'IdnumberTel', 'IdnumberOrderno'].forEach(x => (<any>Fields)[x] = x);
    }
}

