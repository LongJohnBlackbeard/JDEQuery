using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S341 - .
/// </summary>
public class F74S341 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VFS740103.
        /// </summary>
        public const string VFS740103 = "VFS740103";

        /// <summary>
        /// VFS740102.
        /// </summary>
        public const string VFS740102 = "VFS740102";

        /// <summary>
        /// VFBST.
        /// </summary>
        public const string VFBST = "VFBST";

        /// <summary>
        /// VFS740100.
        /// </summary>
        public const string VFS740100 = "VFS740100";

        /// <summary>
        /// VFS740101.
        /// </summary>
        public const string VFS740101 = "VFS740101";

        /// <summary>
        /// VFJOBN.
        /// </summary>
        public const string VFJOBN = "VFJOBN";

        /// <summary>
        /// VFUPMJ.
        /// </summary>
        public const string VFUPMJ = "VFUPMJ";

        /// <summary>
        /// VFUPMT.
        /// </summary>
        public const string VFUPMT = "VFUPMT";

        /// <summary>
        /// VFUSER.
        /// </summary>
        public const string VFUSER = "VFUSER";

        /// <summary>
        /// VFPID.
        /// </summary>
        public const string VFPID = "VFPID";
    }

    /// <inheritdoc />
    public override string TableName => "F74S341";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VFS740103", "VFS740103", JdeDataType.String, 26, true, true),
        new JdeField("VFS740102", "VFS740102", JdeDataType.String, 2),
        new JdeField("VFBST", "VFBST", JdeDataType.String, 2),
        new JdeField("VFS740100", "VFS740100", JdeDataType.Numeric),
        new JdeField("VFS740101", "VFS740101", JdeDataType.String, 4),
        new JdeField("VFJOBN", "VFJOBN", JdeDataType.String, 20),
        new JdeField("VFUPMJ", "VFUPMJ", JdeDataType.Numeric),
        new JdeField("VFUPMT", "VFUPMT", JdeDataType.Numeric),
        new JdeField("VFUSER", "VFUSER", JdeDataType.String, 20),
        new JdeField("VFPID", "VFPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S341_0", "Primary Key on VFS740103", new[] { "VFS740103" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S341_2", "Index on VFS740100, VFS740101", new[] { "VFS740100", "VFS740101" })
    };
}
