
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ResultDialog extends Serenity.EntityDialog<ResultRow, any> {
        protected getFormKey() { return ResultForm.formKey; }
        protected getLocalTextPrefix() { return ResultRow.localTextPrefix; }
        protected getNameProperty() { return ResultRow.nameProperty; }
        protected getService() { return ResultService.baseUrl; }

        protected form = new ResultForm(this.idPrefix);
    }
}