using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I830 - .
/// </summary>
public class F75I830 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDEFDJ.
        /// </summary>
        public const string CDEFDJ = "CDEFDJ";

        /// <summary>
        /// CDI75TTYP.
        /// </summary>
        public const string CDI75TTYP = "CDI75TTYP";

        /// <summary>
        /// CDI75TXTY.
        /// </summary>
        public const string CDI75TXTY = "CDI75TXTY";

        /// <summary>
        /// CDI75OFPER.
        /// </summary>
        public const string CDI75OFPER = "CDI75OFPER";

        /// <summary>
        /// CDI75PRTY.
        /// </summary>
        public const string CDI75PRTY = "CDI75PRTY";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDYFUTDT1.
        /// </summary>
        public const string CDYFUTDT1 = "CDYFUTDT1";

        /// <summary>
        /// CDFUT6.
        /// </summary>
        public const string CDFUT6 = "CDFUT6";

        /// <summary>
        /// CDYT04.
        /// </summary>
        public const string CDYT04 = "CDYT04";

        /// <summary>
        /// CDYFLAG.
        /// </summary>
        public const string CDYFLAG = "CDYFLAG";

        /// <summary>
        /// CDYNUM1.
        /// </summary>
        public const string CDYNUM1 = "CDYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I830";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDEFDJ", "CDEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDI75TTYP", "CDI75TTYP", JdeDataType.String, 10, true, true),
        new JdeField("CDI75TXTY", "CDI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("CDI75OFPER", "CDI75OFPER", JdeDataType.Numeric),
        new JdeField("CDI75PRTY", "CDI75PRTY", JdeDataType.Numeric),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDYFUTDT1", "CDYFUTDT1", JdeDataType.Numeric),
        new JdeField("CDFUT6", "CDFUT6", JdeDataType.String, 60),
        new JdeField("CDYT04", "CDYT04", JdeDataType.String, 2),
        new JdeField("CDYFLAG", "CDYFLAG", JdeDataType.String, 2),
        new JdeField("CDYNUM1", "CDYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I830_0", "Primary Key on CDEFDJ, CDI75TTYP, CDI75TXTY", new[] { "CDEFDJ", "CDI75TTYP", "CDI75TXTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I830_2", "Index on CDEFDJ, CDI75PRTY, CDI75TTYP, CDI75TXTY", new[] { "CDEFDJ", "CDI75PRTY", "CDI75TTYP", "CDI75TXTY" })
    };
}
