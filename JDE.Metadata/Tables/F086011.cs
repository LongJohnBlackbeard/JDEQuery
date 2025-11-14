using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F086011 - .
/// </summary>
public class F086011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COESTB.
        /// </summary>
        public const string COESTB = "COESTB";

        /// <summary>
        /// COESTCND.
        /// </summary>
        public const string COESTCND = "COESTCND";

        /// <summary>
        /// COCALYEAR.
        /// </summary>
        public const string COCALYEAR = "COCALYEAR";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COMATH01.
        /// </summary>
        public const string COMATH01 = "COMATH01";

        /// <summary>
        /// COMATH02.
        /// </summary>
        public const string COMATH02 = "COMATH02";

        /// <summary>
        /// COEV01.
        /// </summary>
        public const string COEV01 = "COEV01";

        /// <summary>
        /// COEV02.
        /// </summary>
        public const string COEV02 = "COEV02";

        /// <summary>
        /// CODTA1.
        /// </summary>
        public const string CODTA1 = "CODTA1";

        /// <summary>
        /// CODTA2.
        /// </summary>
        public const string CODTA2 = "CODTA2";

        /// <summary>
        /// CODATE01.
        /// </summary>
        public const string CODATE01 = "CODATE01";

        /// <summary>
        /// CODATE02.
        /// </summary>
        public const string CODATE02 = "CODATE02";

        /// <summary>
        /// COESTMAXSZ.
        /// </summary>
        public const string COESTMAXSZ = "COESTMAXSZ";
    }

    /// <inheritdoc />
    public override string TableName => "F086011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COESTB", "COESTB", JdeDataType.Numeric, null, true, true),
        new JdeField("COESTCND", "COESTCND", JdeDataType.String, 12, true, true),
        new JdeField("COCALYEAR", "COCALYEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COMATH01", "COMATH01", JdeDataType.Numeric),
        new JdeField("COMATH02", "COMATH02", JdeDataType.Numeric),
        new JdeField("COEV01", "COEV01", JdeDataType.String, 2),
        new JdeField("COEV02", "COEV02", JdeDataType.String, 2),
        new JdeField("CODTA1", "CODTA1", JdeDataType.String, 512),
        new JdeField("CODTA2", "CODTA2", JdeDataType.String, 512),
        new JdeField("CODATE01", "CODATE01", JdeDataType.Numeric),
        new JdeField("CODATE02", "CODATE02", JdeDataType.Numeric),
        new JdeField("COESTMAXSZ", "COESTMAXSZ", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F086011_0", "Primary Key on COESTCND, COESTB, COCALYEAR", new[] { "COESTCND", "COESTB", "COCALYEAR" }, isUnique: true, isPrimaryKey: true)
    };
}
