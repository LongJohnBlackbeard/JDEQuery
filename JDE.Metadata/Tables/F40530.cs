using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40530 - .
/// </summary>
public class F40530 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SXAN8V.
        /// </summary>
        public const string SXAN8V = "SXAN8V";

        /// <summary>
        /// SXCMDSUP.
        /// </summary>
        public const string SXCMDSUP = "SXCMDSUP";

        /// <summary>
        /// SXCMDSUPDS.
        /// </summary>
        public const string SXCMDSUPDS = "SXCMDSUPDS";

        /// <summary>
        /// SXMCU.
        /// </summary>
        public const string SXMCU = "SXMCU";

        /// <summary>
        /// SXCMDCDE.
        /// </summary>
        public const string SXCMDCDE = "SXCMDCDE";

        /// <summary>
        /// SXUSER.
        /// </summary>
        public const string SXUSER = "SXUSER";

        /// <summary>
        /// SXPID.
        /// </summary>
        public const string SXPID = "SXPID";

        /// <summary>
        /// SXJOBN.
        /// </summary>
        public const string SXJOBN = "SXJOBN";

        /// <summary>
        /// SXUPMT.
        /// </summary>
        public const string SXUPMT = "SXUPMT";

        /// <summary>
        /// SXUPMJ.
        /// </summary>
        public const string SXUPMJ = "SXUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40530";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SXAN8V", "SXAN8V", JdeDataType.Numeric, null, true, true),
        new JdeField("SXCMDSUP", "SXCMDSUP", JdeDataType.String, 60, true, true),
        new JdeField("SXCMDSUPDS", "SXCMDSUPDS", JdeDataType.String, 60),
        new JdeField("SXMCU", "SXMCU", JdeDataType.String, 24, true, true),
        new JdeField("SXCMDCDE", "SXCMDCDE", JdeDataType.String, 30),
        new JdeField("SXUSER", "SXUSER", JdeDataType.String, 20),
        new JdeField("SXPID", "SXPID", JdeDataType.String, 20),
        new JdeField("SXJOBN", "SXJOBN", JdeDataType.String, 20),
        new JdeField("SXUPMT", "SXUPMT", JdeDataType.Numeric),
        new JdeField("SXUPMJ", "SXUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40530_0", "Primary Key on SXAN8V, SXCMDSUP, SXMCU", new[] { "SXAN8V", "SXCMDSUP", "SXMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40530_3", "Index on SXAN8V, SXMCU", new[] { "SXAN8V", "SXMCU" }),
        new JdeIndex("F40530_4", "Index on SXAN8V, SXMCU, SXCMDCDE", new[] { "SXAN8V", "SXMCU", "SXCMDCDE" }),
        new JdeIndex("F40530_5", "Index on SXCMDCDE", new[] { "SXCMDCDE" })
    };
}
