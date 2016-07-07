
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    export class MobileUserGrid extends Serenity.EntityGrid<MobileUserRow, any> {
        protected getColumnsKey() { return 'MobileUser.MobileUser'; }
        protected getDialogType() { return MobileUserDialog; }
        protected getIdProperty() { return MobileUserRow.idProperty; }
        protected getLocalTextPrefix() { return MobileUserRow.localTextPrefix; }
        protected getService() { return MobileUserService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getDefaultSortBy() {
            return [MobileUserRow.Fields.Username];
        }
    }
}