using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B342 - .
/// </summary>
public class F31B342 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAENTID.
        /// </summary>
        public const string SAENTID = "SAENTID";

        /// <summary>
        /// SASTENTY.
        /// </summary>
        public const string SASTENTY = "SASTENTY";

        /// <summary>
        /// SASITEM.
        /// </summary>
        public const string SASITEM = "SASITEM";

        /// <summary>
        /// SASVALUE.
        /// </summary>
        public const string SASVALUE = "SASVALUE";

        /// <summary>
        /// SAMCU.
        /// </summary>
        public const string SAMCU = "SAMCU";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SATDAY.
        /// </summary>
        public const string SATDAY = "SATDAY";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAURAT.
        /// </summary>
        public const string SAURAT = "SAURAT";

        /// <summary>
        /// SAURCD.
        /// </summary>
        public const string SAURCD = "SAURCD";

        /// <summary>
        /// SAURDT.
        /// </summary>
        public const string SAURDT = "SAURDT";

        /// <summary>
        /// SAURRF.
        /// </summary>
        public const string SAURRF = "SAURRF";

        /// <summary>
        /// SAURAB.
        /// </summary>
        public const string SAURAB = "SAURAB";

        /// <summary>
        /// SASTYLEDT.
        /// </summary>
        public const string SASTYLEDT = "SASTYLEDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B342";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAENTID", "SAENTID", JdeDataType.Numeric, null, true, true),
        new JdeField("SASTENTY", "SASTENTY", JdeDataType.String, 6, true, true),
        new JdeField("SASITEM", "SASITEM", JdeDataType.String, 24, true, true),
        new JdeField("SASVALUE", "SASVALUE", JdeDataType.Numeric),
        new JdeField("SAMCU", "SAMCU", JdeDataType.String, 24, true, true),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SATDAY", "SATDAY", JdeDataType.Numeric),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAURAT", "SAURAT", JdeDataType.Numeric),
        new JdeField("SAURCD", "SAURCD", JdeDataType.String, 4),
        new JdeField("SAURDT", "SAURDT", JdeDataType.Numeric),
        new JdeField("SAURRF", "SAURRF", JdeDataType.String, 30),
        new JdeField("SAURAB", "SAURAB", JdeDataType.Numeric),
        new JdeField("SASTYLEDT", "SASTYLEDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B342_0", "Primary Key on SASTENTY, SAENTID, SASITEM, SAMCU", new[] { "SASTENTY", "SAENTID", "SASITEM", "SAMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B342_2", "Index on SAENTID, SASTENTY, SAMCU", new[] { "SAENTID", "SASTENTY", "SAMCU" })
    };
}
