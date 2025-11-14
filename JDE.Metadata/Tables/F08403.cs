using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08403 - .
/// </summary>
public class F08403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EIAN8.
        /// </summary>
        public const string EIAN8 = "EIAN8";

        /// <summary>
        /// EINURC.
        /// </summary>
        public const string EINURC = "EINURC";

        /// <summary>
        /// EISHFT.
        /// </summary>
        public const string EISHFT = "EISHFT";

        /// <summary>
        /// EISPYN.
        /// </summary>
        public const string EISPYN = "EISPYN";

        /// <summary>
        /// EITVPC.
        /// </summary>
        public const string EITVPC = "EITVPC";

        /// <summary>
        /// EIPID.
        /// </summary>
        public const string EIPID = "EIPID";

        /// <summary>
        /// EIUSER.
        /// </summary>
        public const string EIUSER = "EIUSER";

        /// <summary>
        /// EIMKEY.
        /// </summary>
        public const string EIMKEY = "EIMKEY";

        /// <summary>
        /// EIUPMJ.
        /// </summary>
        public const string EIUPMJ = "EIUPMJ";

        /// <summary>
        /// EIUPMT.
        /// </summary>
        public const string EIUPMT = "EIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EIAN8", "EIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EINURC", "EINURC", JdeDataType.Numeric),
        new JdeField("EISHFT", "EISHFT", JdeDataType.String, 2),
        new JdeField("EISPYN", "EISPYN", JdeDataType.String, 2),
        new JdeField("EITVPC", "EITVPC", JdeDataType.String, 6),
        new JdeField("EIPID", "EIPID", JdeDataType.String, 20),
        new JdeField("EIUSER", "EIUSER", JdeDataType.String, 20),
        new JdeField("EIMKEY", "EIMKEY", JdeDataType.String, 30),
        new JdeField("EIUPMJ", "EIUPMJ", JdeDataType.Numeric),
        new JdeField("EIUPMT", "EIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08403_0", "Primary Key on EIAN8", new[] { "EIAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08403_2", "Index on EINURC", new[] { "EINURC" })
    };
}
