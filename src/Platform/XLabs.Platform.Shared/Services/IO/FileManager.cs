#if !NETFX_CORE
using System;
using System.IO;
using System.IO.IsolatedStorage;

namespace XLabs.Platform.Services.IO
{
    public class FileManager : IFileManager
    {
        private readonly IsolatedStorageFile isolatedStorageFile;

        /// <summary>
        /// Initialized new instance of <see cref="FileManager"/> using user store for application.
        /// </summary>
        public FileManager() : this(IsolatedStorageFile.GetUserStoreForApplication())
        {
            
        }

        /// <summary>
        /// Initialized new instance of <see cref="FileManager"/>.
        /// </summary>
        /// <param name="isolatedStorageFile">Isolated storage file to use.</param>
        public FileManager(IsolatedStorageFile isolatedStorageFile)
        {
            this.isolatedStorageFile = isolatedStorageFile;
        }

        public bool DirectoryExists(string path)
        {
            return this.isolatedStorageFile.DirectoryExists(path);
        }

        public void CreateDirectory(string path)
        {
            this.isolatedStorageFile.CreateDirectory(path);
        }

        public Stream OpenFile(string path, FileMode mode, FileAccess access)
        {
            return this.isolatedStorageFile.OpenFile(path, (System.IO.FileMode)mode, (System.IO.FileAccess)access);
        }

        public Stream OpenFile(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return this.isolatedStorageFile.OpenFile(path, (System.IO.FileMode)mode, (System.IO.FileAccess)access, (System.IO.FileShare)share);
        }

        public bool FileExists(string path)
        {
            return this.isolatedStorageFile.FileExists(path);
        }

        public DateTimeOffset GetLastWriteTime(string path)
        {
            return this.isolatedStorageFile.GetLastWriteTime(path);
        }

        public void DeleteFile(string path)
        {
            this.isolatedStorageFile.DeleteFile(path);
        }

        public void DeleteDirectory(string path)
        {
            this.isolatedStorageFile.DeleteDirectory(path);
        }
    }
}
#endif