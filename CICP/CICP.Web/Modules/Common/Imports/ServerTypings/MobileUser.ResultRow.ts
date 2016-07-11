
namespace CICP.MobileUser {
    export interface ResultRow {
        UserId?: number;
        Username?: string;
        Idnumber?: string;
        Data?: string;
        Msg?: string;
        Success?: string;
        IdnumberName?: string;
        IdnumberTel?: string;
        IdnumberOrderno?: string;
    }

    export namespace ResultRow {
        export const nameProperty = 'Username';
        export const localTextPrefix = 'MobileUser.Result';

        export namespace Fields {
            export declare const UserId;
            export declare const Username;
            export declare const Idnumber;
            export declare const Data;
            export declare const Msg;
            export declare const Success;
            export declare const IdnumberName: string;
            export declare const IdnumberTel: string;
            export declare const IdnumberOrderno: string;
        }

        ['UserId', 'Username', 'Idnumber', 'Data', 'Msg', 'Success', 'IdnumberName', 'IdnumberTel', 'IdnumberOrderno'].forEach(x => (<any>Fields)[x] = x);
    }
}

