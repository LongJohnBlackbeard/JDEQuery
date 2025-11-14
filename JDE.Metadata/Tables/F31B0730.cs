using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0730 - .
/// </summary>
public class F31B0730 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LAEURID.
        /// </summary>
        public const string LAEURID = "LAEURID";

        /// <summary>
        /// LATOTLOSS.
        /// </summary>
        public const string LATOTLOSS = "LATOTLOSS";

        /// <summary>
        /// LASRVTHR.
        /// </summary>
        public const string LASRVTHR = "LASRVTHR";

        /// <summary>
        /// LAOPTHR.
        /// </summary>
        public const string LAOPTHR = "LAOPTHR";

        /// <summary>
        /// LAYIELDP.
        /// </summary>
        public const string LAYIELDP = "LAYIELDP";

        /// <summary>
        /// LAURAB.
        /// </summary>
        public const string LAURAB = "LAURAB";

        /// <summary>
        /// LAURAT.
        /// </summary>
        public const string LAURAT = "LAURAT";

        /// <summary>
        /// LAURCD.
        /// </summary>
        public const string LAURCD = "LAURCD";

        /// <summary>
        /// LAURDT.
        /// </summary>
        public const string LAURDT = "LAURDT";

        /// <summary>
        /// LAURRF.
        /// </summary>
        public const string LAURRF = "LAURRF";

        /// <summary>
        /// LAJOBN.
        /// </summary>
        public const string LAJOBN = "LAJOBN";

        /// <summary>
        /// LAPID.
        /// </summary>
        public const string LAPID = "LAPID";

        /// <summary>
        /// LATDAY.
        /// </summary>
        public const string LATDAY = "LATDAY";

        /// <summary>
        /// LAUPMJ.
        /// </summary>
        public const string LAUPMJ = "LAUPMJ";

        /// <summary>
        /// LAUSER.
        /// </summary>
        public const string LAUSER = "LAUSER";

        /// <summary>
        /// LAWAB.
        /// </summary>
        public const string LAWAB = "LAWAB";

        /// <summary>
        /// LAWCD.
        /// </summary>
        public const string LAWCD = "LAWCD";

        /// <summary>
        /// LAWMDT.
        /// </summary>
        public const string LAWMDT = "LAWMDT";

        /// <summary>
        /// LAWNUM.
        /// </summary>
        public const string LAWNUM = "LAWNUM";

        /// <summary>
        /// LAWRF.
        /// </summary>
        public const string LAWRF = "LAWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0730";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LAEURID", "LAEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("LATOTLOSS", "LATOTLOSS", JdeDataType.Numeric),
        new JdeField("LASRVTHR", "LASRVTHR", JdeDataType.Numeric),
        new JdeField("LAOPTHR", "LAOPTHR", JdeDataType.Numeric),
        new JdeField("LAYIELDP", "LAYIELDP", JdeDataType.Numeric),
        new JdeField("LAURAB", "LAURAB", JdeDataType.Numeric),
        new JdeField("LAURAT", "LAURAT", JdeDataType.Numeric),
        new JdeField("LAURCD", "LAURCD", JdeDataType.String, 4),
        new JdeField("LAURDT", "LAURDT", JdeDataType.Numeric),
        new JdeField("LAURRF", "LAURRF", JdeDataType.String, 30),
        new JdeField("LAJOBN", "LAJOBN", JdeDataType.String, 20),
        new JdeField("LAPID", "LAPID", JdeDataType.String, 20),
        new JdeField("LATDAY", "LATDAY", JdeDataType.Numeric),
        new JdeField("LAUPMJ", "LAUPMJ", JdeDataType.Numeric),
        new JdeField("LAUSER", "LAUSER", JdeDataType.String, 20),
        new JdeField("LAWAB", "LAWAB", JdeDataType.Numeric),
        new JdeField("LAWCD", "LAWCD", JdeDataType.String, 6),
        new JdeField("LAWMDT", "LAWMDT", JdeDataType.Numeric),
        new JdeField("LAWNUM", "LAWNUM", JdeDataType.Numeric),
        new JdeField("LAWRF", "LAWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0730_0", "Primary Key on LAEURID", new[] { "LAEURID" }, isUnique: true, isPrimaryKey: true)
    };
}
