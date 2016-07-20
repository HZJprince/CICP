
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RongTuoDialog extends Serenity.EntityDialog<RongTuoRow, any> {
        protected getFormKey() { return RongTuoForm.formKey; }
        protected getIdProperty() { return RongTuoRow.idProperty; }
        protected getLocalTextPrefix() { return RongTuoRow.localTextPrefix; }
        protected getNameProperty() { return RongTuoRow.nameProperty; }
        protected getService() { return RongTuoService.baseUrl; }

        protected form = new RongTuoForm(this.idPrefix);
    }
}