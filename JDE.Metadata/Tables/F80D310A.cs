using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D310A - .
/// </summary>
public class F80D310A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATALERT.
        /// </summary>
        public const string ATALERT = "ATALERT";

        /// <summary>
        /// ATOSTP.
        /// </summary>
        public const string ATOSTP = "ATOSTP";

        /// <summary>
        /// ATPA8.
        /// </summary>
        public const string ATPA8 = "ATPA8";

        /// <summary>
        /// ATALERTACT.
        /// </summary>
        public const string ATALERTACT = "ATALERTACT";

        /// <summary>
        /// ATURCD.
        /// </summary>
        public const string ATURCD = "ATURCD";

        /// <summary>
        /// ATURDT.
        /// </summary>
        public const string ATURDT = "ATURDT";

        /// <summary>
        /// ATURAT.
        /// </summary>
        public const string ATURAT = "ATURAT";

        /// <summary>
        /// ATURAB.
        /// </summary>
        public const string ATURAB = "ATURAB";

        /// <summary>
        /// ATURRF.
        /// </summary>
        public const string ATURRF = "ATURRF";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATMKEY.
        /// </summary>
        public const string ATMKEY = "ATMKEY";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATUUPMJ.
        /// </summary>
        public const string ATUUPMJ = "ATUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D310A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATALERT", "ATALERT", JdeDataType.Numeric, null, true, true),
        new JdeField("ATOSTP", "ATOSTP", JdeDataType.String, 6),
        new JdeField("ATPA8", "ATPA8", JdeDataType.Numeric),
        new JdeField("ATALERTACT", "ATALERTACT", JdeDataType.String, 2),
        new JdeField("ATURCD", "ATURCD", JdeDataType.String, 4),
        new JdeField("ATURDT", "ATURDT", JdeDataType.Numeric),
        new JdeField("ATURAT", "ATURAT", JdeDataType.Numeric),
        new JdeField("ATURAB", "ATURAB", JdeDataType.Numeric),
        new JdeField("ATURRF", "ATURRF", JdeDataType.String, 30),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATMKEY", "ATMKEY", JdeDataType.String, 30),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATUUPMJ", "ATUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D310A_0", "Primary Key on ATALERT", new[] { "ATALERT" }, isUnique: true, isPrimaryKey: true)
    };
}
