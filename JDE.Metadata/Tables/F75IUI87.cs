using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI87 - .
/// </summary>
public class F75IUI87 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTJOBS.
        /// </summary>
        public const string TTJOBS = "TTJOBS";

        /// <summary>
        /// TTI75TXTY.
        /// </summary>
        public const string TTI75TXTY = "TTI75TXTY";

        /// <summary>
        /// TTSTAM.
        /// </summary>
        public const string TTSTAM = "TTSTAM";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";

        /// <summary>
        /// TTYFUTDT1.
        /// </summary>
        public const string TTYFUTDT1 = "TTYFUTDT1";

        /// <summary>
        /// TTYT04.
        /// </summary>
        public const string TTYT04 = "TTYT04";

        /// <summary>
        /// TTYFLAG.
        /// </summary>
        public const string TTYFLAG = "TTYFLAG";

        /// <summary>
        /// TTYNUM1.
        /// </summary>
        public const string TTYNUM1 = "TTYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI87";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTJOBS", "TTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TTI75TXTY", "TTI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("TTSTAM", "TTSTAM", JdeDataType.Numeric),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20, true, true),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric),
        new JdeField("TTYFUTDT1", "TTYFUTDT1", JdeDataType.Numeric),
        new JdeField("TTYT04", "TTYT04", JdeDataType.String, 2),
        new JdeField("TTYFLAG", "TTYFLAG", JdeDataType.String, 2),
        new JdeField("TTYNUM1", "TTYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI87_0", "Primary Key on TTJOBS, TTUSER, TTI75TXTY", new[] { "TTJOBS", "TTUSER", "TTI75TXTY" }, isUnique: true, isPrimaryKey: true)
    };
}
