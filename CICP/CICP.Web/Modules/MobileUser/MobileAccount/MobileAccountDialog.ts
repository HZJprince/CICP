
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MobileAccountDialog extends Serenity.EntityDialog<MobileAccountRow, any> {
        protected getFormKey() { return MobileAccountForm.formKey; }
        protected getIdProperty() { return MobileAccountRow.idProperty; }
        protected getLocalTextPrefix() { return MobileAccountRow.localTextPrefix; }
        protected getNameProperty() { return MobileAccountRow.nameProperty; }
        protected getService() { return MobileAccountService.baseUrl; }

        protected form = new MobileAccountForm(this.idPrefix);
    }
}