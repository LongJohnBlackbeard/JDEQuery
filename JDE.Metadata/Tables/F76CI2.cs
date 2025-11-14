using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CI2 - .
/// </summary>
public class F76CI2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AECTTY.
        /// </summary>
        public const string AECTTY = "AECTTY";

        /// <summary>
        /// AEAC20.
        /// </summary>
        public const string AEAC20 = "AEAC20";

        /// <summary>
        /// AEAC07.
        /// </summary>
        public const string AEAC07 = "AEAC07";

        /// <summary>
        /// AEEFDJ.
        /// </summary>
        public const string AEEFDJ = "AEEFDJ";

        /// <summary>
        /// AEEFTJ.
        /// </summary>
        public const string AEEFTJ = "AEEFTJ";

        /// <summary>
        /// AEDL01.
        /// </summary>
        public const string AEDL01 = "AEDL01";

        /// <summary>
        /// AETXR1.
        /// </summary>
        public const string AETXR1 = "AETXR1";

        /// <summary>
        /// AEMTAX.
        /// </summary>
        public const string AEMTAX = "AEMTAX";

        /// <summary>
        /// AEUSER.
        /// </summary>
        public const string AEUSER = "AEUSER";

        /// <summary>
        /// AEPID.
        /// </summary>
        public const string AEPID = "AEPID";

        /// <summary>
        /// AEJOBN.
        /// </summary>
        public const string AEJOBN = "AEJOBN";

        /// <summary>
        /// AEUPMJ.
        /// </summary>
        public const string AEUPMJ = "AEUPMJ";

        /// <summary>
        /// AEUPMT.
        /// </summary>
        public const string AEUPMT = "AEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76CI2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AECTTY", "AECTTY", JdeDataType.String, 4, true, true),
        new JdeField("AEAC20", "AEAC20", JdeDataType.String, 6, true, true),
        new JdeField("AEAC07", "AEAC07", JdeDataType.String, 6, true, true),
        new JdeField("AEEFDJ", "AEEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("AEEFTJ", "AEEFTJ", JdeDataType.Numeric),
        new JdeField("AEDL01", "AEDL01", JdeDataType.String, 60),
        new JdeField("AETXR1", "AETXR1", JdeDataType.Numeric),
        new JdeField("AEMTAX", "AEMTAX", JdeDataType.Numeric),
        new JdeField("AEUSER", "AEUSER", JdeDataType.String, 20),
        new JdeField("AEPID", "AEPID", JdeDataType.String, 20),
        new JdeField("AEJOBN", "AEJOBN", JdeDataType.String, 20),
        new JdeField("AEUPMJ", "AEUPMJ", JdeDataType.Numeric),
        new JdeField("AEUPMT", "AEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CI2_0", "Primary Key on AECTTY, AEAC20, AEAC07, AEEFDJ", new[] { "AECTTY", "AEAC20", "AEAC07", "AEEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
