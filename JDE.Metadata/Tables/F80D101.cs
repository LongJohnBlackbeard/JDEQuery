using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D101 - .
/// </summary>
public class F80D101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PUFBDUBE.
        /// </summary>
        public const string PUFBDUBE = "PUFBDUBE";

        /// <summary>
        /// PUUSER.
        /// </summary>
        public const string PUUSER = "PUUSER";

        /// <summary>
        /// PUPID.
        /// </summary>
        public const string PUPID = "PUPID";

        /// <summary>
        /// PUMKEY.
        /// </summary>
        public const string PUMKEY = "PUMKEY";

        /// <summary>
        /// PUUPMJ.
        /// </summary>
        public const string PUUPMJ = "PUUPMJ";

        /// <summary>
        /// PUUPMT.
        /// </summary>
        public const string PUUPMT = "PUUPMT";

        /// <summary>
        /// PUURCD.
        /// </summary>
        public const string PUURCD = "PUURCD";

        /// <summary>
        /// PUURDT.
        /// </summary>
        public const string PUURDT = "PUURDT";

        /// <summary>
        /// PUURAT.
        /// </summary>
        public const string PUURAT = "PUURAT";

        /// <summary>
        /// PUURAB.
        /// </summary>
        public const string PUURAB = "PUURAB";

        /// <summary>
        /// PUURRF.
        /// </summary>
        public const string PUURRF = "PUURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PUFBDUBE", "PUFBDUBE", JdeDataType.String, 20, true, true),
        new JdeField("PUUSER", "PUUSER", JdeDataType.String, 20),
        new JdeField("PUPID", "PUPID", JdeDataType.String, 20),
        new JdeField("PUMKEY", "PUMKEY", JdeDataType.String, 30),
        new JdeField("PUUPMJ", "PUUPMJ", JdeDataType.Numeric),
        new JdeField("PUUPMT", "PUUPMT", JdeDataType.Numeric),
        new JdeField("PUURCD", "PUURCD", JdeDataType.String, 4),
        new JdeField("PUURDT", "PUURDT", JdeDataType.Numeric),
        new JdeField("PUURAT", "PUURAT", JdeDataType.Numeric),
        new JdeField("PUURAB", "PUURAB", JdeDataType.Numeric),
        new JdeField("PUURRF", "PUURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D101_0", "Primary Key on PUFBDUBE", new[] { "PUFBDUBE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D101_2", "Index on PUFBDUBE, PUUPMJ, PUUPMT", new[] { "PUFBDUBE", "PUUPMJ", "PUUPMT" })
    };
}
