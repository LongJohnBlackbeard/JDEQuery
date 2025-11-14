using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5204 - .
/// </summary>
public class F5204 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GXRTNR.
        /// </summary>
        public const string GXRTNR = "GXRTNR";

        /// <summary>
        /// GXDL01.
        /// </summary>
        public const string GXDL01 = "GXDL01";

        /// <summary>
        /// GXPRET.
        /// </summary>
        public const string GXPRET = "GXPRET";

        /// <summary>
        /// GXPC.
        /// </summary>
        public const string GXPC = "GXPC";

        /// <summary>
        /// GXLNID.
        /// </summary>
        public const string GXLNID = "GXLNID";

        /// <summary>
        /// GXUSER.
        /// </summary>
        public const string GXUSER = "GXUSER";

        /// <summary>
        /// GXPID.
        /// </summary>
        public const string GXPID = "GXPID";

        /// <summary>
        /// GXJOBN.
        /// </summary>
        public const string GXJOBN = "GXJOBN";

        /// <summary>
        /// GXUPMJ.
        /// </summary>
        public const string GXUPMJ = "GXUPMJ";

        /// <summary>
        /// GXUPMT.
        /// </summary>
        public const string GXUPMT = "GXUPMT";

        /// <summary>
        /// GXRETSRC.
        /// </summary>
        public const string GXRETSRC = "GXRETSRC";

        /// <summary>
        /// GXRETCUM.
        /// </summary>
        public const string GXRETCUM = "GXRETCUM";

        /// <summary>
        /// GXRETIC.
        /// </summary>
        public const string GXRETIC = "GXRETIC";

        /// <summary>
        /// GXRETIF.
        /// </summary>
        public const string GXRETIF = "GXRETIF";

        /// <summary>
        /// GXRETIA.
        /// </summary>
        public const string GXRETIA = "GXRETIA";
    }

    /// <inheritdoc />
    public override string TableName => "F5204";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GXRTNR", "GXRTNR", JdeDataType.String, 6, true, true),
        new JdeField("GXDL01", "GXDL01", JdeDataType.String, 60),
        new JdeField("GXPRET", "GXPRET", JdeDataType.Numeric),
        new JdeField("GXPC", "GXPC", JdeDataType.Numeric),
        new JdeField("GXLNID", "GXLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("GXUSER", "GXUSER", JdeDataType.String, 20),
        new JdeField("GXPID", "GXPID", JdeDataType.String, 20),
        new JdeField("GXJOBN", "GXJOBN", JdeDataType.String, 20),
        new JdeField("GXUPMJ", "GXUPMJ", JdeDataType.Numeric),
        new JdeField("GXUPMT", "GXUPMT", JdeDataType.Numeric),
        new JdeField("GXRETSRC", "GXRETSRC", JdeDataType.String, 2),
        new JdeField("GXRETCUM", "GXRETCUM", JdeDataType.String, 2),
        new JdeField("GXRETIC", "GXRETIC", JdeDataType.String, 2),
        new JdeField("GXRETIF", "GXRETIF", JdeDataType.String, 2),
        new JdeField("GXRETIA", "GXRETIA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5204_0", "Primary Key on GXRTNR, GXLNID", new[] { "GXRTNR", "GXLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5204_4", "Index on GXRTNR, GXPC", new[] { "GXRTNR", "GXPC" })
    };
}
