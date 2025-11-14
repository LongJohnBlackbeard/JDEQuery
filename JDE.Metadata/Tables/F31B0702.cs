using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0702 - .
/// </summary>
public class F31B0702 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESEURID.
        /// </summary>
        public const string ESEURID = "ESEURID";

        /// <summary>
        /// ESSPECID.
        /// </summary>
        public const string ESSPECID = "ESSPECID";

        /// <summary>
        /// ESURAB.
        /// </summary>
        public const string ESURAB = "ESURAB";

        /// <summary>
        /// ESURAT.
        /// </summary>
        public const string ESURAT = "ESURAT";

        /// <summary>
        /// ESURCD.
        /// </summary>
        public const string ESURCD = "ESURCD";

        /// <summary>
        /// ESURDT.
        /// </summary>
        public const string ESURDT = "ESURDT";

        /// <summary>
        /// ESURRF.
        /// </summary>
        public const string ESURRF = "ESURRF";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESTDAY.
        /// </summary>
        public const string ESTDAY = "ESTDAY";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESWAB.
        /// </summary>
        public const string ESWAB = "ESWAB";

        /// <summary>
        /// ESWCD.
        /// </summary>
        public const string ESWCD = "ESWCD";

        /// <summary>
        /// ESWMDT.
        /// </summary>
        public const string ESWMDT = "ESWMDT";

        /// <summary>
        /// ESWNUM.
        /// </summary>
        public const string ESWNUM = "ESWNUM";

        /// <summary>
        /// ESWRF.
        /// </summary>
        public const string ESWRF = "ESWRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0702";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESEURID", "ESEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("ESSPECID", "ESSPECID", JdeDataType.Numeric, null, true, true),
        new JdeField("ESURAB", "ESURAB", JdeDataType.Numeric),
        new JdeField("ESURAT", "ESURAT", JdeDataType.Numeric),
        new JdeField("ESURCD", "ESURCD", JdeDataType.String, 4),
        new JdeField("ESURDT", "ESURDT", JdeDataType.Numeric),
        new JdeField("ESURRF", "ESURRF", JdeDataType.String, 30),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESTDAY", "ESTDAY", JdeDataType.Numeric),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESWAB", "ESWAB", JdeDataType.Numeric),
        new JdeField("ESWCD", "ESWCD", JdeDataType.String, 6),
        new JdeField("ESWMDT", "ESWMDT", JdeDataType.Numeric),
        new JdeField("ESWNUM", "ESWNUM", JdeDataType.Numeric),
        new JdeField("ESWRF", "ESWRF", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0702_0", "Primary Key on ESEURID, ESSPECID", new[] { "ESEURID", "ESSPECID" }, isUnique: true, isPrimaryKey: true)
    };
}
