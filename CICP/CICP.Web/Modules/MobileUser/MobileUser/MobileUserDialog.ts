
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

        constructor() {
            super();

            this.form.Password.addValidationRule(this.uniqueName, e => {
                if (this.form.Password.value.length < 6)
                    return "Password must be at least 6 characters!";
            });

            this.form.PasswordConfirm.addValidationRule(this.uniqueName, e => {
                if (this.form.Password.value != this.form.PasswordConfirm.value)
                    return "The passwords entered doesn't match!";
            });
        }
    }
}