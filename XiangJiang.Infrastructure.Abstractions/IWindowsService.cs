using XiangJiang.Infrastructure.Abstractions.Models;

namespace XiangJiang.Infrastructure.Abstractions
{
    /// <summary>
    ///     Windows 服务接口
    /// </summary>
    public interface IWindowsService
    {
        /// <summary>
        ///     启动服务
        /// </summary>
        /// <param name="args">参数</param>
        /// <param name="option">ServiceOption</param>
        void Start(string[] args, ServiceOption option);

        /// <summary>
        ///     停止服务
        /// </summary>
        void Stop();

        /// <summary>
        ///     服务暂停
        /// </summary>
        void Paused();

        /// <summary>
        ///     服务继续
        /// </summary>
        void Continued();
    }
}