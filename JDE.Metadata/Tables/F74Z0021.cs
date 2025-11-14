using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Z0021 - .
/// </summary>
public class F74Z0021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZUKID.
        /// </summary>
        public const string CZUKID = "CZUKID";

        /// <summary>
        /// CZCO.
        /// </summary>
        public const string CZCO = "CZCO";

        /// <summary>
        /// CZDTFR.
        /// </summary>
        public const string CZDTFR = "CZDTFR";

        /// <summary>
        /// CZDTTO.
        /// </summary>
        public const string CZDTTO = "CZDTTO";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZPN.
        /// </summary>
        public const string CZPN = "CZPN";

        /// <summary>
        /// CZCFY.
        /// </summary>
        public const string CZCFY = "CZCFY";

        /// <summary>
        /// CZDATF01.
        /// </summary>
        public const string CZDATF01 = "CZDATF01";

        /// <summary>
        /// CZDEPFUT2.
        /// </summary>
        public const string CZDEPFUT2 = "CZDEPFUT2";

        /// <summary>
        /// CZACTFU1.
        /// </summary>
        public const string CZACTFU1 = "CZACTFU1";
    }

    /// <inheritdoc />
    public override string TableName => "F74Z0021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZUKID", "CZUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CZCO", "CZCO", JdeDataType.String, 10),
        new JdeField("CZDTFR", "CZDTFR", JdeDataType.Numeric),
        new JdeField("CZDTTO", "CZDTTO", JdeDataType.Numeric),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZPN", "CZPN", JdeDataType.Numeric),
        new JdeField("CZCFY", "CZCFY", JdeDataType.Numeric),
        new JdeField("CZDATF01", "CZDATF01", JdeDataType.Numeric),
        new JdeField("CZDEPFUT2", "CZDEPFUT2", JdeDataType.String, 60),
        new JdeField("CZACTFU1", "CZACTFU1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Z0021_0", "Primary Key on CZUKID", new[] { "CZUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
