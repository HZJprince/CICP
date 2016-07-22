
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

        protected getButtons() {
            var buttons = super.getButtons();

            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: RongTuoService.baseUrl + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));

            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                reportTitle: 'RongTuo List',
                columnTitles: {
                    'Discontinued': 'Dis.',
                },
                tableOptions: {
                    columnStyles: {
                        ProductID: {
                            columnWidth: 25,
                            halign: 'right'
                        },
                        Discountinued: {
                            columnWidth: 25
                        }
                    }
                }
            }));

            buttons.push(Common.JsonPost.createToolButton({
                service: RongTuoService.baseUrl + '/Json',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }))

            return buttons;
        }
    }
}