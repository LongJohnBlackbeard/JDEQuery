using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B470 - .
/// </summary>
public class F03B470 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGPWPG.
        /// </summary>
        public const string PGPWPG = "PGPWPG";

        /// <summary>
        /// PGPWPS.
        /// </summary>
        public const string PGPWPS = "PGPWPS";

        /// <summary>
        /// PGPID.
        /// </summary>
        public const string PGPID = "PGPID";

        /// <summary>
        /// PGUSER.
        /// </summary>
        public const string PGUSER = "PGUSER";

        /// <summary>
        /// PGMKEY.
        /// </summary>
        public const string PGMKEY = "PGMKEY";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";

        /// <summary>
        /// PGUPMT.
        /// </summary>
        public const string PGUPMT = "PGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F03B470";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGPWPG", "PGPWPG", JdeDataType.Numeric, null, true, true),
        new JdeField("PGPWPS", "PGPWPS", JdeDataType.String, 2),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGMKEY", "PGMKEY", JdeDataType.String, 30),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGUPMT", "PGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B470_0", "Primary Key on PGPWPG", new[] { "PGPWPG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B470_2", "Index on PGPWPS", new[] { "PGPWPS" })
    };
}
