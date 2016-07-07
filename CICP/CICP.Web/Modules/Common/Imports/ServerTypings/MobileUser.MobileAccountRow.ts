namespace CICP.MobileUser {
    export interface MobileAccountRow {
        Name?: string;
        Tel?: string;
        Idnumber?: string;
        Orderno?: string;
    }

    export namespace MobileAccountRow {
        export const idProperty = 'Idnumber';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MobileUser.MobileAccount';

        export namespace Fields {
            export declare const Name: string;
            export declare const Tel: string;
            export declare const Idnumber: string;
            export declare const Orderno: string;
        }

        ['Name', 'Tel', 'Idnumber', 'Orderno'].forEach(x => (<any>Fields)[x] = x);
    }
}

