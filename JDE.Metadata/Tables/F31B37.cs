using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B37 - .
/// </summary>
public class F31B37 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GAGOAID.
        /// </summary>
        public const string GAGOAID = "GAGOAID";

        /// <summary>
        /// GAGOAREA.
        /// </summary>
        public const string GAGOAREA = "GAGOAREA";

        /// <summary>
        /// GAGOANAME.
        /// </summary>
        public const string GAGOANAME = "GAGOANAME";

        /// <summary>
        /// GAGOATYPE.
        /// </summary>
        public const string GAGOATYPE = "GAGOATYPE";

        /// <summary>
        /// GAGOAHL.
        /// </summary>
        public const string GAGOAHL = "GAGOAHL";

        /// <summary>
        /// GAAGOCODE.
        /// </summary>
        public const string GAAGOCODE = "GAAGOCODE";

        /// <summary>
        /// GASCODE.
        /// </summary>
        public const string GASCODE = "GASCODE";

        /// <summary>
        /// GASORDNO.
        /// </summary>
        public const string GASORDNO = "GASORDNO";

        /// <summary>
        /// GAGECM.
        /// </summary>
        public const string GAGECM = "GAGECM";

        /// <summary>
        /// GAURCD.
        /// </summary>
        public const string GAURCD = "GAURCD";

        /// <summary>
        /// GAURDT.
        /// </summary>
        public const string GAURDT = "GAURDT";

        /// <summary>
        /// GAURAT.
        /// </summary>
        public const string GAURAT = "GAURAT";

        /// <summary>
        /// GAURRF.
        /// </summary>
        public const string GAURRF = "GAURRF";

        /// <summary>
        /// GAURAB.
        /// </summary>
        public const string GAURAB = "GAURAB";

        /// <summary>
        /// GAUSER.
        /// </summary>
        public const string GAUSER = "GAUSER";

        /// <summary>
        /// GAPID.
        /// </summary>
        public const string GAPID = "GAPID";

        /// <summary>
        /// GAJOBN.
        /// </summary>
        public const string GAJOBN = "GAJOBN";

        /// <summary>
        /// GAUPMJ.
        /// </summary>
        public const string GAUPMJ = "GAUPMJ";

        /// <summary>
        /// GAUPMT.
        /// </summary>
        public const string GAUPMT = "GAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B37";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GAGOAID", "GAGOAID", JdeDataType.Numeric, null, true, true),
        new JdeField("GAGOAREA", "GAGOAREA", JdeDataType.String, 8),
        new JdeField("GAGOANAME", "GAGOANAME", JdeDataType.String, 60),
        new JdeField("GAGOATYPE", "GAGOATYPE", JdeDataType.String, 4),
        new JdeField("GAGOAHL", "GAGOAHL", JdeDataType.Numeric),
        new JdeField("GAAGOCODE", "GAAGOCODE", JdeDataType.String, 8),
        new JdeField("GASCODE", "GASCODE", JdeDataType.String, 2),
        new JdeField("GASORDNO", "GASORDNO", JdeDataType.Numeric),
        new JdeField("GAGECM", "GAGECM", JdeDataType.String, 80),
        new JdeField("GAURCD", "GAURCD", JdeDataType.String, 4),
        new JdeField("GAURDT", "GAURDT", JdeDataType.Numeric),
        new JdeField("GAURAT", "GAURAT", JdeDataType.Numeric),
        new JdeField("GAURRF", "GAURRF", JdeDataType.String, 30),
        new JdeField("GAURAB", "GAURAB", JdeDataType.Numeric),
        new JdeField("GAUSER", "GAUSER", JdeDataType.String, 20),
        new JdeField("GAPID", "GAPID", JdeDataType.String, 20),
        new JdeField("GAJOBN", "GAJOBN", JdeDataType.String, 20),
        new JdeField("GAUPMJ", "GAUPMJ", JdeDataType.Numeric),
        new JdeField("GAUPMT", "GAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B37_0", "Primary Key on GAGOAID", new[] { "GAGOAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B37_2", "Index on GAGOAREA", new[] { "GAGOAREA" }),
        new JdeIndex("F31B37_3", "Index on GASORDNO, GAGOAREA", new[] { "GASORDNO", "GAGOAREA" }),
        new JdeIndex("F31B37_4", "Index on GAGOATYPE, GAGOAREA", new[] { "GAGOATYPE", "GAGOAREA" })
    };
}
