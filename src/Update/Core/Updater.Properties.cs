﻿using System.Text;

namespace Update.Core
{
    partial class Updater
    {
        /// <summary>
        /// 获取或设置上传或下载时字符串编码方式,默认为 UTF-8
        /// </summary>
        public Encoding Encoding
        {
            get
            {
                this.CheckDisposed();
                return this.m_Client.Encoding;
            }
            set
            {
                this.CheckDisposed();
                this.m_Client.Encoding = value;
            }
        }
    }
}
