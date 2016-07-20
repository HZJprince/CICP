
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    export class RongTuoGrid extends Serenity.EntityGrid<RongTuoRow, any> {
        protected getColumnsKey() { return 'MobileUser.RongTuo'; }
        protected getDialogType() { return RongTuoDialog; }
        protected getIdProperty() { return RongTuoRow.idProperty; }
        protected getLocalTextPrefix() { return RongTuoRow.localTextPrefix; }
        protected getService() { return RongTuoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}