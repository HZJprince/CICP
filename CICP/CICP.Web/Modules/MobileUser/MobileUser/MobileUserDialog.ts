
namespace CICP.MobileUser {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MobileUserDialog extends Serenity.EntityDialog<MobileUserRow, any> {
        protected getFormKey() { return MobileUserForm.formKey; }
        protected getIdProperty() { return MobileUserRow.idProperty; }
        protected getLocalTextPrefix() { return MobileUserRow.localTextPrefix; }
        protected getNameProperty() { return MobileUserRow.nameProperty; }
        protected getService() { return MobileUserService.baseUrl; }

        protected form = new MobileUserForm(this.idPrefix);
    }
}