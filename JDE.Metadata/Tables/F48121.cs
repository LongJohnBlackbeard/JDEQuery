using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48121 - .
/// </summary>
public class F48121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WYUSER.
        /// </summary>
        public const string WYUSER = "WYUSER";

        /// <summary>
        /// WYDGL.
        /// </summary>
        public const string WYDGL = "WYDGL";

        /// <summary>
        /// WYIVD.
        /// </summary>
        public const string WYIVD = "WYIVD";

        /// <summary>
        /// WYKCOI.
        /// </summary>
        public const string WYKCOI = "WYKCOI";

        /// <summary>
        /// WYBTFR.
        /// </summary>
        public const string WYBTFR = "WYBTFR";

        /// <summary>
        /// WYBTDT.
        /// </summary>
        public const string WYBTDT = "WYBTDT";

        /// <summary>
        /// WYERDB.
        /// </summary>
        public const string WYERDB = "WYERDB";

        /// <summary>
        /// WYDCTI.
        /// </summary>
        public const string WYDCTI = "WYDCTI";

        /// <summary>
        /// WYIIVS.
        /// </summary>
        public const string WYIIVS = "WYIIVS";

        /// <summary>
        /// WYVERI.
        /// </summary>
        public const string WYVERI = "WYVERI";

        /// <summary>
        /// WYSBSK.
        /// </summary>
        public const string WYSBSK = "WYSBSK";

        /// <summary>
        /// WYUPMJ.
        /// </summary>
        public const string WYUPMJ = "WYUPMJ";

        /// <summary>
        /// WYUPMT.
        /// </summary>
        public const string WYUPMT = "WYUPMT";

        /// <summary>
        /// WYPID.
        /// </summary>
        public const string WYPID = "WYPID";

        /// <summary>
        /// WYJOBN.
        /// </summary>
        public const string WYJOBN = "WYJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F48121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WYUSER", "WYUSER", JdeDataType.String, 20, true, true),
        new JdeField("WYDGL", "WYDGL", JdeDataType.Numeric),
        new JdeField("WYIVD", "WYIVD", JdeDataType.Numeric),
        new JdeField("WYKCOI", "WYKCOI", JdeDataType.String, 10),
        new JdeField("WYBTFR", "WYBTFR", JdeDataType.Numeric),
        new JdeField("WYBTDT", "WYBTDT", JdeDataType.Numeric),
        new JdeField("WYERDB", "WYERDB", JdeDataType.String, 2),
        new JdeField("WYDCTI", "WYDCTI", JdeDataType.String, 4),
        new JdeField("WYIIVS", "WYIIVS", JdeDataType.String, 20),
        new JdeField("WYVERI", "WYVERI", JdeDataType.String, 20),
        new JdeField("WYSBSK", "WYSBSK", JdeDataType.String, 8),
        new JdeField("WYUPMJ", "WYUPMJ", JdeDataType.Numeric),
        new JdeField("WYUPMT", "WYUPMT", JdeDataType.Numeric),
        new JdeField("WYPID", "WYPID", JdeDataType.String, 20),
        new JdeField("WYJOBN", "WYJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48121_0", "Primary Key on WYUSER", new[] { "WYUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
