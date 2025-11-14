using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051428 - .
/// </summary>
public class F051428 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWGRPNAME.
        /// </summary>
        public const string RWGRPNAME = "RWGRPNAME";

        /// <summary>
        /// RWWORDID.
        /// </summary>
        public const string RWWORDID = "RWWORDID";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWPID.
        /// </summary>
        public const string RWPID = "RWPID";

        /// <summary>
        /// RWMKEY.
        /// </summary>
        public const string RWMKEY = "RWMKEY";

        /// <summary>
        /// RWUPMJ.
        /// </summary>
        public const string RWUPMJ = "RWUPMJ";

        /// <summary>
        /// RWUPMT.
        /// </summary>
        public const string RWUPMT = "RWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051428";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWGRPNAME", "RWGRPNAME", JdeDataType.String, 60, true, true),
        new JdeField("RWWORDID", "RWWORDID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20),
        new JdeField("RWPID", "RWPID", JdeDataType.String, 20),
        new JdeField("RWMKEY", "RWMKEY", JdeDataType.String, 30),
        new JdeField("RWUPMJ", "RWUPMJ", JdeDataType.Numeric),
        new JdeField("RWUPMT", "RWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051428_0", "Primary Key on RWGRPNAME, RWWORDID", new[] { "RWGRPNAME", "RWWORDID" }, isUnique: true, isPrimaryKey: true)
    };
}
