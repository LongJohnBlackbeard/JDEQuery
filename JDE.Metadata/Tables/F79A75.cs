using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A75 - .
/// </summary>
public class F79A75 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GO79AGONID.
        /// </summary>
        public const string GO79AGONID = "GO79AGONID";

        /// <summary>
        /// GO79AGOID.
        /// </summary>
        public const string GO79AGOID = "GO79AGOID";

        /// <summary>
        /// GO79AGONM.
        /// </summary>
        public const string GO79AGONM = "GO79AGONM";

        /// <summary>
        /// GOADD1.
        /// </summary>
        public const string GOADD1 = "GOADD1";

        /// <summary>
        /// GOADD2.
        /// </summary>
        public const string GOADD2 = "GOADD2";

        /// <summary>
        /// GOADD3.
        /// </summary>
        public const string GOADD3 = "GOADD3";

        /// <summary>
        /// GOADD4.
        /// </summary>
        public const string GOADD4 = "GOADD4";

        /// <summary>
        /// GOCTY1.
        /// </summary>
        public const string GOCTY1 = "GOCTY1";

        /// <summary>
        /// GOCOUN.
        /// </summary>
        public const string GOCOUN = "GOCOUN";

        /// <summary>
        /// GOADDS.
        /// </summary>
        public const string GOADDS = "GOADDS";

        /// <summary>
        /// GOADDZ.
        /// </summary>
        public const string GOADDZ = "GOADDZ";

        /// <summary>
        /// GOCTR.
        /// </summary>
        public const string GOCTR = "GOCTR";

        /// <summary>
        /// GOBEFD.
        /// </summary>
        public const string GOBEFD = "GOBEFD";

        /// <summary>
        /// GOEEFD.
        /// </summary>
        public const string GOEEFD = "GOEEFD";

        /// <summary>
        /// GOPID.
        /// </summary>
        public const string GOPID = "GOPID";

        /// <summary>
        /// GOUSER.
        /// </summary>
        public const string GOUSER = "GOUSER";

        /// <summary>
        /// GOJOBN.
        /// </summary>
        public const string GOJOBN = "GOJOBN";

        /// <summary>
        /// GOUPMJ.
        /// </summary>
        public const string GOUPMJ = "GOUPMJ";

        /// <summary>
        /// GOTDAY.
        /// </summary>
        public const string GOTDAY = "GOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A75";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GO79AGONID", "GO79AGONID", JdeDataType.Numeric, null, true, true),
        new JdeField("GO79AGOID", "GO79AGOID", JdeDataType.Numeric),
        new JdeField("GO79AGONM", "GO79AGONM", JdeDataType.String, 200),
        new JdeField("GOADD1", "GOADD1", JdeDataType.String, 80),
        new JdeField("GOADD2", "GOADD2", JdeDataType.String, 80),
        new JdeField("GOADD3", "GOADD3", JdeDataType.String, 80),
        new JdeField("GOADD4", "GOADD4", JdeDataType.String, 80),
        new JdeField("GOCTY1", "GOCTY1", JdeDataType.String, 50),
        new JdeField("GOCOUN", "GOCOUN", JdeDataType.String, 50),
        new JdeField("GOADDS", "GOADDS", JdeDataType.String, 6),
        new JdeField("GOADDZ", "GOADDZ", JdeDataType.String, 24),
        new JdeField("GOCTR", "GOCTR", JdeDataType.String, 6),
        new JdeField("GOBEFD", "GOBEFD", JdeDataType.Numeric),
        new JdeField("GOEEFD", "GOEEFD", JdeDataType.Numeric),
        new JdeField("GOPID", "GOPID", JdeDataType.String, 20),
        new JdeField("GOUSER", "GOUSER", JdeDataType.String, 20),
        new JdeField("GOJOBN", "GOJOBN", JdeDataType.String, 20),
        new JdeField("GOUPMJ", "GOUPMJ", JdeDataType.Numeric),
        new JdeField("GOTDAY", "GOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A75_0", "Primary Key on GO79AGONID", new[] { "GO79AGONID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A75_2", "Index on GO79AGONM", new[] { "GO79AGONM" }),
        new JdeIndex("F79A75_3", "Unique Index on GO79AGOID, GOBEFD", new[] { "GO79AGOID", "GOBEFD" }, isUnique: true)
    };
}
