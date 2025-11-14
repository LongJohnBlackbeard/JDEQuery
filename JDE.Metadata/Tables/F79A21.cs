using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A21 - .
/// </summary>
public class F79A21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTUKID.
        /// </summary>
        public const string GTUKID = "GTUKID";

        /// <summary>
        /// GT79AGETY.
        /// </summary>
        public const string GT79AGETY = "GT79AGETY";

        /// <summary>
        /// GT79AGERID.
        /// </summary>
        public const string GT79AGERID = "GT79AGERID";

        /// <summary>
        /// GT79AGUM.
        /// </summary>
        public const string GT79AGUM = "GT79AGUM";

        /// <summary>
        /// GT79ASGQ.
        /// </summary>
        public const string GT79ASGQ = "GT79ASGQ";

        /// <summary>
        /// GT79AGCUM.
        /// </summary>
        public const string GT79AGCUM = "GT79AGCUM";

        /// <summary>
        /// GT79ACO2Q.
        /// </summary>
        public const string GT79ACO2Q = "GT79ACO2Q";

        /// <summary>
        /// GTURCD.
        /// </summary>
        public const string GTURCD = "GTURCD";

        /// <summary>
        /// GTURRF.
        /// </summary>
        public const string GTURRF = "GTURRF";

        /// <summary>
        /// GTURAB.
        /// </summary>
        public const string GTURAB = "GTURAB";

        /// <summary>
        /// GTURAT.
        /// </summary>
        public const string GTURAT = "GTURAT";

        /// <summary>
        /// GTURDT.
        /// </summary>
        public const string GTURDT = "GTURDT";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTJOBN.
        /// </summary>
        public const string GTJOBN = "GTJOBN";

        /// <summary>
        /// GTUPMJ.
        /// </summary>
        public const string GTUPMJ = "GTUPMJ";

        /// <summary>
        /// GTTDAY.
        /// </summary>
        public const string GTTDAY = "GTTDAY";

        /// <summary>
        /// GT79AGCM.
        /// </summary>
        public const string GT79AGCM = "GT79AGCM";
    }

    /// <inheritdoc />
    public override string TableName => "F79A21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTUKID", "GTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GT79AGETY", "GT79AGETY", JdeDataType.String, 20, true, true),
        new JdeField("GT79AGERID", "GT79AGERID", JdeDataType.Numeric),
        new JdeField("GT79AGUM", "GT79AGUM", JdeDataType.String, 30),
        new JdeField("GT79ASGQ", "GT79ASGQ", JdeDataType.Numeric),
        new JdeField("GT79AGCUM", "GT79AGCUM", JdeDataType.String, 4),
        new JdeField("GT79ACO2Q", "GT79ACO2Q", JdeDataType.Numeric),
        new JdeField("GTURCD", "GTURCD", JdeDataType.String, 4),
        new JdeField("GTURRF", "GTURRF", JdeDataType.String, 30),
        new JdeField("GTURAB", "GTURAB", JdeDataType.Numeric),
        new JdeField("GTURAT", "GTURAT", JdeDataType.Numeric),
        new JdeField("GTURDT", "GTURDT", JdeDataType.Numeric),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric),
        new JdeField("GTTDAY", "GTTDAY", JdeDataType.Numeric),
        new JdeField("GT79AGCM", "GT79AGCM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A21_0", "Primary Key on GTUKID, GT79AGETY", new[] { "GTUKID", "GT79AGETY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A21_2", "Index on GT79AGERID", new[] { "GT79AGERID" })
    };
}
