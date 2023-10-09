﻿// THIS FILE IS PART OF WinFormium PROJECT
// THE WinFormium PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
//
// GITHUB: https://github.com/XuanchenLin/WinFormium
// EMail: xuanchenlin(at)msn.com QQ:19843266 WECHAT:linxuanchen1985

namespace WinFormium.CefGlue.Interop;
[StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
internal unsafe struct cef_media_sink_device_info_t
{
    public cef_string_t ip_address;
    public int port;
    public cef_string_t model_name;
}