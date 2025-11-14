using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7307 - .
/// </summary>
public class F7307 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VXDCTO.
        /// </summary>
        public const string VXDCTO = "VXDCTO";

        /// <summary>
        /// VXLNTY.
        /// </summary>
        public const string VXLNTY = "VXLNTY";

        /// <summary>
        /// VXVVTC.
        /// </summary>
        public const string VXVVTC = "VXVVTC";

        /// <summary>
        /// VXVVTY.
        /// </summary>
        public const string VXVVTY = "VXVVTY";

        /// <summary>
        /// VXUSER.
        /// </summary>
        public const string VXUSER = "VXUSER";

        /// <summary>
        /// VXPID.
        /// </summary>
        public const string VXPID = "VXPID";

        /// <summary>
        /// VXJOBN.
        /// </summary>
        public const string VXJOBN = "VXJOBN";

        /// <summary>
        /// VXUPMJ.
        /// </summary>
        public const string VXUPMJ = "VXUPMJ";

        /// <summary>
        /// VXTDAY.
        /// </summary>
        public const string VXTDAY = "VXTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7307";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VXDCTO", "VXDCTO", JdeDataType.String, 4, true, true),
        new JdeField("VXLNTY", "VXLNTY", JdeDataType.String, 4, true, true),
        new JdeField("VXVVTC", "VXVVTC", JdeDataType.String, 20),
        new JdeField("VXVVTY", "VXVVTY", JdeDataType.String, 12),
        new JdeField("VXUSER", "VXUSER", JdeDataType.String, 20),
        new JdeField("VXPID", "VXPID", JdeDataType.String, 20),
        new JdeField("VXJOBN", "VXJOBN", JdeDataType.String, 20),
        new JdeField("VXUPMJ", "VXUPMJ", JdeDataType.Numeric),
        new JdeField("VXTDAY", "VXTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7307_0", "Primary Key on VXDCTO, VXLNTY", new[] { "VXDCTO", "VXLNTY" }, isUnique: true, isPrimaryKey: true)
    };
}
