namespace CICP.Common {

    export interface JsonPostOptions {
        //grid: Serenity.DataGrid<any, any>;
        service: string;
        onViewSubmit: () => boolean;
        title?: string;
        hint?: string;
        separator?: boolean;
    }

    export namespace JsonPost {

        export function createToolButton(options: JsonPostOptions): Serenity.ToolButton {

            return {
                hint: Q.coalesce(options.title, 'JsonPost'),
                title: Q.coalesce(options.hint, ''),
                cssClass: 'approve-button',
                onClick: function () {
                    $.ajax({
                        type: "get",
                        url: "/services/MobileUser/RongTuo/Json",
                        dataType: "json",
                        success: function (data) {
                            $("#myPnl").html(data.data.respDesc);
                        },
                    })
                },
                separator: options.separator
            };
        }
    }
}