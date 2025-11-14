using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41013 - .
/// </summary>
public class F41013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UNUPN.
        /// </summary>
        public const string UNUPN = "UNUPN";

        /// <summary>
        /// UNUPNTYP.
        /// </summary>
        public const string UNUPNTYP = "UNUPNTYP";

        /// <summary>
        /// UNITM.
        /// </summary>
        public const string UNITM = "UNITM";

        /// <summary>
        /// UNAN8.
        /// </summary>
        public const string UNAN8 = "UNAN8";

        /// <summary>
        /// UNUM.
        /// </summary>
        public const string UNUM = "UNUM";

        /// <summary>
        /// UNURDT.
        /// </summary>
        public const string UNURDT = "UNURDT";

        /// <summary>
        /// UNURCD.
        /// </summary>
        public const string UNURCD = "UNURCD";

        /// <summary>
        /// UNURRF.
        /// </summary>
        public const string UNURRF = "UNURRF";

        /// <summary>
        /// UNUSER.
        /// </summary>
        public const string UNUSER = "UNUSER";

        /// <summary>
        /// UNPID.
        /// </summary>
        public const string UNPID = "UNPID";

        /// <summary>
        /// UNUPMJ.
        /// </summary>
        public const string UNUPMJ = "UNUPMJ";

        /// <summary>
        /// UNTDAY.
        /// </summary>
        public const string UNTDAY = "UNTDAY";

        /// <summary>
        /// UNMKEY.
        /// </summary>
        public const string UNMKEY = "UNMKEY";

        /// <summary>
        /// UNSVRNAME.
        /// </summary>
        public const string UNSVRNAME = "UNSVRNAME";
    }

    /// <inheritdoc />
    public override string TableName => "F41013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UNUPN", "UNUPN", JdeDataType.String, 60, true, true),
        new JdeField("UNUPNTYP", "UNUPNTYP", JdeDataType.String, 10),
        new JdeField("UNITM", "UNITM", JdeDataType.Numeric),
        new JdeField("UNAN8", "UNAN8", JdeDataType.Numeric),
        new JdeField("UNUM", "UNUM", JdeDataType.String, 4),
        new JdeField("UNURDT", "UNURDT", JdeDataType.Numeric),
        new JdeField("UNURCD", "UNURCD", JdeDataType.String, 4),
        new JdeField("UNURRF", "UNURRF", JdeDataType.String, 30),
        new JdeField("UNUSER", "UNUSER", JdeDataType.String, 20),
        new JdeField("UNPID", "UNPID", JdeDataType.String, 20),
        new JdeField("UNUPMJ", "UNUPMJ", JdeDataType.Numeric),
        new JdeField("UNTDAY", "UNTDAY", JdeDataType.Numeric),
        new JdeField("UNMKEY", "UNMKEY", JdeDataType.String, 30),
        new JdeField("UNSVRNAME", "UNSVRNAME", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41013_0", "Primary Key on UNUPN", new[] { "UNUPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41013_2", "Index on UNUPNTYP, UNITM, UNUM, UNAN8", new[] { "UNUPNTYP", "UNITM", "UNUM", "UNAN8" })
    };
}
