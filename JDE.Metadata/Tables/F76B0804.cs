using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0804 - .
/// </summary>
public class F76B0804 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ANB76ATCT.
        /// </summary>
        public const string ANB76ATCT = "ANB76ATCT";

        /// <summary>
        /// ANJOBS.
        /// </summary>
        public const string ANJOBS = "ANJOBS";

        /// <summary>
        /// ANB76BLCK.
        /// </summary>
        public const string ANB76BLCK = "ANB76BLCK";

        /// <summary>
        /// ANNUMB.
        /// </summary>
        public const string ANNUMB = "ANNUMB";

        /// <summary>
        /// ANB76URAB.
        /// </summary>
        public const string ANB76URAB = "ANB76URAB";

        /// <summary>
        /// ANB76URAT.
        /// </summary>
        public const string ANB76URAT = "ANB76URAT";

        /// <summary>
        /// ANB76URRF.
        /// </summary>
        public const string ANB76URRF = "ANB76URRF";

        /// <summary>
        /// ANB76URDT.
        /// </summary>
        public const string ANB76URDT = "ANB76URDT";

        /// <summary>
        /// ANB76URCD.
        /// </summary>
        public const string ANB76URCD = "ANB76URCD";

        /// <summary>
        /// ANUSER.
        /// </summary>
        public const string ANUSER = "ANUSER";

        /// <summary>
        /// ANPID.
        /// </summary>
        public const string ANPID = "ANPID";

        /// <summary>
        /// ANJOBN.
        /// </summary>
        public const string ANJOBN = "ANJOBN";

        /// <summary>
        /// ANUPMJ.
        /// </summary>
        public const string ANUPMJ = "ANUPMJ";

        /// <summary>
        /// ANUPMT.
        /// </summary>
        public const string ANUPMT = "ANUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0804";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ANB76ATCT", "ANB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("ANJOBS", "ANJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ANB76BLCK", "ANB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("ANNUMB", "ANNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("ANB76URAB", "ANB76URAB", JdeDataType.Numeric),
        new JdeField("ANB76URAT", "ANB76URAT", JdeDataType.Numeric),
        new JdeField("ANB76URRF", "ANB76URRF", JdeDataType.String, 30),
        new JdeField("ANB76URDT", "ANB76URDT", JdeDataType.Numeric),
        new JdeField("ANB76URCD", "ANB76URCD", JdeDataType.String, 4),
        new JdeField("ANUSER", "ANUSER", JdeDataType.String, 20),
        new JdeField("ANPID", "ANPID", JdeDataType.String, 20),
        new JdeField("ANJOBN", "ANJOBN", JdeDataType.String, 20),
        new JdeField("ANUPMJ", "ANUPMJ", JdeDataType.Numeric),
        new JdeField("ANUPMT", "ANUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0804_0", "Primary Key on ANB76ATCT, ANJOBS, ANB76BLCK, ANNUMB", new[] { "ANB76ATCT", "ANJOBS", "ANB76BLCK", "ANNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
