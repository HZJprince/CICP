
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    export class MobileAccountGrid extends Serenity.EntityGrid<MobileAccountRow, any> {
        protected getColumnsKey() { return 'MobileUser.MobileAccount'; }
        protected getDialogType() { return MobileAccountDialog; }
        protected getIdProperty() { return MobileAccountRow.idProperty; }
        protected getLocalTextPrefix() { return MobileAccountRow.localTextPrefix; }
        protected getService() { return MobileAccountService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}