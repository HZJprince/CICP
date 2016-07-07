namespace CICP.MobileUser {
    export interface MobileUserRow {
        Username?: string;
        Password?: string;
        Ipaddress?: string;
        PasswordConfirm?: string;
    }

    export namespace MobileUserRow {
        export const idProperty = 'Username';
        export const nameProperty = 'Username';
        export const localTextPrefix = 'MobileUser.MobileUser';

        export namespace Fields {
            export declare const Username: string;
            export declare const Password: string;
            export declare const Ipaddress: string;
            export declare const PasswordConfirm: string;
        }

        ['Username', 'Password', 'Ipaddress', 'PasswordConfirm'].forEach(x => (<any>Fields)[x] = x);
    }
}

