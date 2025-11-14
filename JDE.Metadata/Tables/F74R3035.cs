using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3035 - .
/// </summary>
public class F74R3035 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCRCD.
        /// </summary>
        public const string CCCRCD = "CCCRCD";

        /// <summary>
        /// CCR74DCC.
        /// </summary>
        public const string CCR74DCC = "CCR74DCC";

        /// <summary>
        /// CCR74ACC.
        /// </summary>
        public const string CCR74ACC = "CCR74ACC";

        /// <summary>
        /// CCR74CN.
        /// </summary>
        public const string CCR74CN = "CCR74CN";

        /// <summary>
        /// CCR74CT.
        /// </summary>
        public const string CCR74CT = "CCR74CT";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCURCD.
        /// </summary>
        public const string CCURCD = "CCURCD";

        /// <summary>
        /// CCURDT.
        /// </summary>
        public const string CCURDT = "CCURDT";

        /// <summary>
        /// CCURAT.
        /// </summary>
        public const string CCURAT = "CCURAT";

        /// <summary>
        /// CCURAB.
        /// </summary>
        public const string CCURAB = "CCURAB";

        /// <summary>
        /// CCURRF.
        /// </summary>
        public const string CCURRF = "CCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3035";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCRCD", "CCCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CCR74DCC", "CCR74DCC", JdeDataType.String, 6),
        new JdeField("CCR74ACC", "CCR74ACC", JdeDataType.String, 20),
        new JdeField("CCR74CN", "CCR74CN", JdeDataType.String, 200),
        new JdeField("CCR74CT", "CCR74CT", JdeDataType.String, 200),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCURCD", "CCURCD", JdeDataType.String, 4),
        new JdeField("CCURDT", "CCURDT", JdeDataType.Numeric),
        new JdeField("CCURAT", "CCURAT", JdeDataType.Numeric),
        new JdeField("CCURAB", "CCURAB", JdeDataType.Numeric),
        new JdeField("CCURRF", "CCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3035_0", "Primary Key on CCCRCD", new[] { "CCCRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
