﻿namespace Lirmi.Challenge.Data.Transport.Core.Response
{
    public class BaseStateResponse
    {
        public bool HasError { get; set; }
        public int? CodigoError { get; set; }
        public string? TipoError { get; set; }
        public string? MensajeError { get; set; }
        public string? MensajeDetalle { get; set; }
    }
}
