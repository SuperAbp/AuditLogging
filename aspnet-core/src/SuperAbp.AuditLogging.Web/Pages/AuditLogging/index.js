(function ($) {
    var l = abp.localization.getResource('AuditLogging');

    var _auditLoggingAppService = superAbp.auditLogging.auditLog;

    var _detailModal = new abp.ModalManager({
        viewUrl: abp.appPath + 'AuditLogging/DetailModal'
    });

    var _dataTable = null;

    $(function () {
        var _$wrapper = $('#AuditLogsWrapper');
        var _$table = _$wrapper.find('table');
        _dataTable = _$table.DataTable(
            abp.libs.datatables.normalizeConfiguration({
                order: [[1, 'asc']],
                processing: true,
                serverSide: true,
                scrollX: true,
                paging: true,
                ajax: abp.libs.datatables.createAjax(
                    _auditLoggingAppService.getList
                ),
                columnDefs: [
                    {
                        title: l("Actions"),
                        rowAction: {
                            items: [
                                {
                                    text: l('View'),
                                    action: function (data) {
                                        _detailModal.open({
                                            id: data.record.id,
                                        });
                                    },
                                },
                            ]
                        }
                    },
                    {
                        title: l('DisplayName:ApplicationName'),
                        data: 'applicationName'
                    },
                    {
                        title: l('DisplayName:ClientIpAddress'),
                        data: 'clientIpAddress',
                    },
                    {
                        title: l('DisplayName:HttpMethod'),
                        data: 'httpMethod',
                    }
                    ,
                    {
                        title: l('DisplayName:Url'),
                        data: 'url',
                    }
                    ,
                    {
                        title: l('DisplayName:ExecutionTime'),
                        data: 'executionTime',
                    }
                    ,
                    {
                        title: l('DisplayName:ExecutionDuration'),
                        data: 'executionDuration',
                    },
                    {
                        title: l('DisplayName:HttpStatusCode'),
                        data: 'httpStatusCode',
                    }
                ]
            })
        );
    });
})(jQuery);