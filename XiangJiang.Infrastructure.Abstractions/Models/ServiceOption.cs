using XiangJiang.Infrastructure.Abstractions.Enums;

namespace XiangJiang.Infrastructure.Abstractions.Models
{
    public sealed class ServiceOption
    {
        public ServiceOption()
        {
            StartPattern = ServiceStartPattern.Automatically;
            RunAs = ServiceRunAs.LocalSystem;
        }

        /// <summary>
        ///     服务说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     服务显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        ///     服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        ///     服务启动类型
        /// </summary>
        public ServiceStartPattern StartPattern { get; set; }

        /// <summary>
        ///     服务运行角色类型
        /// </summary>
        public ServiceRunAs RunAs { get; set; }
    }
}