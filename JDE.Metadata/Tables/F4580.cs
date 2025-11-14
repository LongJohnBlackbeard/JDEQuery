using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4580 - .
/// </summary>
public class F4580 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MXMXNAME.
        /// </summary>
        public const string MXMXNAME = "MXMXNAME";

        /// <summary>
        /// MXAST.
        /// </summary>
        public const string MXAST = "MXAST";

        /// <summary>
        /// MXRGRPID.
        /// </summary>
        public const string MXRGRPID = "MXRGRPID";

        /// <summary>
        /// MXCGRPID.
        /// </summary>
        public const string MXCGRPID = "MXCGRPID";

        /// <summary>
        /// MXRCATCD.
        /// </summary>
        public const string MXRCATCD = "MXRCATCD";

        /// <summary>
        /// MXCCATCD.
        /// </summary>
        public const string MXCCATCD = "MXCCATCD";

        /// <summary>
        /// MXUSER.
        /// </summary>
        public const string MXUSER = "MXUSER";

        /// <summary>
        /// MXPID.
        /// </summary>
        public const string MXPID = "MXPID";

        /// <summary>
        /// MXMKEY.
        /// </summary>
        public const string MXMKEY = "MXMKEY";

        /// <summary>
        /// MXUPMJ.
        /// </summary>
        public const string MXUPMJ = "MXUPMJ";

        /// <summary>
        /// MXUPMT.
        /// </summary>
        public const string MXUPMT = "MXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4580";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MXMXNAME", "MXMXNAME", JdeDataType.String, 60, true, true),
        new JdeField("MXAST", "MXAST", JdeDataType.String, 16),
        new JdeField("MXRGRPID", "MXRGRPID", JdeDataType.String, 16),
        new JdeField("MXCGRPID", "MXCGRPID", JdeDataType.String, 16),
        new JdeField("MXRCATCD", "MXRCATCD", JdeDataType.String, 20),
        new JdeField("MXCCATCD", "MXCCATCD", JdeDataType.String, 20),
        new JdeField("MXUSER", "MXUSER", JdeDataType.String, 20),
        new JdeField("MXPID", "MXPID", JdeDataType.String, 20),
        new JdeField("MXMKEY", "MXMKEY", JdeDataType.String, 30),
        new JdeField("MXUPMJ", "MXUPMJ", JdeDataType.Numeric),
        new JdeField("MXUPMT", "MXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4580_0", "Primary Key on MXMXNAME", new[] { "MXMXNAME" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4580_2", "Index on MXAST", new[] { "MXAST" })
    };
}
