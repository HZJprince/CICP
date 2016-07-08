
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

        constructor() {
            super();

            this.form.Idnumber.addValidationRule(this.uniqueName, e => {
                if (this.form.Idnumber.value.length != 18 || this.form.Idnumber.value.length != 15)
                    return "身份证号位数不正确!";
            });

            this.form.Tel.addValidationRule(this.uniqueName, e => {
                if (this.form.Tel.value.length != 11)
                    return "手机号码位数不正确!";
            });
        }
    }
}