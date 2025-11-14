using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A4111 - .
/// </summary>
public class F76A4111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILUKID.
        /// </summary>
        public const string ILUKID = "ILUKID";

        /// <summary>
        /// ILICUT.
        /// </summary>
        public const string ILICUT = "ILICUT";

        /// <summary>
        /// ILICU.
        /// </summary>
        public const string ILICU = "ILICU";

        /// <summary>
        /// ILTORG.
        /// </summary>
        public const string ILTORG = "ILTORG";

        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILPID.
        /// </summary>
        public const string ILPID = "ILPID";

        /// <summary>
        /// ILUPMJ.
        /// </summary>
        public const string ILUPMJ = "ILUPMJ";

        /// <summary>
        /// ILUPMT.
        /// </summary>
        public const string ILUPMT = "ILUPMT";

        /// <summary>
        /// ILJOBN.
        /// </summary>
        public const string ILJOBN = "ILJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A4111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILUKID", "ILUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ILICUT", "ILICUT", JdeDataType.String, 4),
        new JdeField("ILICU", "ILICU", JdeDataType.Numeric),
        new JdeField("ILTORG", "ILTORG", JdeDataType.String, 20),
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20),
        new JdeField("ILPID", "ILPID", JdeDataType.String, 20),
        new JdeField("ILUPMJ", "ILUPMJ", JdeDataType.Numeric),
        new JdeField("ILUPMT", "ILUPMT", JdeDataType.Numeric),
        new JdeField("ILJOBN", "ILJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A4111_0", "Primary Key on ILUKID", new[] { "ILUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A4111_2", "Index on ILICUT, ILICU", new[] { "ILICUT", "ILICU" })
    };
}
