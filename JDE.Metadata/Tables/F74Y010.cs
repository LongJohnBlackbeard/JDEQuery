using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y010 - .
/// </summary>
public class F74Y010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLCTR.
        /// </summary>
        public const string BLCTR = "BLCTR";

        /// <summary>
        /// BLTXA1.
        /// </summary>
        public const string BLTXA1 = "BLTXA1";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLJOBN.
        /// </summary>
        public const string BLJOBN = "BLJOBN";

        /// <summary>
        /// BLUPMJ.
        /// </summary>
        public const string BLUPMJ = "BLUPMJ";

        /// <summary>
        /// BLUPMT.
        /// </summary>
        public const string BLUPMT = "BLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLCTR", "BLCTR", JdeDataType.String, 6, true, true),
        new JdeField("BLTXA1", "BLTXA1", JdeDataType.String, 20, true, true),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLJOBN", "BLJOBN", JdeDataType.String, 20),
        new JdeField("BLUPMJ", "BLUPMJ", JdeDataType.Numeric),
        new JdeField("BLUPMT", "BLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y010_0", "Primary Key on BLCTR, BLTXA1", new[] { "BLCTR", "BLTXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
