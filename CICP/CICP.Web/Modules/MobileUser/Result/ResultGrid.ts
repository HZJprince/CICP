
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    export class ResultGrid extends Serenity.EntityGrid<ResultRow, any> {
        protected getColumnsKey() { return 'MobileUser.Result'; }
        protected getDialogType() { return ResultDialog; }
        protected getLocalTextPrefix() { return ResultRow.localTextPrefix; }
        protected getService() { return ResultService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}