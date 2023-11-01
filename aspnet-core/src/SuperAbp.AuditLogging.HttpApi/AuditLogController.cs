using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperAbp.AuditLogging.Dtos;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace SuperAbp.AuditLogging
{
    /// <summary>
    /// 日志管理
    /// </summary>
    [RemoteService(Name = AuditLoggingRemoteServiceConsts.RemoteServiceName)]
    [Area(AuditLoggingRemoteServiceConsts.ModuleName)]
    [ControllerName("AuditLog")]
    [Route("api/audit-logging")]
    public class AuditLogController : AuditLoggingController, IAuditLogAppService
    {
        protected IAuditLogAppService AuditLogAppService { get; }

        public AuditLogController(IAuditLogAppService auditLogAppService)
        {
            AuditLogAppService = auditLogAppService;
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public virtual async Task<AuditLogDetailDto> GetDetailAsync(Guid id)
        {
            return await AuditLogAppService.GetDetailAsync(id);
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="input">查询参数</param>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<PagedResultDto<AuditLogListDto>> GetListAsync(GetAuditLogsInput input)
        {
            return await AuditLogAppService.GetListAsync(input);
        }
    }
}