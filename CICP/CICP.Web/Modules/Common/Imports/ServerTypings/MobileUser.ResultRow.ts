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
        export const idProperty = 'Username';
        export const nameProperty = 'Username';
        export const localTextPrefix = 'MobileUser.Result';

        export namespace Fields {
            export declare const UserId: string;
            export declare const Username: string;
            export declare const Idnumber: string;
            export declare const Data: string;
            export declare const Msg: string;
            export declare const Success: string;
            export declare const IdnumberName: string;
            export declare const IdnumberTel: string;
            export declare const IdnumberOrderno: string;
        }

        ['UserId', 'Username', 'Idnumber', 'Data', 'Msg', 'Success', 'IdnumberName', 'IdnumberTel', 'IdnumberOrderno'].forEach(x => (<any>Fields)[x] = x);
    }
}

