using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I807 - .
/// </summary>
public class F75I807 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TXUKID.
        /// </summary>
        public const string TXUKID = "TXUKID";

        /// <summary>
        /// TXDOCO.
        /// </summary>
        public const string TXDOCO = "TXDOCO";

        /// <summary>
        /// TXDCTO.
        /// </summary>
        public const string TXDCTO = "TXDCTO";

        /// <summary>
        /// TXKCOO.
        /// </summary>
        public const string TXKCOO = "TXKCOO";

        /// <summary>
        /// TXLNID.
        /// </summary>
        public const string TXLNID = "TXLNID";

        /// <summary>
        /// TXSFXO.
        /// </summary>
        public const string TXSFXO = "TXSFXO";

        /// <summary>
        /// TXKCO.
        /// </summary>
        public const string TXKCO = "TXKCO";

        /// <summary>
        /// TXDCT.
        /// </summary>
        public const string TXDCT = "TXDCT";

        /// <summary>
        /// TXDOC.
        /// </summary>
        public const string TXDOC = "TXDOC";

        /// <summary>
        /// TXI75INVNO.
        /// </summary>
        public const string TXI75INVNO = "TXI75INVNO";

        /// <summary>
        /// TXSFX.
        /// </summary>
        public const string TXSFX = "TXSFX";

        /// <summary>
        /// TXVOD.
        /// </summary>
        public const string TXVOD = "TXVOD";

        /// <summary>
        /// TXI75TXRG.
        /// </summary>
        public const string TXI75TXRG = "TXI75TXRG";

        /// <summary>
        /// TXBCRC.
        /// </summary>
        public const string TXBCRC = "TXBCRC";

        /// <summary>
        /// TXCRR.
        /// </summary>
        public const string TXCRR = "TXCRR";

        /// <summary>
        /// TXATXA.
        /// </summary>
        public const string TXATXA = "TXATXA";

        /// <summary>
        /// TXI75TXTY.
        /// </summary>
        public const string TXI75TXTY = "TXI75TXTY";

        /// <summary>
        /// TXI75GSTRA.
        /// </summary>
        public const string TXI75GSTRA = "TXI75GSTRA";

        /// <summary>
        /// TXI75GSTR.
        /// </summary>
        public const string TXI75GSTR = "TXI75GSTR";

        /// <summary>
        /// TXSTAM.
        /// </summary>
        public const string TXSTAM = "TXSTAM";

        /// <summary>
        /// TXI75GSTNO.
        /// </summary>
        public const string TXI75GSTNO = "TXI75GSTNO";

        /// <summary>
        /// TXI75GSTNP.
        /// </summary>
        public const string TXI75GSTNP = "TXI75GSTNP";

        /// <summary>
        /// TXI75GSTNS.
        /// </summary>
        public const string TXI75GSTNS = "TXI75GSTNS";

        /// <summary>
        /// TXI75GSTU.
        /// </summary>
        public const string TXI75GSTU = "TXI75GSTU";

        /// <summary>
        /// TXPA8.
        /// </summary>
        public const string TXPA8 = "TXPA8";

        /// <summary>
        /// TXAN8.
        /// </summary>
        public const string TXAN8 = "TXAN8";

        /// <summary>
        /// TXI75ITTY.
        /// </summary>
        public const string TXI75ITTY = "TXI75ITTY";

        /// <summary>
        /// TXI75RECU.
        /// </summary>
        public const string TXI75RECU = "TXI75RECU";

        /// <summary>
        /// TXI75DFFG.
        /// </summary>
        public const string TXI75DFFG = "TXI75DFFG";

        /// <summary>
        /// TXI75DFPER.
        /// </summary>
        public const string TXI75DFPER = "TXI75DFPER";

        /// <summary>
        /// TXI75DEFVL.
        /// </summary>
        public const string TXI75DEFVL = "TXI75DEFVL";

        /// <summary>
        /// TXI75DEDT.
        /// </summary>
        public const string TXI75DEDT = "TXI75DEDT";

        /// <summary>
        /// TXI75FRC.
        /// </summary>
        public const string TXI75FRC = "TXI75FRC";

        /// <summary>
        /// TXI75PSP.
        /// </summary>
        public const string TXI75PSP = "TXI75PSP";

        /// <summary>
        /// TXI75PSR.
        /// </summary>
        public const string TXI75PSR = "TXI75PSR";

        /// <summary>
        /// TXI75PROVL.
        /// </summary>
        public const string TXI75PROVL = "TXI75PROVL";

        /// <summary>
        /// TXI75RECVL.
        /// </summary>
        public const string TXI75RECVL = "TXI75RECVL";

        /// <summary>
        /// TXI75REVBN.
        /// </summary>
        public const string TXI75REVBN = "TXI75REVBN";

        /// <summary>
        /// TXI75MCHFD.
        /// </summary>
        public const string TXI75MCHFD = "TXI75MCHFD";

        /// <summary>
        /// TXI75TXRL.
        /// </summary>
        public const string TXI75TXRL = "TXI75TXRL";

        /// <summary>
        /// TXI75HSNC.
        /// </summary>
        public const string TXI75HSNC = "TXI75HSNC";

        /// <summary>
        /// TXI75SERAC.
        /// </summary>
        public const string TXI75SERAC = "TXI75SERAC";

        /// <summary>
        /// TXAPGM.
        /// </summary>
        public const string TXAPGM = "TXAPGM";

        /// <summary>
        /// TXDGL.
        /// </summary>
        public const string TXDGL = "TXDGL";

        /// <summary>
        /// TXUSER.
        /// </summary>
        public const string TXUSER = "TXUSER";

        /// <summary>
        /// TXPID.
        /// </summary>
        public const string TXPID = "TXPID";

        /// <summary>
        /// TXUPMJ.
        /// </summary>
        public const string TXUPMJ = "TXUPMJ";

        /// <summary>
        /// TXUPMT.
        /// </summary>
        public const string TXUPMT = "TXUPMT";

        /// <summary>
        /// TXJOBN.
        /// </summary>
        public const string TXJOBN = "TXJOBN";

        /// <summary>
        /// TXYFUTDT1.
        /// </summary>
        public const string TXYFUTDT1 = "TXYFUTDT1";

        /// <summary>
        /// TXFUT6.
        /// </summary>
        public const string TXFUT6 = "TXFUT6";

        /// <summary>
        /// TXYT04.
        /// </summary>
        public const string TXYT04 = "TXYT04";

        /// <summary>
        /// TXYFLAG.
        /// </summary>
        public const string TXYFLAG = "TXYFLAG";

        /// <summary>
        /// TXICU.
        /// </summary>
        public const string TXICU = "TXICU";

        /// <summary>
        /// TXICUT.
        /// </summary>
        public const string TXICUT = "TXICUT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I807";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TXUKID", "TXUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TXDOCO", "TXDOCO", JdeDataType.Numeric),
        new JdeField("TXDCTO", "TXDCTO", JdeDataType.String, 4),
        new JdeField("TXKCOO", "TXKCOO", JdeDataType.String, 10),
        new JdeField("TXLNID", "TXLNID", JdeDataType.Numeric),
        new JdeField("TXSFXO", "TXSFXO", JdeDataType.String, 6),
        new JdeField("TXKCO", "TXKCO", JdeDataType.String, 10),
        new JdeField("TXDCT", "TXDCT", JdeDataType.String, 4),
        new JdeField("TXDOC", "TXDOC", JdeDataType.Numeric),
        new JdeField("TXI75INVNO", "TXI75INVNO", JdeDataType.String, 50),
        new JdeField("TXSFX", "TXSFX", JdeDataType.String, 6),
        new JdeField("TXVOD", "TXVOD", JdeDataType.String, 2),
        new JdeField("TXI75TXRG", "TXI75TXRG", JdeDataType.String, 10),
        new JdeField("TXBCRC", "TXBCRC", JdeDataType.String, 6),
        new JdeField("TXCRR", "TXCRR", JdeDataType.Numeric),
        new JdeField("TXATXA", "TXATXA", JdeDataType.Numeric),
        new JdeField("TXI75TXTY", "TXI75TXTY", JdeDataType.String, 10),
        new JdeField("TXI75GSTRA", "TXI75GSTRA", JdeDataType.String, 4),
        new JdeField("TXI75GSTR", "TXI75GSTR", JdeDataType.Numeric),
        new JdeField("TXSTAM", "TXSTAM", JdeDataType.Numeric),
        new JdeField("TXI75GSTNO", "TXI75GSTNO", JdeDataType.String, 50),
        new JdeField("TXI75GSTNP", "TXI75GSTNP", JdeDataType.String, 50),
        new JdeField("TXI75GSTNS", "TXI75GSTNS", JdeDataType.String, 50),
        new JdeField("TXI75GSTU", "TXI75GSTU", JdeDataType.Numeric),
        new JdeField("TXPA8", "TXPA8", JdeDataType.Numeric),
        new JdeField("TXAN8", "TXAN8", JdeDataType.Numeric),
        new JdeField("TXI75ITTY", "TXI75ITTY", JdeDataType.String, 12),
        new JdeField("TXI75RECU", "TXI75RECU", JdeDataType.String, 2),
        new JdeField("TXI75DFFG", "TXI75DFFG", JdeDataType.String, 2),
        new JdeField("TXI75DFPER", "TXI75DFPER", JdeDataType.Numeric),
        new JdeField("TXI75DEFVL", "TXI75DEFVL", JdeDataType.Numeric),
        new JdeField("TXI75DEDT", "TXI75DEDT", JdeDataType.Numeric),
        new JdeField("TXI75FRC", "TXI75FRC", JdeDataType.String, 2),
        new JdeField("TXI75PSP", "TXI75PSP", JdeDataType.Numeric),
        new JdeField("TXI75PSR", "TXI75PSR", JdeDataType.Numeric),
        new JdeField("TXI75PROVL", "TXI75PROVL", JdeDataType.Numeric),
        new JdeField("TXI75RECVL", "TXI75RECVL", JdeDataType.Numeric),
        new JdeField("TXI75REVBN", "TXI75REVBN", JdeDataType.Numeric),
        new JdeField("TXI75MCHFD", "TXI75MCHFD", JdeDataType.String, 2),
        new JdeField("TXI75TXRL", "TXI75TXRL", JdeDataType.String, 12),
        new JdeField("TXI75HSNC", "TXI75HSNC", JdeDataType.String, 40),
        new JdeField("TXI75SERAC", "TXI75SERAC", JdeDataType.String, 40),
        new JdeField("TXAPGM", "TXAPGM", JdeDataType.String, 20),
        new JdeField("TXDGL", "TXDGL", JdeDataType.Numeric),
        new JdeField("TXUSER", "TXUSER", JdeDataType.String, 20),
        new JdeField("TXPID", "TXPID", JdeDataType.String, 20),
        new JdeField("TXUPMJ", "TXUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TXUPMT", "TXUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("TXJOBN", "TXJOBN", JdeDataType.String, 20),
        new JdeField("TXYFUTDT1", "TXYFUTDT1", JdeDataType.Numeric),
        new JdeField("TXFUT6", "TXFUT6", JdeDataType.String, 60),
        new JdeField("TXYT04", "TXYT04", JdeDataType.String, 2),
        new JdeField("TXYFLAG", "TXYFLAG", JdeDataType.String, 2),
        new JdeField("TXICU", "TXICU", JdeDataType.Numeric),
        new JdeField("TXICUT", "TXICUT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I807_0", "Primary Key on TXUKID, TXUPMJ, TXUPMT", new[] { "TXUKID", "TXUPMJ", "TXUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I807_2", "Index on TXI75GSTU, TXDGL", new[] { "TXI75GSTU", "TXDGL" }),
        new JdeIndex("F75I807_3", "Index on TXDOC, TXDCT, TXKCO, TXSFX", new[] { "TXDOC", "TXDCT", "TXKCO", "TXSFX" })
    };
}
