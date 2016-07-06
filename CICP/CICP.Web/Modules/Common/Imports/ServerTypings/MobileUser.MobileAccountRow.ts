
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
            export declare const Name;
            export declare const Tel;
            export declare const Idnumber;
            export declare const Orderno;
        }

        ['Name', 'Tel', 'Idnumber', 'Orderno'].forEach(x => (<any>Fields)[x] = x);
    }
}

