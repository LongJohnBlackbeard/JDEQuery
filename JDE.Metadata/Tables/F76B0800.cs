using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0800 - .
/// </summary>
public class F76B0800 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABB76ATCT.
        /// </summary>
        public const string ABB76ATCT = "ABB76ATCT";

        /// <summary>
        /// ABJOBS.
        /// </summary>
        public const string ABJOBS = "ABJOBS";

        /// <summary>
        /// ABB76BLCK.
        /// </summary>
        public const string ABB76BLCK = "ABB76BLCK";

        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABB76URAB.
        /// </summary>
        public const string ABB76URAB = "ABB76URAB";

        /// <summary>
        /// ABB76URAT.
        /// </summary>
        public const string ABB76URAT = "ABB76URAT";

        /// <summary>
        /// ABB76URRF.
        /// </summary>
        public const string ABB76URRF = "ABB76URRF";

        /// <summary>
        /// ABB76URDT.
        /// </summary>
        public const string ABB76URDT = "ABB76URDT";

        /// <summary>
        /// ABB76URCD.
        /// </summary>
        public const string ABB76URCD = "ABB76URCD";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0800";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABB76ATCT", "ABB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("ABJOBS", "ABJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ABB76BLCK", "ABB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABB76URAB", "ABB76URAB", JdeDataType.Numeric),
        new JdeField("ABB76URAT", "ABB76URAT", JdeDataType.Numeric),
        new JdeField("ABB76URRF", "ABB76URRF", JdeDataType.String, 30),
        new JdeField("ABB76URDT", "ABB76URDT", JdeDataType.Numeric),
        new JdeField("ABB76URCD", "ABB76URCD", JdeDataType.String, 4),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0800_0", "Primary Key on ABB76ATCT, ABJOBS, ABB76BLCK, ABAN8", new[] { "ABB76ATCT", "ABJOBS", "ABB76BLCK", "ABAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
