using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49002 - .
/// </summary>
public class F49002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TXNMCU.
        /// </summary>
        public const string TXNMCU = "TXNMCU";

        /// <summary>
        /// TXMCU.
        /// </summary>
        public const string TXMCU = "TXMCU";

        /// <summary>
        /// TXSCBD.
        /// </summary>
        public const string TXSCBD = "TXSCBD";

        /// <summary>
        /// TXNMFC.
        /// </summary>
        public const string TXNMFC = "TXNMFC";

        /// <summary>
        /// TXSCC1.
        /// </summary>
        public const string TXSCC1 = "TXSCC1";

        /// <summary>
        /// TXSCC2.
        /// </summary>
        public const string TXSCC2 = "TXSCC2";

        /// <summary>
        /// TXSCC3.
        /// </summary>
        public const string TXSCC3 = "TXSCC3";

        /// <summary>
        /// TXWTUM.
        /// </summary>
        public const string TXWTUM = "TXWTUM";

        /// <summary>
        /// TXCVUM.
        /// </summary>
        public const string TXCVUM = "TXCVUM";

        /// <summary>
        /// TXVLUM.
        /// </summary>
        public const string TXVLUM = "TXVLUM";

        /// <summary>
        /// TXLUOM.
        /// </summary>
        public const string TXLUOM = "TXLUOM";

        /// <summary>
        /// TXPSPS.
        /// </summary>
        public const string TXPSPS = "TXPSPS";

        /// <summary>
        /// TXCSPS.
        /// </summary>
        public const string TXCSPS = "TXCSPS";

        /// <summary>
        /// TXLDAS.
        /// </summary>
        public const string TXLDAS = "TXLDAS";

        /// <summary>
        /// TXLDCS.
        /// </summary>
        public const string TXLDCS = "TXLDCS";

        /// <summary>
        /// TXDSRC.
        /// </summary>
        public const string TXDSRC = "TXDSRC";

        /// <summary>
        /// TXMXVP.
        /// </summary>
        public const string TXMXVP = "TXMXVP";

        /// <summary>
        /// TXRDLV.
        /// </summary>
        public const string TXRDLV = "TXRDLV";

        /// <summary>
        /// TXMPCS.
        /// </summary>
        public const string TXMPCS = "TXMPCS";

        /// <summary>
        /// TXRABN.
        /// </summary>
        public const string TXRABN = "TXRABN";

        /// <summary>
        /// TXSTAP.
        /// </summary>
        public const string TXSTAP = "TXSTAP";

        /// <summary>
        /// TXDGCP.
        /// </summary>
        public const string TXDGCP = "TXDGCP";

        /// <summary>
        /// TXILCP.
        /// </summary>
        public const string TXILCP = "TXILCP";

        /// <summary>
        /// TXCMCP.
        /// </summary>
        public const string TXCMCP = "TXCMCP";

        /// <summary>
        /// TXOT7Y.
        /// </summary>
        public const string TXOT7Y = "TXOT7Y";

        /// <summary>
        /// TXUSER.
        /// </summary>
        public const string TXUSER = "TXUSER";

        /// <summary>
        /// TXPID.
        /// </summary>
        public const string TXPID = "TXPID";

        /// <summary>
        /// TXJOBN.
        /// </summary>
        public const string TXJOBN = "TXJOBN";

        /// <summary>
        /// TXUPMJ.
        /// </summary>
        public const string TXUPMJ = "TXUPMJ";

        /// <summary>
        /// TXTDAY.
        /// </summary>
        public const string TXTDAY = "TXTDAY";

        /// <summary>
        /// TXSSPN.
        /// </summary>
        public const string TXSSPN = "TXSSPN";

        /// <summary>
        /// TXSSHD.
        /// </summary>
        public const string TXSSHD = "TXSSHD";

        /// <summary>
        /// TXMXPW.
        /// </summary>
        public const string TXMXPW = "TXMXPW";

        /// <summary>
        /// TXMXPV.
        /// </summary>
        public const string TXMXPV = "TXMXPV";

        /// <summary>
        /// TXYN01.
        /// </summary>
        public const string TXYN01 = "TXYN01";

        /// <summary>
        /// TXEDBF.
        /// </summary>
        public const string TXEDBF = "TXEDBF";
    }

    /// <inheritdoc />
    public override string TableName => "F49002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TXNMCU", "TXNMCU", JdeDataType.String, 24, true, true),
        new JdeField("TXMCU", "TXMCU", JdeDataType.String, 24),
        new JdeField("TXSCBD", "TXSCBD", JdeDataType.String, 2),
        new JdeField("TXNMFC", "TXNMFC", JdeDataType.String, 8),
        new JdeField("TXSCC1", "TXSCC1", JdeDataType.String, 8),
        new JdeField("TXSCC2", "TXSCC2", JdeDataType.String, 8),
        new JdeField("TXSCC3", "TXSCC3", JdeDataType.String, 8),
        new JdeField("TXWTUM", "TXWTUM", JdeDataType.String, 4),
        new JdeField("TXCVUM", "TXCVUM", JdeDataType.String, 4),
        new JdeField("TXVLUM", "TXVLUM", JdeDataType.String, 4),
        new JdeField("TXLUOM", "TXLUOM", JdeDataType.String, 4),
        new JdeField("TXPSPS", "TXPSPS", JdeDataType.String, 4),
        new JdeField("TXCSPS", "TXCSPS", JdeDataType.String, 4),
        new JdeField("TXLDAS", "TXLDAS", JdeDataType.String, 4),
        new JdeField("TXLDCS", "TXLDCS", JdeDataType.String, 4),
        new JdeField("TXDSRC", "TXDSRC", JdeDataType.String, 2),
        new JdeField("TXMXVP", "TXMXVP", JdeDataType.Numeric),
        new JdeField("TXRDLV", "TXRDLV", JdeDataType.String, 2),
        new JdeField("TXMPCS", "TXMPCS", JdeDataType.Numeric),
        new JdeField("TXRABN", "TXRABN", JdeDataType.Numeric),
        new JdeField("TXSTAP", "TXSTAP", JdeDataType.String, 6),
        new JdeField("TXDGCP", "TXDGCP", JdeDataType.String, 2),
        new JdeField("TXILCP", "TXILCP", JdeDataType.String, 2),
        new JdeField("TXCMCP", "TXCMCP", JdeDataType.String, 2),
        new JdeField("TXOT7Y", "TXOT7Y", JdeDataType.String, 2),
        new JdeField("TXUSER", "TXUSER", JdeDataType.String, 20),
        new JdeField("TXPID", "TXPID", JdeDataType.String, 20),
        new JdeField("TXJOBN", "TXJOBN", JdeDataType.String, 20),
        new JdeField("TXUPMJ", "TXUPMJ", JdeDataType.Numeric),
        new JdeField("TXTDAY", "TXTDAY", JdeDataType.Numeric),
        new JdeField("TXSSPN", "TXSSPN", JdeDataType.String, 4),
        new JdeField("TXSSHD", "TXSSHD", JdeDataType.String, 4),
        new JdeField("TXMXPW", "TXMXPW", JdeDataType.Numeric),
        new JdeField("TXMXPV", "TXMXPV", JdeDataType.Numeric),
        new JdeField("TXYN01", "TXYN01", JdeDataType.String, 2),
        new JdeField("TXEDBF", "TXEDBF", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49002_0", "Primary Key on TXNMCU", new[] { "TXNMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
