using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0075 - .
/// </summary>
public class F0075 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCEMPLOYID.
        /// </summary>
        public const string CCEMPLOYID = "CCEMPLOYID";

        /// <summary>
        /// CCPMTMETH.
        /// </summary>
        public const string CCPMTMETH = "CCPMTMETH";

        /// <summary>
        /// CCCRCRDNUM.
        /// </summary>
        public const string CCCRCRDNUM = "CCCRCRDNUM";

        /// <summary>
        /// CCCCEXPDATE.
        /// </summary>
        public const string CCCCEXPDATE = "CCCCEXPDATE";

        /// <summary>
        /// CCCCAN8.
        /// </summary>
        public const string CCCCAN8 = "CCCCAN8";

        /// <summary>
        /// CCCCRCRCY.
        /// </summary>
        public const string CCCCRCRCY = "CCCCRCRCY";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0075";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCEMPLOYID", "CCEMPLOYID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCPMTMETH", "CCPMTMETH", JdeDataType.String, 6, true, true),
        new JdeField("CCCRCRDNUM", "CCCRCRDNUM", JdeDataType.String, 50),
        new JdeField("CCCCEXPDATE", "CCCCEXPDATE", JdeDataType.Numeric),
        new JdeField("CCCCAN8", "CCCCAN8", JdeDataType.Numeric),
        new JdeField("CCCCRCRCY", "CCCCRCRCY", JdeDataType.String, 6),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0075_0", "Primary Key on CCEMPLOYID, CCPMTMETH", new[] { "CCEMPLOYID", "CCPMTMETH" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0075_2", "Index on CCPMTMETH", new[] { "CCPMTMETH" }),
        new JdeIndex("F0075_3", "Index on CCCRCRDNUM", new[] { "CCCRCRDNUM" }),
        new JdeIndex("F0075_4", "Index on CCEMPLOYID, CCCCAN8", new[] { "CCEMPLOYID", "CCCCAN8" }),
        new JdeIndex("F0075_5", "Index on CCPMTMETH, CCCRCRDNUM", new[] { "CCPMTMETH", "CCCRCRDNUM" })
    };
}
