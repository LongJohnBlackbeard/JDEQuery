using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B421 - .
/// </summary>
public class F76B421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKAN8.
        /// </summary>
        public const string TKAN8 = "TKAN8";

        /// <summary>
        /// TKITM.
        /// </summary>
        public const string TKITM = "TKITM";

        /// <summary>
        /// TKB76SVTC.
        /// </summary>
        public const string TKB76SVTC = "TKB76SVTC";

        /// <summary>
        /// TKB76ISSS.
        /// </summary>
        public const string TKB76ISSS = "TKB76ISSS";

        /// <summary>
        /// TKB76BTPIS.
        /// </summary>
        public const string TKB76BTPIS = "TKB76BTPIS";

        /// <summary>
        /// TKB76PISS.
        /// </summary>
        public const string TKB76PISS = "TKB76PISS";

        /// <summary>
        /// TKB76COFWC.
        /// </summary>
        public const string TKB76COFWC = "TKB76COFWC";

        /// <summary>
        /// TKB76COFS.
        /// </summary>
        public const string TKB76COFS = "TKB76COFS";

        /// <summary>
        /// TKB76CSLLWC.
        /// </summary>
        public const string TKB76CSLLWC = "TKB76CSLLWC";

        /// <summary>
        /// TKB76CSLLS.
        /// </summary>
        public const string TKB76CSLLS = "TKB76CSLLS";

        /// <summary>
        /// TKB76INSSWC.
        /// </summary>
        public const string TKB76INSSWC = "TKB76INSSWC";

        /// <summary>
        /// TKB76INSSS.
        /// </summary>
        public const string TKB76INSSS = "TKB76INSSS";

        /// <summary>
        /// TKB76IRPJWC.
        /// </summary>
        public const string TKB76IRPJWC = "TKB76IRPJWC";

        /// <summary>
        /// TKB76IRS.
        /// </summary>
        public const string TKB76IRS = "TKB76IRS";

        /// <summary>
        /// TKTORG.
        /// </summary>
        public const string TKTORG = "TKTORG";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKAN8", "TKAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TKITM", "TKITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TKB76SVTC", "TKB76SVTC", JdeDataType.String, 20),
        new JdeField("TKB76ISSS", "TKB76ISSS", JdeDataType.String, 2),
        new JdeField("TKB76BTPIS", "TKB76BTPIS", JdeDataType.String, 16),
        new JdeField("TKB76PISS", "TKB76PISS", JdeDataType.String, 2),
        new JdeField("TKB76COFWC", "TKB76COFWC", JdeDataType.String, 16),
        new JdeField("TKB76COFS", "TKB76COFS", JdeDataType.String, 2),
        new JdeField("TKB76CSLLWC", "TKB76CSLLWC", JdeDataType.String, 16),
        new JdeField("TKB76CSLLS", "TKB76CSLLS", JdeDataType.String, 2),
        new JdeField("TKB76INSSWC", "TKB76INSSWC", JdeDataType.String, 16),
        new JdeField("TKB76INSSS", "TKB76INSSS", JdeDataType.String, 2),
        new JdeField("TKB76IRPJWC", "TKB76IRPJWC", JdeDataType.String, 16),
        new JdeField("TKB76IRS", "TKB76IRS", JdeDataType.String, 2),
        new JdeField("TKTORG", "TKTORG", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B421_0", "Primary Key on TKAN8, TKITM", new[] { "TKAN8", "TKITM" }, isUnique: true, isPrimaryKey: true)
    };
}
