using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08406 - .
/// </summary>
public class F08406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EKEKEYVER.
        /// </summary>
        public const string EKEKEYVER = "EKEKEYVER";

        /// <summary>
        /// EKERECEKEY.
        /// </summary>
        public const string EKERECEKEY = "EKERECEKEY";

        /// <summary>
        /// EKPID.
        /// </summary>
        public const string EKPID = "EKPID";

        /// <summary>
        /// EKUSER.
        /// </summary>
        public const string EKUSER = "EKUSER";

        /// <summary>
        /// EKMACH.
        /// </summary>
        public const string EKMACH = "EKMACH";

        /// <summary>
        /// EKUPMJ.
        /// </summary>
        public const string EKUPMJ = "EKUPMJ";

        /// <summary>
        /// EKUPMT.
        /// </summary>
        public const string EKUPMT = "EKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EKEKEYVER", "EKEKEYVER", JdeDataType.Numeric, null, true, true),
        new JdeField("EKERECEKEY", "EKERECEKEY", JdeDataType.String),
        new JdeField("EKPID", "EKPID", JdeDataType.String, 20),
        new JdeField("EKUSER", "EKUSER", JdeDataType.String, 20),
        new JdeField("EKMACH", "EKMACH", JdeDataType.String, 24),
        new JdeField("EKUPMJ", "EKUPMJ", JdeDataType.Numeric),
        new JdeField("EKUPMT", "EKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08406_0", "Primary Key on EKEKEYVER", new[] { "EKEKEYVER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08406_2", "Index on SYS_NC00008$", new[] { "SYS_NC00008$" })
    };
}
