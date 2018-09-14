﻿namespace Essensoft.AspNetCore.Payment.JDPay
{
    public class JDPayOptions
    {
        public static readonly string DefaultClientName = "Payment.JDPay.Client";

        /// <summary>
        /// 商户号
        /// </summary>
        public string Merchant { get; set; }

        /// <summary>
        /// 京东DES秘钥
        /// </summary>
        public string DesKey { get; set; }

        /// <summary>
        /// 京东RSA公钥
        /// </summary>
        public string RsaPublicKey { get; set; }

        /// <summary>
        /// 商户RSA私钥
        /// </summary>
        public string RsaPrivateKey { get; set; }

        /// <summary>
        /// 京东代付 提交者会员号
        /// </summary>
        public string CustomerNo { get; set; }

        /// <summary>
        /// 京东代付 签名Key
        /// </summary>
        public string SingKey { get; set; }

        /// <summary>
        /// 京东代付 密钥文件密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 京东代付 密钥证书文件
        /// </summary>
        public string PrivateCret { get; set; }

        /// <summary>
        /// 京东代付 代付证书文件
        /// </summary>
        public string PublicCert { get; set; }

        /// <summary>
        /// 京东代付 加密类型 RSA
        /// </summary>
        public string EncryptType { get; set; } = "RSA";

        /// <summary>
        /// 京东代付 签名类型 SHA-256
        /// </summary>
        public string SignType { get; set; } = "SHA-256";
    }
}