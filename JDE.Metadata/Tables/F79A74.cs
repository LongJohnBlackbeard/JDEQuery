using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A74 - .
/// </summary>
public class F79A74 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OI79AGIID.
        /// </summary>
        public const string OI79AGIID = "OI79AGIID";

        /// <summary>
        /// OI79AGIOID.
        /// </summary>
        public const string OI79AGIOID = "OI79AGIOID";

        /// <summary>
        /// OI79AGOID.
        /// </summary>
        public const string OI79AGOID = "OI79AGOID";

        /// <summary>
        /// OIBEFD.
        /// </summary>
        public const string OIBEFD = "OIBEFD";

        /// <summary>
        /// OIEEFD.
        /// </summary>
        public const string OIEEFD = "OIEEFD";

        /// <summary>
        /// OI79AGIC.
        /// </summary>
        public const string OI79AGIC = "OI79AGIC";

        /// <summary>
        /// OI79AGIPC.
        /// </summary>
        public const string OI79AGIPC = "OI79AGIPC";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OITDAY.
        /// </summary>
        public const string OITDAY = "OITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A74";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OI79AGIID", "OI79AGIID", JdeDataType.Numeric, null, true, true),
        new JdeField("OI79AGIOID", "OI79AGIOID", JdeDataType.Numeric),
        new JdeField("OI79AGOID", "OI79AGOID", JdeDataType.Numeric),
        new JdeField("OIBEFD", "OIBEFD", JdeDataType.Numeric),
        new JdeField("OIEEFD", "OIEEFD", JdeDataType.Numeric),
        new JdeField("OI79AGIC", "OI79AGIC", JdeDataType.String, 20),
        new JdeField("OI79AGIPC", "OI79AGIPC", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A74_0", "Primary Key on OI79AGIID", new[] { "OI79AGIID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A74_2", "Index on OI79AGOID, OI79AGIC, OIBEFD", new[] { "OI79AGOID", "OI79AGIC", "OIBEFD" }),
        new JdeIndex("F79A74_3", "Unique Index on OI79AGIOID, OI79AGOID, OI79AGIC, OIBEFD", new[] { "OI79AGIOID", "OI79AGOID", "OI79AGIC", "OIBEFD" }, isUnique: true)
    };
}
