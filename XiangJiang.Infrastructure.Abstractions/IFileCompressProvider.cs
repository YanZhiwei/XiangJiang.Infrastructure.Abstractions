namespace XiangJiang.Infrastructure.Abstractions
{
    public interface IFileCompressProvider
    {
        /// <summary>
        ///     压缩文件夹
        /// </summary>
        /// <param name="compressFolder">需要压缩的文件夹</param>
        /// <param name="zipFile">压缩文件存放路径</param>
        /// <param name="compressionLevel">压缩级别</param>
        /// <param name="password">压缩密码</param>
        void Compress(string compressFolder, string zipFile, int compressionLevel = 9,
            string password = null);

        /// <summary>
        ///     解压文件
        /// </summary>
        /// <param name="zipFile">zip文件</param>
        /// <param name="extractFolder">解压文件夹</param>
        /// <param name="password">压缩密码</param>
        void Extract(string zipFile, string extractFolder, string password = null);
    }
}