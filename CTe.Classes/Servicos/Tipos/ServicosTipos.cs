﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace CTeDLL.Classes.Servicos.Tipos
{
    public enum ServicoCTe
    {
        /// <summary>
        ///     serviço destinado à recepção de mensagem do Evento de Cancelamento da NF-e
        /// </summary>
        RecepcaoEventoCancelmento,

        /// <summary>
        ///     serviço destinado à recepção de mensagem do Evento de Carta de Correção da NF-e
        /// </summary>
        RecepcaoEventoCartaCorrecao,

        /// <summary>
        ///     serviço destinado à recepção de mensagem do Evento EPEC da NF-e
        /// </summary>
        RecepcaoEventoEpec,

        /// <summary>
        ///     serviço destinado à recepção de mensagem do Evento de Manifestação do destinatário da NF-e
        /// </summary>
        RecepcaoEventoManifestacaoDestinatario,

        /// <summary>
        ///     serviço destinado à recepção de mensagens de lote de NF-e versão 2.0
        /// </summary>
        CteRecepcao,

        /// <summary>
        ///     serviço destinado a retornar o resultado do processamento do lote de NF-e versão 2.0
        /// </summary>
        CteRetRecepcao,

        /// <summary>
        ///     Serviço para consultar o cadastro de contribuintes do ICMS da unidade federada
        /// </summary>
        CteConsultaCadastro,

        /// <summary>
        ///     serviço destinado ao atendimento de solicitações de inutilização de numeração
        /// </summary>
        CteInutilizacao,

        /// <summary>
        ///     serviço destinado ao atendimento de solicitações de consulta da situação atual da NF-e
        ///     na Base de Dados do Portal da Secretaria de Fazenda Estadual
        /// </summary>
        CteConsultaProtocolo,

        /// <summary>
        ///     serviço destinado à consulta do status do serviço prestado pelo Portal da Secretaria de Fazenda Estadual
        /// </summary>
        CteStatusServico,

        /// <summary>
        ///     serviço destinado à recepção de mensagens de lote de NF-e versão 3.10
        /// </summary>
        CteAutorizacao,

        /// <summary>
        ///     serviço destinado a retornar o resultado do processamento do lote de NF-e versão 3.10
        /// </summary>
        CteRetAutorizacao,

        /// <summary>
        ///     Distribui documentos e informações de interesse do ator da NF-e
        /// </summary>
        CteDistribuicaoDFe,

        /// <summary>
        ///     “Serviço de Consulta da Relação de Documentos Destinados” para um determinado CNPJ
        ///     de destinatário informado na NF-e.
        /// </summary>
        CteConsultaDest,

        /// <summary>
        ///     Serviço destinado ao atendimento de solicitações de download de Notas Fiscais Eletrônicas por seus destinatários
        /// </summary>
        CteDownloadNF
    }

    /// <summary>
    ///     Usado para discriminar o tipo de evento, pois o serviço de cancelamento e carta de correção devem usar a url
    ///     designada para UF da empresa, já o serviço EPEC usa a url do ambiente nacional
    /// </summary>
    public enum TipoRecepcaoEvento
    {
        Nenhum,
        Cancelamento,
        CartaCorrecao,
        Epec,
        ManifestacaoDestinatario
    }

    public enum TipoManifestacao
    {
        [Description("Confirmacao da Operacao")]
        [XmlEnum("Confirmacao da Operacao")]
        e210200,

        [Description("Ciencia da Operacao")]
        [XmlEnum("Ciencia da Operacao")]
        e210210,

        [Description("Desconhecimento da Operacao")]
        [XmlEnum("Desconhecimento da Operacao")]
        e210220,

        [Description("Operacao nao Realizada")]
        [XmlEnum("Operacao nao Realizada")]
        e210240
    }

    public enum VersaoServico
    {
        
        [XmlEnum("1.00")] ve100,
        [XmlEnum("2.00")] ve200,
        [XmlEnum("3.00")] ve300,
        [XmlEnum("3.10")] ve310
    }

    /// <summary>
    ///     Indicador de Sincronização:
    ///     <para>0 = Assíncrono. A resposta deve ser obtida consultando o serviço NFeRetAutorizacao, com o nº do recibo</para>
    ///     <para>
    ///         1 = Síncrono. Empresa solicita processamento síncrono do Lote de NF-e (sem a geração de Recibo para consulta
    ///         futura);
    ///     </para>
    /// </summary>
    public enum IndicadorSincronizacao
    {
        [XmlEnum("0")] Assincrono = 0,
        [XmlEnum("1")] Sincrono = 1
    }

    /// <summary>
    /// Tipo do evento de manifestação do destinatário.
    /// </summary>
    public enum TipoEventoManifestacaoDestinatario
    {
        [Description("Confirmacao da Operacao")]
        TeMdConfirmacaoDaOperacao = 210200,

        [Description("Ciencia da Operacao")]
        TeMdCienciaDaOperacao = 210210,

        [Description("Desconhecimento da Operacao")]
        TeMdDesconhecimentoDaOperacao = 210220,

        [Description("Operacao nao Realizada")]
        TeMdOperacaoNaoRealizada = 210240
    }
}