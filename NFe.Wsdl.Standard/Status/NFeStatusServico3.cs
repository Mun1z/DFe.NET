﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace NFe.Wsdl.Status
{
    public class NfeStatusServico3 : INfeServico
    {
        public NfeStatusServico3(string url, X509Certificate certificado, int timeOut)
        {
            throw new NotImplementedException("Nfe Status de Servico 3.0 não está implementado para .net standard, apenas .net framework");
        }

        public nfeCabecMsg nfeCabecMsg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public XmlNode Execute(XmlNode nfeDadosMsg)
        {
            throw new NotImplementedException();
        }
    }
}
