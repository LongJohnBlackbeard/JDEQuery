using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06042 - .
/// </summary>
public class F06042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JOFILE.
        /// </summary>
        public const string JOFILE = "JOFILE";

        /// <summary>
        /// JOAN8.
        /// </summary>
        public const string JOAN8 = "JOAN8";

        /// <summary>
        /// JODTAI.
        /// </summary>
        public const string JODTAI = "JODTAI";

        /// <summary>
        /// JOPHSD.
        /// </summary>
        public const string JOPHSD = "JOPHSD";

        /// <summary>
        /// JOEFDO.
        /// </summary>
        public const string JOEFDO = "JOEFDO";

        /// <summary>
        /// JOTRS.
        /// </summary>
        public const string JOTRS = "JOTRS";

        /// <summary>
        /// JOPPED.
        /// </summary>
        public const string JOPPED = "JOPPED";

        /// <summary>
        /// JOUSER.
        /// </summary>
        public const string JOUSER = "JOUSER";

        /// <summary>
        /// JOPID.
        /// </summary>
        public const string JOPID = "JOPID";

        /// <summary>
        /// JOUPMJ.
        /// </summary>
        public const string JOUPMJ = "JOUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JOFILE", "JOFILE", JdeDataType.String, 20, true, true),
        new JdeField("JOAN8", "JOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JODTAI", "JODTAI", JdeDataType.String, 20, true, true),
        new JdeField("JOPHSD", "JOPHSD", JdeDataType.String, 60),
        new JdeField("JOEFDO", "JOEFDO", JdeDataType.Numeric, null, true, true),
        new JdeField("JOTRS", "JOTRS", JdeDataType.String, 6),
        new JdeField("JOPPED", "JOPPED", JdeDataType.Numeric),
        new JdeField("JOUSER", "JOUSER", JdeDataType.String, 20),
        new JdeField("JOPID", "JOPID", JdeDataType.String, 20),
        new JdeField("JOUPMJ", "JOUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06042_0", "Primary Key on JOFILE, JOAN8, JODTAI, JOEFDO", new[] { "JOFILE", "JOAN8", "JODTAI", "JOEFDO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06042_2", "Index on JOFILE, JOAN8, JODTAI", new[] { "JOFILE", "JOAN8", "JODTAI" })
    };
}
