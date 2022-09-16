using System;
using System.Threading.Tasks;
using SuperAbp.AuditLogging.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Snow.AuditLogging.Admin
{
    /// <summary>
    /// 日志管理
    /// </summary>
    public interface IAuditLogAppService : IApplicationService
    {
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="input">查询参数</param>
        /// <returns></returns>
        Task<PagedResultDto<AuditLogListDto>> GetListAsync(GetAuditLogsInput input);

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        Task<AuditLogDetailDto> GetDetailAsync(Guid id);
    }
}